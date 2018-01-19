// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BaseApiTest.cs">
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

namespace Aspose.Video.Cloud.Sdk.Tests
{
    using System.Diagnostics;
    using System.IO;

    using Aspose.Video.Cloud.Sdk;
    using Aspose.Video.Cloud.Sdk.Model.Requests;
    using Aspose.Video.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using NMock;
    using Model;

    /// <summary>
    /// This is a test class for TestVideoApi and is intended
    /// to contain all TestVideoApi Unit Tests
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class BaseApiTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "BaseApiTest");

        /// <summary>
        /// If file does not exist, 400 response should be returned with message "Error while loading file ".
        /// </summary>
        [TestMethod]
        public void TestHandleErrors()
        {
            string name = "noFileWithThisName.avi";

            try
            {
                var request = new GetVideoPropertiesRequest(name);
                this.VideoApi.GetVideoProperties(request);

                Assert.Fail("Excpected exception has not been throwed");
            }
            catch (ApiException apiException)
            {
                Assert.AreEqual(400, apiException.ErrorCode);
                Assert.IsTrue(apiException.Message.StartsWith("Error while loading file 'noFileWithThisName.avi' from storage:"), "Current message: " + apiException.Message);
            }
        }

        /// <summary>
        /// If user set the "Debug" option, request and response should be writed to trace
        /// </summary>
        [TestMethod]
        public void IfUserSetDebugOptionRequestAndErrorsShouldBeWritedToTrace()
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
            var api = this.GetDebugApi();

            var mockFactory = new MockFactory();
            var traceListenerMock = mockFactory.CreateMock<TraceListener>();
            Trace.Listeners.Add(traceListenerMock.MockObject);
           
            traceListenerMock.Expects.One.Method(p => p.WriteLine(string.Empty)).With(Is.StringContaining("POST: http://api-dev.aspose.cloud/v1.1/video/TestPostAppendVideo.avi"));
            traceListenerMock.Expects.One.Method(p => p.WriteLine(string.Empty)).With(Is.StringContaining("Response 200: OK"));
      
            traceListenerMock.Expects.AtLeastOne.Method(p => p.WriteLine(string.Empty)).With(Is.Anything);

            // Act
            api.PostAppendVideo(request);

            // Assert                    
            mockFactory.VerifyAllExpectationsHaveBeenMet();
        }
    }
}
