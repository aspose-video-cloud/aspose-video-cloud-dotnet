// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostCreateSlideshowRequest.cs">
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
  /// Request model for <see cref="Aspose.Video.Cloud.Sdk.Api.VideoApi.PostCreateSlideshow" /> operation.
  /// </summary>  
  public class PostCreateSlideshowRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCreateSlideshowRequest"/> class.
        /// </summary>        
        public PostCreateSlideshowRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCreateSlideshowRequest"/> class.
        /// </summary>
        /// <param name="destinationPath">Path where to save the result file.</param>
        /// <param name="slides">Audio options.              </param>
        public PostCreateSlideshowRequest(string destinationPath, SlideshowOptions slides)             
        {
            this.DestinationPath = destinationPath;
            this.Slides = slides;
        }

        /// <summary>
        /// Path where to save the result file.
        /// </summary>  
        public string DestinationPath { get; set; }

        /// <summary>
        /// Audio options.              
        /// </summary>  
        public SlideshowOptions Slides { get; set; }
  }
}
