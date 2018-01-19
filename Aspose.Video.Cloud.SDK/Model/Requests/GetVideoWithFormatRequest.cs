// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetVideoWithFormatRequest.cs">
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
namespace Aspose.Video.Cloud.Sdk.Model.Requests 
{
  using Aspose.Video.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Video.Cloud.Sdk.Api.VideoApi.GetVideoWithFormat" /> operation.
  /// </summary>  
  public class GetVideoWithFormatRequest : IVideoFileRequest, ICanSpecifyOutputFormatRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoWithFormatRequest"/> class.
        /// </summary>        
        public GetVideoWithFormatRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoWithFormatRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="format">The destination format.</param>
        /// <param name="folder">Original video folder.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="resultPath">Path to save result</param>
        public GetVideoWithFormatRequest(string name, string format, string folder = null, string storage = null, string resultPath = null)             
        {
            this.Name = name;
            this.Format = format;
            this.Folder = folder;
            this.Storage = storage;
            this.ResultPath = resultPath;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Original video folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Path to save result
        /// </summary>  
        public string ResultPath { get; set; }
  }
}
