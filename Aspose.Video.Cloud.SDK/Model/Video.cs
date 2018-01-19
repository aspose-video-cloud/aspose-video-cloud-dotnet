// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Video.cs">
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

namespace Aspose.Video.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Represents Video file DTO.
  /// </summary>  
  public class Video 
  {                       
        /// <summary>
        /// A list of links that originate from this Video file.
        /// </summary>  
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets the name of the file.
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>
        /// Gets the original format of the video.
        /// </summary>  
        public string SourceFormat { get; set; }

        /// <summary>
        /// Returns Video file properties.
        /// </summary>  
        public VideoProperties VideoProperties { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Video {\n");
          sb.Append("  Links: ").Append(this.Links).Append("\n");
          sb.Append("  FileName: ").Append(this.FileName).Append("\n");
          sb.Append("  SourceFormat: ").Append(this.SourceFormat).Append("\n");
          sb.Append("  VideoProperties: ").Append(this.VideoProperties).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
