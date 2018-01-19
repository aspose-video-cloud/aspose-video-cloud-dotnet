// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AppendOptions.cs">
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
  /// container class for append save options
  /// </summary>  
  public class AppendOptions 
  {                       
        /// <summary>
        /// Gets or sets a value determining which  should be used for the resulting video. Default value is .
        /// </summary>
        /// <value>Gets or sets a value determining which  should be used for the resulting video. Default value is .</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodecEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum AVC for "AVC"
            /// </summary>            
            AVC,
            
            /// <summary>
            /// Enum H265 for "H_265"
            /// </summary>            
            H265,
            
            /// <summary>
            /// Enum H264 for "H_264"
            /// </summary>            
            H264,
            
            /// <summary>
            /// Enum MPEG4 for "MPEG4"
            /// </summary>            
            MPEG4,
            
            /// <summary>
            /// Enum WMV7 for "WMV7"
            /// </summary>            
            WMV7,
            
            /// <summary>
            /// Enum WMV8 for "WMV8"
            /// </summary>            
            WMV8,
            
            /// <summary>
            /// Enum VP8 for "VP8"
            /// </summary>            
            VP8,
            
            /// <summary>
            /// Enum VP9 for "VP9"
            /// </summary>            
            VP9,
            
            /// <summary>
            /// Enum XVID for "XVID"
            /// </summary>            
            XVID            
        }

        /// <summary>
        /// Gets or sets a value determining which  level should be used for the encoding process. Default value is .
        /// </summary>
        /// <value>Gets or sets a value determining which  level should be used for the encoding process. Default value is .</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PresetEnum
        { 
            /// <summary>
            /// Enum Ultrafast for "Ultrafast"
            /// </summary>            
            Ultrafast,
            
            /// <summary>
            /// Enum Superfast for "Superfast"
            /// </summary>            
            Superfast,
            
            /// <summary>
            /// Enum Veryfast for "Veryfast"
            /// </summary>            
            Veryfast,
            
            /// <summary>
            /// Enum Faster for "Faster"
            /// </summary>            
            Faster,
            
            /// <summary>
            /// Enum Fast for "Fast"
            /// </summary>            
            Fast,
            
            /// <summary>
            /// Enum Medium for "Medium"
            /// </summary>            
            Medium,
            
            /// <summary>
            /// Enum Slow for "Slow"
            /// </summary>            
            Slow,
            
            /// <summary>
            /// Enum Slower for "Slower"
            /// </summary>            
            Slower,
            
            /// <summary>
            /// Enum Veryslow for "Veryslow"
            /// </summary>            
            Veryslow,
            
            /// <summary>
            /// Enum Placebo for "Placebo"
            /// </summary>            
            Placebo            
        }

        /// <summary>
        /// Gets or sets a value determining which  should be used for the resulting video. Default value is .
        /// </summary>
        public CodecEnum? Codec { get; set; }

        /// <summary>
        /// Gets or sets a value determining which  level should be used for the encoding process. Default value is .
        /// </summary>
        public PresetEnum? Preset { get; set; }

        /// <summary>
        /// Gets or sets a value determining which video file should be used for the appending process.
        /// </summary>  
        public string VideoToAppendPath { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AppendOptions {\n");
          sb.Append("  Codec: ").Append(this.Codec).Append("\n");
          sb.Append("  Preset: ").Append(this.Preset).Append("\n");
          sb.Append("  VideoToAppendPath: ").Append(this.VideoToAppendPath).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
