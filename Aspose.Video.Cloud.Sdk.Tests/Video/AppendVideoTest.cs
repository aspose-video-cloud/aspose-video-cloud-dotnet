// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="AppendVideoTest.cs">
// //   Copyright (c) 2018 Aspose.Video for Cloud
// // </copyright>
// // <summary>
// //   Permission is hereby granted, free of charge, to any person obtaining a copy
// //  of this software and associated documentation files (the "Software"), to deal
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

    /// <summary>
    /// Example of how to append document
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class AppendVideoTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "VideoActions/AppendVideo");

        /// <summary>
        /// Test for appending video
        /// </summary>
        [TestMethod]
        public void TestPostAppendVideo()
        {
            var localName = "sample.avi";
            var remoteName = "TestPostAppendVideo.avi";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var fullNameToAppend = Path.Combine(this.dataFolder, "videoForAppend.mp4");
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);

            AppendOptions options = new AppendOptions();

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));
            this.StorageApi.PutCreate(fullNameToAppend, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + "sample.mp4"));
            options.VideoToAppendPath = fullNameToAppend;

            var request = new PostAppendVideoRequest(remoteName, destFileName, options, this.dataFolder);
            var actual = this.VideoApi.PostAppendVideo(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
        }
    }
}