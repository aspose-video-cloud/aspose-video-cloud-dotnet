// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetVideoPropertiesRequest.cs">
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
  /// Request model for <see cref="Aspose.Video.Cloud.Sdk.Api.VideoApi.GetVideoProperties" /> operation.
  /// </summary>  
  public class GetVideoPropertiesRequest : IVideoFileRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoPropertiesRequest"/> class.
        /// </summary>        
        public GetVideoPropertiesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoPropertiesRequest"/> class.
        /// </summary>
        /// <param name="name">The video&#39;s name.</param>
        /// <param name="folder">Original video folder.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        public GetVideoPropertiesRequest(string name, string folder = null, string storage = null)             
        {
            this.Name = name;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// The video's name.
        /// </summary>  
        public string Name { get; set; }

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
