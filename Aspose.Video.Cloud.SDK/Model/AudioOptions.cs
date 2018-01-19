// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AudioOptions.cs">
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
  /// Audio properties of the video file
  /// </summary>  
  public class AudioOptions 
  {                       
        /// <summary>
        /// Represents original audio format
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Represents original audio sample rate
        /// </summary>  
        public string SampleRate { get; set; }

        /// <summary>
        /// Represents original channel output
        /// </summary>  
        public string ChannelOutput { get; set; }

        /// <summary>
        /// Represents original audio bitrate
        /// </summary>  
        public int? Bitrate { get; set; }

        /// <summary>
        /// Represents audio track id number if the original file contains more than one audio track
        /// </summary>  
        public int? TrackId { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AudioOptions {\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  SampleRate: ").Append(this.SampleRate).Append("\n");
          sb.Append("  ChannelOutput: ").Append(this.ChannelOutput).Append("\n");
          sb.Append("  Bitrate: ").Append(this.Bitrate).Append("\n");
          sb.Append("  TrackId: ").Append(this.TrackId).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
