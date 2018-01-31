// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertOptions.cs">
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
  /// container class for convert save options
  /// </summary>  
  public class ConvertOptions 
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
        /// Set the video standard:  PAL, NTSC, FILM
        /// </summary>
        /// <value>Set the video standard:  PAL, NTSC, FILM</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StandardEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum PAL for "PAL"
            /// </summary>            
            PAL,
            
            /// <summary>
            /// Enum NTSC for "NTSC"
            /// </summary>            
            NTSC,
            
            /// <summary>
            /// Enum FILM for "FILM"
            /// </summary>            
            FILM            
        }

        /// <summary>
        /// Set result video aspect ratio
        /// </summary>
        /// <value>Set result video aspect ratio</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AspectRatioEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum R32 for "R3_2"
            /// </summary>            
            R32,
            
            /// <summary>
            /// Enum R43 for "R4_3"
            /// </summary>            
            R43,
            
            /// <summary>
            /// Enum R53 for "R5_3"
            /// </summary>            
            R53,
            
            /// <summary>
            /// Enum R54 for "R5_4"
            /// </summary>            
            R54,
            
            /// <summary>
            /// Enum R85 for "R8_5"
            /// </summary>            
            R85,
            
            /// <summary>
            /// Enum R169 for "R16_9"
            /// </summary>            
            R169,
            
            /// <summary>
            /// Enum R179 for "R17_9"
            /// </summary>            
            R179            
        }

        /// <summary>
        /// Set result video PTS
        /// </summary>
        /// <value>Set result video PTS</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PTSEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum SlowDown for "slowDown"
            /// </summary>            
            SlowDown,
            
            /// <summary>
            /// Enum SpeedUp for "speedUp"
            /// </summary>            
            SpeedUp            
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
        /// Set the video standard:  PAL, NTSC, FILM
        /// </summary>
        public StandardEnum? Standard { get; set; }

        /// <summary>
        /// Set result video aspect ratio
        /// </summary>
        public AspectRatioEnum? AspectRatio { get; set; }

        /// <summary>
        /// Set result video PTS
        /// </summary>
        public PTSEnum? PTS { get; set; }

        /// <summary>
        /// Set result video resolution
        /// </summary>  
        public string FrameSize { get; set; }

        /// <summary>
        /// Set result video bitrate
        /// </summary>  
        public int? Bitrate { get; set; }

        /// <summary>
        /// Set result video FPS
        /// </summary>  
        public int? FPS { get; set; }

        /// <summary>
        /// Set watermark image
        /// </summary>  
        public WatermarkImageOptions Watermark { get; set; }

        /// <summary>
        /// Set watermark text
        /// </summary>  
        public WatermarkTextOptions WatermarkText { get; set; }

        /// <summary>
        /// Represents the volume level in percentage. Default level is 100
        /// </summary>  
        public int? Volume { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ConvertOptions {\n");
          sb.Append("  Codec: ").Append(this.Codec).Append("\n");
          sb.Append("  Preset: ").Append(this.Preset).Append("\n");
          sb.Append("  Standard: ").Append(this.Standard).Append("\n");
          sb.Append("  FrameSize: ").Append(this.FrameSize).Append("\n");
          sb.Append("  AspectRatio: ").Append(this.AspectRatio).Append("\n");
          sb.Append("  Bitrate: ").Append(this.Bitrate).Append("\n");
          sb.Append("  FPS: ").Append(this.FPS).Append("\n");
          sb.Append("  Watermark: ").Append(this.Watermark).Append("\n");
          sb.Append("  WatermarkText: ").Append(this.WatermarkText).Append("\n");
          sb.Append("  PTS: ").Append(this.PTS).Append("\n");
          sb.Append("  Volume: ").Append(this.Volume).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
