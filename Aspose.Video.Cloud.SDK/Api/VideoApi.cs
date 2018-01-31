// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="VideoApi.cs">
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

namespace Aspose.Video.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Aspose.Video.Cloud.Sdk.Model;
    using Aspose.Video.Cloud.Sdk.Model.Requests;

    /// <summary>
    /// Aspose.Video for Cloud API.
    /// </summary>
    public class VideoApi
    {        
        private readonly ApiInvoker apiInvoker;        

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="apiBaseUrl">
        /// Aspose Cloud API base URL.
        /// </param>
        /// <param name="debug">
        /// Allows to see the SDK debugging messages.
        /// </param>
        public VideoApi(string apiKey, string appSid, string apiBaseUrl, bool debug = false)
        {
            this.apiInvoker = new ApiInvoker(apiKey, appSid, apiBaseUrl, debug);
        }                     

        /// <summary>
        /// Read video common info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetVideoRequest" /></param> 
        /// <returns><see cref="VideoResponse"/></returns>            
        public VideoResponse GetVideo(GetVideoRequest request)
        {
            // verify the required parameter 'fileName' is set
            if (request.FileName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling GetVideo");
            }

            // create path and map variables
            var resourcePath = "/video/{fileName}?appSid={appSid}&amp;folder=[folder]&amp;storage=[storage]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = this.AddPathParameter(resourcePath, "fileName", request.FileName);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (VideoResponse)SerializationHelper.Deserialize(response, typeof(VideoResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read video properties info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetVideoPropertiesRequest" /></param> 
        /// <returns><see cref="VideoPropertiesResponse"/></returns>            
        public VideoPropertiesResponse GetVideoProperties(GetVideoPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetVideoProperties");
            }

            // create path and map variables
            var resourcePath = "/video/{name}/videoProperties?appSid={appSid}&amp;folder=[folder]&amp;storage=[storage]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (VideoPropertiesResponse)SerializationHelper.Deserialize(response, typeof(VideoPropertiesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Read video property info by the property name. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetVideoPropertyRequest" /></param> 
        /// <returns><see cref="VideoPropertyResponse"/></returns>            
        public VideoPropertyResponse GetVideoProperty(GetVideoPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetVideoProperty");
            }

            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling GetVideoProperty");
            }

            // create path and map variables
            var resourcePath = "/video/{name}/videoProperties/{propertyName}?appSid={appSid}&amp;folder=[folder]&amp;storage=[storage]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (VideoPropertyResponse)SerializationHelper.Deserialize(response, typeof(VideoPropertyResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export the document into the specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetVideoWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetVideoWithFormat(GetVideoWithFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetVideoWithFormat");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetVideoWithFormat");
            }

            // create path and map variables
            var resourcePath = "/video/{name}?appSid={appSid}&amp;format=[format]&amp;folder=[folder]&amp;storage=[storage]&amp;resultPath=[resultPath]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.Format);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "resultPath", request.ResultPath);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null) as System.IO.Stream;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Add audio to original video. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddAudioRequest" /></param> 
        /// <returns><see cref="VideoResponse"/></returns>            
        public VideoResponse PostAddAudio(PostAddAudioRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddAudio");
            }

            // verify the required parameter 'destinationPath' is set
            if (request.DestinationPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destinationPath' when calling PostAddAudio");
            }

            // verify the required parameter 'audio' is set
            if (request.Audio == null) 
            {
                throw new ApiException(400, "Missing required parameter 'audio' when calling PostAddAudio");
            }

            // create path and map variables
            var resourcePath = "/video/{name}/addAudio?appSid={appSid}&amp;destinationPath=[destinationPath]&amp;folder=[folder]&amp;storage=[storage]&amp;destFileName=[destFileName]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destinationPath", request.DestinationPath);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            var postBody = request.Audio; // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (VideoResponse)SerializationHelper.Deserialize(response, typeof(VideoResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Append video to original video. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAppendVideoRequest" /></param> 
        /// <returns><see cref="VideoResponse"/></returns>            
        public VideoResponse PostAppendVideo(PostAppendVideoRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAppendVideo");
            }

            // verify the required parameter 'destinationPath' is set
            if (request.DestinationPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destinationPath' when calling PostAppendVideo");
            }

            // verify the required parameter 'appendOptions' is set
            if (request.AppendOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'appendOptions' when calling PostAppendVideo");
            }

            // create path and map variables
            var resourcePath = "/video/{name}/appendVideo?appSid={appSid}&amp;destinationPath=[destinationPath]&amp;folder=[folder]&amp;storage=[storage]&amp;destFileName=[destFileName]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destinationPath", request.DestinationPath);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            var postBody = request.AppendOptions; // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (VideoResponse)SerializationHelper.Deserialize(response, typeof(VideoResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Convert document from request content to format specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertVideoRequest" /></param> 
        /// <returns><see cref="SaveResponse"/></returns>            
        public SaveResponse PostConvertVideo(PostConvertVideoRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostConvertVideo");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostConvertVideo");
            }

            // verify the required parameter 'resultPath' is set
            if (request.ResultPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'resultPath' when calling PostConvertVideo");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostConvertVideo");
            }

            // create path and map variables
            var resourcePath = "/video/{name}/convert?appSid={appSid}&amp;format=[format]&amp;resultPath=[resultPath]&amp;folder=[folder]&amp;storage=[storage]&amp;destFileName=[destFileName]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.Format);
            resourcePath = this.AddQueryParameter(resourcePath, "resultPath", request.ResultPath);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            var postBody = request.Options; // http body (model) parameter
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        postBody, 
                        null, 
                        null) as SaveResponse;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Extract audio from the original video. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostExtractAudioRequest" /></param> 
        /// <returns><see cref="VideoResponse"/></returns>            
        public VideoResponse PostExtractAudio(PostExtractAudioRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostExtractAudio");
            }

            // verify the required parameter 'destinationPath' is set
            if (request.DestinationPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destinationPath' when calling PostExtractAudio");
            }

            // verify the required parameter 'trackId' is set
            if (request.TrackId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'trackId' when calling PostExtractAudio");
            }

            // create path and map variables
            var resourcePath = "/video/{name}/extractAudio?appSid={appSid}&amp;destinationPath=[destinationPath]&amp;folder=[folder]&amp;storage=[storage]&amp;destFileName=[destFileName]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destinationPath", request.DestinationPath);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            var postBody = request.TrackId; // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (VideoResponse)SerializationHelper.Deserialize(response, typeof(VideoResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Create a thumbnail image. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostExtractThumbnailRequest" /></param> 
        /// <returns><see cref="ExtractThumbnailResponse"/></returns>            
        public ExtractThumbnailResponse PostExtractThumbnail(PostExtractThumbnailRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostExtractThumbnail");
            }

            // verify the required parameter 'destinationPath' is set
            if (request.DestinationPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destinationPath' when calling PostExtractThumbnail");
            }

            // verify the required parameter 'offset' is set
            if (request.Offset == null) 
            {
                throw new ApiException(400, "Missing required parameter 'offset' when calling PostExtractThumbnail");
            }

            // create path and map variables
            var resourcePath = "/video/{name}/extractThumbnail?appSid={appSid}&amp;destinationPath=[destinationPath]&amp;offset=[offset]&amp;folder=[folder]&amp;storage=[storage]&amp;destFileName=[destFileName]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destinationPath", request.DestinationPath);
            resourcePath = this.AddQueryParameter(resourcePath, "offset", request.Offset);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ExtractThumbnailResponse)SerializationHelper.Deserialize(response, typeof(ExtractThumbnailResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Extract video. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostExtractVideoRequest" /></param> 
        /// <returns><see cref="ExtractVideoResponse"/></returns>            
        public ExtractVideoResponse PostExtractVideo(PostExtractVideoRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostExtractVideo");
            }

            // verify the required parameter 'destinationPath' is set
            if (request.DestinationPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destinationPath' when calling PostExtractVideo");
            }

            // verify the required parameter 'start' is set
            if (request.Start == null) 
            {
                throw new ApiException(400, "Missing required parameter 'start' when calling PostExtractVideo");
            }

            // verify the required parameter 'offset' is set
            if (request.Offset == null) 
            {
                throw new ApiException(400, "Missing required parameter 'offset' when calling PostExtractVideo");
            }

            // create path and map variables
            var resourcePath = "/video/{name}/extract?appSid={appSid}&amp;destinationPath=[destinationPath]&amp;start=[start]&amp;offset=[offset]&amp;folder=[folder]&amp;storage=[storage]&amp;destFileName=[destFileName]&amp;fontsLocation=[fontsLocation]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destinationPath", request.DestinationPath);
            resourcePath = this.AddQueryParameter(resourcePath, "start", request.Start);
            resourcePath = this.AddQueryParameter(resourcePath, "offset", request.Offset);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.FontsLocation);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ExtractVideoResponse)SerializationHelper.Deserialize(response, typeof(ExtractVideoResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Loads new video from web into the file with any supported format of data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostLoadWebVideoRequest" /></param> 
        /// <returns><see cref="SaveResponse"/></returns>            
        public SaveResponse PostLoadWebVideo(PostLoadWebVideoRequest request)
        {
            // verify the required parameter 'data' is set
            if (request.Data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PostLoadWebVideo");
            }

            // create path and map variables
            var resourcePath = "/video/loadWebVideo?appSid={appSid}&amp;storage=[storage]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            var postBody = request.Data; // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (SaveResponse)SerializationHelper.Deserialize(response, typeof(SaveResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Remove audio from the original video. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostRemoveAudioRequest" /></param> 
        /// <returns><see cref="VideoResponse"/></returns>            
        public VideoResponse PostRemoveAudio(PostRemoveAudioRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostRemoveAudio");
            }

            // verify the required parameter 'destinationPath' is set
            if (request.DestinationPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destinationPath' when calling PostRemoveAudio");
            }

            // verify the required parameter 'tracksId' is set
            if (request.TracksId == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tracksId' when calling PostRemoveAudio");
            }

            // create path and map variables
            var resourcePath = "/video/{name}/removeAudio?appSid={appSid}&amp;destinationPath=[destinationPath]&amp;folder=[folder]&amp;storage=[storage]&amp;destFileName=[destFileName]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destinationPath", request.DestinationPath);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            var postBody = request.TracksId; // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (VideoResponse)SerializationHelper.Deserialize(response, typeof(VideoResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        private string AddPathParameter(string url, string parameterName, object parameterValue)
        {
            if (parameterValue == null || string.IsNullOrEmpty(parameterValue.ToString()))
            {
                url = url.Replace("/{" + parameterName + "}", string.Empty);
            }
            else
            {
                url = url.Replace("{" + parameterName + "}", this.apiInvoker.ToPathValue(parameterValue));
            }

            return url;
        }

        private string AddQueryParameter(string url, string parameterName, object parameterValue)
        {
            if (url.Contains("{" + parameterName + "}"))
            {
                url = Regex.Replace(url, @"([&?])" + parameterName + @"=\[" + parameterName + @"\]", string.Empty);
                url = this.AddPathParameter(url, parameterName, parameterValue);
                return url;
            }

            if (parameterValue == null) 
            {
                url = Regex.Replace(url, @"([&?])" + parameterName + @"=\[" + parameterName + @"\]", string.Empty);
            } 
            else 
            {
                url = url.Replace("[" + parameterName + "]", this.apiInvoker.ToPathValue(parameterValue));
            }
          
            return url;
        }
    }
}
