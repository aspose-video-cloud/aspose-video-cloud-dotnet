// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="ConvertVideoTest.cs">
// //   Copyright (c) 2018 Aspose.Video for Cloud
// // </copyright>
// // <summary>
// //   Permission is hereby granted, free of charge, to any person obtaining a copy
// //  of this software and associated Videoation files (the "Software"), to deal
// //  in the Software without restriction, including without limitation the rights
// //  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// //  copies of the Software, and to permit persons to whom the Software is
// //  furnished to do so, subject to the following conditions:
// // 
// //  The above copyright notice and this permission notice shall be included in all
// //  copies or substantial portions of the Software.
// // 
// //  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// //  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// //  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// //  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// //  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// //  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// //  SOFTWARE.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Video.Cloud.Sdk.Tests.Video
{
    using System.IO;

    using Aspose.Video.Cloud.Sdk.Model;
    using Aspose.Video.Cloud.Sdk.Model.Requests;
    using Aspose.Video.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    /// <summary>
    /// Example of how to convert Video to one of the available formats
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class ConvertVideoTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "VideoActions/ConvertVideo");

        /// <summary>
        /// Test for converting Video to one of the available formats        
        /// </summary>
        [TestMethod]
        public void TestPostConvertVideo()
        {
            var localName = "sample.avi";
            var remoteName = "toconvert.avi";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var resultPath = Path.Combine(this.dataFolder, "converted.mp4");
            ConvertOptions options = new ConvertOptions();
         
            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));

            var request = new PostConvertVideoRequest(remoteName, "mp4", resultPath, options, this.dataFolder);
            var actual = this.VideoApi.PostConvertVideo(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
        }

        /// <summary>
        /// Test for encoding in different video codec      
        /// </summary>
        [TestMethod]
        public void TestEncodeVideo()
        {
            var localName = "sample.avi";
          
            var fullName = Path.Combine(this.dataFolder, localName);
            var resultPath = Path.Combine(this.dataFolder, "Encoded.avi");
            ConvertOptions options = new ConvertOptions();
            options.Codec = ConvertOptions.CodecEnum.VP9;

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));

            var request = new PostConvertVideoRequest(localName, "avi", resultPath, options, this.dataFolder);
            var actual = this.VideoApi.PostConvertVideo(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
        }

        /// <summary>
        /// Test for volume level adjusting. This test will make the video quieter to 10% of the original    
        /// </summary>
        [TestMethod]
        public void TestVolumeVideo()
        {
            var localName = "sample.avi";

            var fullName = Path.Combine(this.dataFolder, localName);
            var resultPath = Path.Combine(this.dataFolder, "Volume.avi");
            ConvertOptions options = new ConvertOptions();
            options.Volume = 10;

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));

            var request = new PostConvertVideoRequest(localName, "avi", resultPath, options, this.dataFolder);
            var actual = this.VideoApi.PostConvertVideo(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
        }

        /// <summary>
        /// Test for bitrate adjusting 
        /// </summary>
        [TestMethod]
        public void TestBitrateVideo()
        {
            var localName = "sample.avi";

            var fullName = Path.Combine(this.dataFolder, localName);
            var resultPath = Path.Combine(this.dataFolder, "bitrate.avi");
            ConvertOptions options = new ConvertOptions();
            options.Bitrate = 128;

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));

            var request = new PostConvertVideoRequest(localName, "avi", resultPath, options, this.dataFolder);
            var actual = this.VideoApi.PostConvertVideo(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
        }

        /// <summary>
        /// Test for FPS adjusting 
        /// </summary>
        [TestMethod]
        public void TestFpsVideo()
        {
            var localName = "sample.avi";

            var fullName = Path.Combine(this.dataFolder, localName);
            var resultPath = Path.Combine(this.dataFolder, "fps.avi");
            ConvertOptions options = new ConvertOptions();
            options.FPS = 48;

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));

            var request = new PostConvertVideoRequest(localName, "avi", resultPath, options, this.dataFolder);
            var actual = this.VideoApi.PostConvertVideo(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
        }

        /// <summary>
        /// Test for PTS adjusting 
        /// </summary>
        [TestMethod]
        public void TestPtsVideo()
        {
            var localName = "sample.avi";

            var fullName = Path.Combine(this.dataFolder, localName);
            var resultPath = Path.Combine(this.dataFolder, "pts.avi");
            ConvertOptions options = new ConvertOptions();
            options.PTS = ConvertOptions.PTSEnum.SpeedUp;

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));

            var request = new PostConvertVideoRequest(localName, "avi", resultPath, options, this.dataFolder);
            var actual = this.VideoApi.PostConvertVideo(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
        }

        /// <summary>
        /// Test for resolution adjusting 
        /// </summary>
        [TestMethod]
        public void TestResolutionVideo()
        {
            var localName = "sample.avi";

            var fullName = Path.Combine(this.dataFolder, localName);
            var resultPath = Path.Combine(this.dataFolder, "resolution.avi");
            ConvertOptions options = new ConvertOptions();
            options.FrameSize = "840x480";

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));

            var request = new PostConvertVideoRequest(localName, "avi", resultPath, options, this.dataFolder);
            var actual = this.VideoApi.PostConvertVideo(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
        }

        /// <summary>
        /// Test for aspect ratio adjusting 
        /// </summary>
        [TestMethod]
        public void TestAspectRatioVideo()
        {
            var localName = "sample.avi";

            var fullName = Path.Combine(this.dataFolder, localName);
            var resultPath = Path.Combine(this.dataFolder, "aspectratio.avi");
            ConvertOptions options = new ConvertOptions();
            options.AspectRatio = ConvertOptions.AspectRatioEnum.R3_2;

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));

            var request = new PostConvertVideoRequest(localName, "avi", resultPath, options, this.dataFolder);
            var actual = this.VideoApi.PostConvertVideo(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
        }

        /// <summary>
        /// Test for adding image watermark   
        /// </summary>
        [TestMethod]
        public void TestPostAddWatermarkImage()
        {
            var localName = "sample.avi";
            var watermark = "watermark.png";
            var watermarkPath = Path.Combine(this.dataFolder, watermark);
            var remoteName = "watermarkImage.avi";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var resultPath = Path.Combine(this.dataFolder, "converted.mp4");
            ConvertOptions options = new ConvertOptions();
            options.Watermark = new WatermarkImageOptions();
            options.Watermark.WatermarkPath = watermarkPath;

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));
            this.StorageApi.PutCreate(watermarkPath, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + watermark));

            var request = new PostConvertVideoRequest(remoteName, "mp4", resultPath, options, this.dataFolder);
            var actual = this.VideoApi.PostConvertVideo(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
        }

        /// <summary>
        /// Test for adding text watermark
        /// </summary>
        [TestMethod]
        public void TestPostAddWatermarkText()
        {
            var localName = "sample.avi";
            var fullName = Path.Combine(this.dataFolder, localName);
            var resultPath = Path.Combine(this.dataFolder, "convertedWatermarkText.mp4");
            ConvertOptions options = new ConvertOptions();
            options.WatermarkText = new WatermarkTextOptions();
            options.WatermarkText.Text = "Test watermark text";
            options.WatermarkText.FontFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));

            var request = new PostConvertVideoRequest(localName, "mp4", resultPath, options, this.dataFolder);
            var actual = this.VideoApi.PostConvertVideo(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
        }
    }
}