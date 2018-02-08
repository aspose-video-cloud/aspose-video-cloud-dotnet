// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="ExtractThumbnailTest.cs">
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

    /// <summary>
    /// Example of how to convert Video to one of the available formats
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class ExtractExtractThumbnailTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "VideoActions/ExtractThumbnail");

        /// <summary>
        /// Test for converting Video to one of the available formats        
        /// </summary>
        [TestMethod]
        public void TestPostExtractThumbnail()
        {
            var localName = "sample.mp4";
            var destPath = Path.Combine(this.dataFolder, "thumbnail.png");
            var fullName = Path.Combine(this.dataFolder, localName);
         
            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));

            var request = new PostExtractThumbnailRequest(localName, destPath, 1000, this.dataFolder);
            var actual = this.VideoApi.PostExtractThumbnail(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
        }
    }
}