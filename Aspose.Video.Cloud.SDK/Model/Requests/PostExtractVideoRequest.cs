// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostExtractVideoRequest.cs">
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
  /// Request model for <see cref="Aspose.Video.Cloud.Sdk.Api.VideoApi.PostExtractVideo" /> operation.
  /// </summary>  
  public class PostExtractVideoRequest : ICanModifyVideoFileRequest, IVideoFileRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostExtractVideoRequest"/> class.
        /// </summary>        
        public PostExtractVideoRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostExtractVideoRequest"/> class.
        /// </summary>
        /// <param name="name">Original video name.</param>
        /// <param name="destinationPath">result video path</param>
        /// <param name="start">Time position from which start extraction.</param>
        /// <param name="offset">How long the extracted part will be - how much seconds should be extracted from the start position.</param>
        /// <param name="folder">Original video folder.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public PostExtractVideoRequest(string name, string destinationPath, long? start, long? offset, string folder = null, string storage = null, string destFileName = null, string fontsLocation = null)             
        {
            this.Name = name;
            this.DestinationPath = destinationPath;
            this.Start = start;
            this.Offset = offset;
            this.Folder = folder;
            this.Storage = storage;
            this.DestFileName = destFileName;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// Original video name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// result video path
        /// </summary>  
        public string DestinationPath { get; set; }

        /// <summary>
        /// Time position from which start extraction.
        /// </summary>  
        public long? Start { get; set; }

        /// <summary>
        /// How long the extracted part will be - how much seconds should be extracted from the start position.
        /// </summary>  
        public long? Offset { get; set; }

        /// <summary>
        /// Original video folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }
}
