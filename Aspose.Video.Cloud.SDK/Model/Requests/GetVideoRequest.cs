// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetVideoRequest.cs">
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
  /// Request model for <see cref="Aspose.Video.Cloud.Sdk.Api.VideoApi.GetVideo" /> operation.
  /// </summary>  
  public class GetVideoRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoRequest"/> class.
        /// </summary>        
        public GetVideoRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoRequest"/> class.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <param name="folder">Original video folder.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        public GetVideoRequest(string fileName, string folder = null, string storage = null)             
        {
            this.FileName = fileName;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>
        /// Original video folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }
  }
}
