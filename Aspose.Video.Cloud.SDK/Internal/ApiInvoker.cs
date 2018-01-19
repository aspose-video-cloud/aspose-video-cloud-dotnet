// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiInvoker.cs">
//   Copyright (c) 2018 Aspose.Video for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Video.Cloud.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web;

    using Aspose.Video.Cloud.Sdk.Model;

    internal class ApiInvoker
    {
        private const string AppSidParamTemplate = "{appSid}";
        private const string AsposeClientHeaderName = "x-aspose-client";

        private readonly string apiBaseUrl;
        private readonly string apiKey;
        private readonly string appSid;

        private readonly bool debug;

        private readonly Dictionary<string, string> defaultHeaderMap = new Dictionary<string, string>();

        public ApiInvoker(string apiKey, string appSid, string apiBaseUrl, bool debug)
        {
            this.AddDefaultHeader(AsposeClientHeaderName, ".net sdk");

            this.apiBaseUrl = apiBaseUrl.EndsWith("/") ? apiBaseUrl.Substring(0, apiBaseUrl.Length - 1) : apiBaseUrl;
            this.apiKey = apiKey;
            this.appSid = appSid;
            this.debug = debug;
        }

        public string InvokeApi(
            string path,
            string method,
            object body,
            Dictionary<string, string> headerParams,
            Dictionary<string, object> formParams)
        {
            return this.InvokeInternal(path, method, false, body, headerParams, formParams) as string;
        }

        public object InvokeBinaryApi(
            string path,
            string method,
            object body,
            Dictionary<string, string> headerParams,
            Dictionary<string, object> formParams)
        {
            return this.InvokeInternal(path, method, true, body, headerParams, formParams);
        }

        public string ToPathValue(object value)
        {
            return value.ToString();
        }

        public FileInfo ToFileInfo(Stream stream, string paramName)
        {
            // TODO: add contenttype
            return new FileInfo { Name = paramName, FileContent = StreamHelper.ReadAsBytes(stream) };
        }

        private static string Sign(string url, string appKey)
        {
            UriBuilder uriBuilder = new UriBuilder(url);

            // Remove final slash here as it can be added automatically.
            uriBuilder.Path = uriBuilder.Path.TrimEnd('/');

            // Compute the hash.
            byte[] privateKey = Encoding.UTF8.GetBytes(appKey);
            HMACSHA1 algorithm = new HMACSHA1(privateKey);

            byte[] sequence = Encoding.ASCII.GetBytes(uriBuilder.Uri.AbsoluteUri);
            byte[] hash = algorithm.ComputeHash(sequence);
            string signature = Convert.ToBase64String(hash);

            // Remove invalid symbols.
            signature = signature.TrimEnd('=');
            signature = HttpUtility.UrlEncode(signature);

            // Convert codes to upper case as they can be updated automatically.
            signature = Regex.Replace(signature, "%[0-9a-f]{2}", e => e.Value.ToUpper());

            // Add the signature to query string.
            return string.Format("{0}&signature={1}", uriBuilder.Uri.AbsoluteUri, signature);
        }

        private static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
        {
            Stream formDataStream = new MemoryStream();
            bool needsClrf = false;

            if (postParameters.Count > 1)
            {
                foreach (var param in postParameters)
                {
                    // Thanks to feedback from commenters, add a CRLF to allow multiple parameters to be added.
                    // Skip it on the first parameter, add it to subsequent parameters.
                    if (needsClrf)
                    {
                        formDataStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, Encoding.UTF8.GetByteCount("\r\n"));
                    }

                    needsClrf = true;

                    if (param.Value is FileInfo)
                    {
                        var fileInfo = (FileInfo)param.Value;
                        string postData =
                            string.Format(
                                "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n",
                                boundary,
                                param.Key,
                                fileInfo.MimeType);
                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));

                        // Write the file data directly to the Stream, rather than serializing it to a string.
                        formDataStream.Write(fileInfo.FileContent, 0, fileInfo.FileContent.Length);
                    }
                    else
                    {
                        var stringDaa = SerializationHelper.Serialize(param.Value);
                        string postData =
                            string.Format(
                                "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}",
                                boundary,
                                param.Key,
                                stringDaa);
                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));
                    }
                }

                // Add the end of the request.  Start with a newline
                string footer = "\r\n--" + boundary + "--\r\n";
                formDataStream.Write(Encoding.UTF8.GetBytes(footer), 0, Encoding.UTF8.GetByteCount(footer));
            }
            else
            {
                foreach (var param in postParameters)
                {
                    if (param.Value is FileInfo)
                    {
                        var fileInfo = (FileInfo)param.Value;

                        // Write the file data directly to the Stream, rather than serializing it to a string.
                        formDataStream.Write(fileInfo.FileContent, 0, fileInfo.FileContent.Length);
                    }
                    else
                    {
                        string postData;
                        if (!(param.Value is string))
                        {
                            postData = SerializationHelper.Serialize(param.Value);
                        }
                        else
                        {
                            postData = (string)param.Value;
                        }

                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));
                    }
                }
            }

            // Dump the Stream into a byte[]
            formDataStream.Position = 0;
            byte[] formData = new byte[formDataStream.Length];
            formDataStream.Read(formData, 0, formData.Length);
            formDataStream.Close();

            return formData;
        }

        private void AddDefaultHeader(string key, string value)
        {
            if (!this.defaultHeaderMap.ContainsKey(key))
            {
                this.defaultHeaderMap.Add(key, value);
            }
        }

        private object InvokeInternal(
            string path,
            string method,
            bool binaryResponse,
            object body,
            Dictionary<string, string> headerParams,
            Dictionary<string, object> formParams)
        {
            if (formParams == null)
            {
                formParams = new Dictionary<string, object>();
            }

            if (headerParams == null)
            {
                headerParams = new Dictionary<string, string>();
            }

            path = path.Replace(AppSidParamTemplate, this.appSid);
            path = Regex.Replace(path, @"{.+?}", string.Empty);
            path = Sign(this.apiBaseUrl + path, this.apiKey);

            var client = this.PrepareRequest(path, method, formParams, headerParams, body);
            return this.ReadResponse(client, binaryResponse);
        }

        private WebRequest PrepareRequest(string path, string method, Dictionary<string, object> formParams, Dictionary<string, string> headerParams, object body)
        {
            var client = WebRequest.Create(path);
            client.Method = method;

            byte[] formData = null;
            if (formParams.Count > 0)
            {
                if (formParams.Count > 1)
                {
                    string formDataBoundary = "Somthing";
                    client.ContentType = "multipart/form-data; boundary=" + formDataBoundary;
                    formData = GetMultipartFormData(formParams, formDataBoundary);
                }
                else
                {
                    client.ContentType = "multipart/form-data";
                    formData = GetMultipartFormData(formParams, string.Empty);
                }

                client.ContentLength = formData.Length;
            }
            else
            {
                client.ContentType = "application/json";
            }

            foreach (var headerParamsItem in headerParams)
            {
                client.Headers.Add(headerParamsItem.Key, headerParamsItem.Value);
            }

            foreach (var defaultHeaderMapItem in this.defaultHeaderMap)
            {
                if (!headerParams.ContainsKey(defaultHeaderMapItem.Key))
                {
                    client.Headers.Add(defaultHeaderMapItem.Key, defaultHeaderMapItem.Value);
                }
            }

            MemoryStream streamToSend = null;
            try
            {
                switch (method)
                {
                    case "GET":
                        break;
                    case "POST":
                    case "PUT":
                    case "DELETE":
                        streamToSend = new MemoryStream();

                        if (formData != null)
                        {
                            streamToSend.Write(formData, 0, formData.Length);
                        }

                        if (body != null)
                        {
                            var requestWriter = new StreamWriter(streamToSend);
                            requestWriter.Write(SerializationHelper.Serialize(body));
                            requestWriter.Flush();
                        }

                        streamToSend.Position = 0;

                        break;
                    default:
                        throw new ApiException(500, "unknown method type " + method);
                }

                if (streamToSend != null)
                {
                    using (Stream requestStream = client.GetRequestStream())
                    {
                        StreamHelper.CopyTo(streamToSend, requestStream);
                    }
                }

                if (this.debug)
                {
                    this.LogRequest(client, streamToSend);
                }
            }
            finally
            {
                if (streamToSend != null)
                {
                    streamToSend.Dispose();
                }
            }

            return client;
        }

        private object ReadResponse(WebRequest client, bool binaryResponse)
        {
            try
            {
                var webResponse = (HttpWebResponse)client.GetResponse();
                var resultStream = new MemoryStream();
                StreamHelper.CopyTo(webResponse.GetResponseStream(), resultStream);
                resultStream.Position = 0;

                if (this.debug)
                {
                    this.LogResponse(webResponse, resultStream);
                }

                if (webResponse.StatusCode != HttpStatusCode.OK)
                {
                    this.ThrowApiException(webResponse);
                }

                if (binaryResponse)
                {
                    return resultStream;
                }

                using (var responseReader = new StreamReader(resultStream))
                {
                    var responseData = responseReader.ReadToEnd();
                    return responseData;
                }
            }
            catch (WebException ex)
            {
                var response = ex.Response as HttpWebResponse;
                this.ThrowApiException(response);
                throw;
            }
        }

        private void ThrowApiException(HttpWebResponse webResponse)
        {
            try
            {
                using (var responseReader = new StreamReader(webResponse.GetResponseStream()))
                {
                    var responseData = responseReader.ReadToEnd();
                    var errorResponse = (VideoApiErrorResponse)SerializationHelper.Deserialize(responseData, typeof(VideoApiErrorResponse));
                    throw new ApiException((int)webResponse.StatusCode, errorResponse.Message);
                }
            }
            catch (ApiException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ApiException((int)webResponse.StatusCode, webResponse.StatusDescription);
            }
        }

        private void LogRequest(WebRequest request, Stream streamToSend)
        {
            var header = string.Format("{0}: {1}", request.Method, request.RequestUri);
            var sb = new StringBuilder();

            this.FormatHeaders(sb, request.Headers);
            this.CopyStreamToStringBuilder(sb, streamToSend);

            this.Log(header, sb);
        }

        private void LogResponse(HttpWebResponse response, Stream resultStream)
        {
            var header = string.Format("\r\nResponse {0}: {1}", (int)response.StatusCode, response.StatusCode);
            var sb = new StringBuilder();

            this.FormatHeaders(sb, response.Headers);
            this.CopyStreamToStringBuilder(sb, resultStream);
            this.Log(header, sb);
        }

        private void FormatHeaders(StringBuilder sb, WebHeaderCollection headerDictionary)
        {
            foreach (var key in headerDictionary.AllKeys)
            {
                sb.Append(key);
                sb.Append(": ");
                sb.AppendLine(headerDictionary[key]);
            }
        }

        private void Log(string header, StringBuilder sb)
        {
            Trace.WriteLine(header);
            Trace.WriteLine(sb.ToString());
        }

        private void CopyStreamToStringBuilder(StringBuilder sb, Stream stream)
        {
            if ((stream == null) || !stream.CanRead)
            {
                return;
            }

            Stream streamToRead;
            if (!stream.CanSeek)
            {
                streamToRead = new MemoryStream(1024);
                StreamHelper.CopyTo(stream, streamToRead);
            }
            else
            {
                streamToRead = stream;
            }

            streamToRead.Seek(0, SeekOrigin.Begin);
            var bodyReader = new StreamReader(streamToRead);
            if (bodyReader.Peek() != -1)
            {
                var content = bodyReader.ReadToEnd();
                streamToRead.Seek(0, SeekOrigin.Begin);

                sb.AppendLine("Body:");
                sb.AppendLine(content);
            }
        }
    }
}
