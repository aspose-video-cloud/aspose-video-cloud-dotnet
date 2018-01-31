// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AudioContainer.cs">
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
  /// container class for add audio track options
  /// </summary>  
  public class AudioContainer 
  {                       
        /// <summary>
        /// Gets or sets a value determining the path of the audio file which will be added as new audio track.
        /// </summary>  
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets a value determining the starting time point of the video from which the audio track will be added. Default value is 0
        /// </summary>  
        public long? Start { get; set; }

        /// <summary>
        /// Gets or sets a value determining the end time point of the video up to which the audio track will be added. Default value is total video duration
        /// </summary>  
        public long? End { get; set; }

        /// <summary>
        /// Gets or sets a value determining the offset for the audio - from which time position of the audio should be used. Default value is 0
        /// </summary>  
        public long? Offset { get; set; }

        /// <summary>
        /// Gets or sets a value determining the volume level for this audio track. Default value is 100
        /// </summary>  
        public int? Volume { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AudioContainer {\n");
          sb.Append("  Path: ").Append(this.Path).Append("\n");
          sb.Append("  Start: ").Append(this.Start).Append("\n");
          sb.Append("  End: ").Append(this.End).Append("\n");
          sb.Append("  Offset: ").Append(this.Offset).Append("\n");
          sb.Append("  Volume: ").Append(this.Volume).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
