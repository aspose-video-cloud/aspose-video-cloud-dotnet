// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WatermarkImageOptions.cs">
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
  /// container class for watermark image save options
  /// </summary>  
  public class WatermarkImageOptions 
  {                       
        /// <summary>
        /// Path to the image 
        /// </summary>  
        public string WatermarkPath { get; set; }

        /// <summary>
        /// Time position from which the watermark will be addded in milliseconds
        /// </summary>  
        public long? StartPos { get; set; }

        /// <summary>
        /// Time position up to which the watermark will be addded in milliseconds
        /// </summary>  
        public long? Length { get; set; }

        /// <summary>
        /// X position coordinates
        /// </summary>  
        public double? X { get; set; }

        /// <summary>
        /// Y position coordinates
        /// </summary>  
        public double? Y { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WatermarkImageOptions {\n");
          sb.Append("  WatermarkPath: ").Append(this.WatermarkPath).Append("\n");
          sb.Append("  StartPos: ").Append(this.StartPos).Append("\n");
          sb.Append("  Length: ").Append(this.Length).Append("\n");
          sb.Append("  X: ").Append(this.X).Append("\n");
          sb.Append("  Y: ").Append(this.Y).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
