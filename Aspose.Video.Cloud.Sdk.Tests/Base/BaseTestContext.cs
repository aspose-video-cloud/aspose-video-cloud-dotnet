// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="BaseTestContext.cs">
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

namespace Aspose.Video.Cloud.Sdk.Tests.Base
{
    using System.IO;

    using Aspose.Video.Cloud.Sdk.Api;

    using Com.Aspose.Storage.Api;

    /// <summary>
    /// Base class for all tests
    /// </summary>
    public abstract class BaseTestContext
    {
        private const string BaseProductUri = @"http://api-dev.aspose.cloud/v1.1";
        private const string AppSID = "9657d464-d29d-448f-8fed-1f25fe7da35a";
        private const string AppKey = "81e80d586b0df4248292ee1a4b14a97c";
        private const string StorageAppSID = "ff470aee-3000-43dd-877d-e02e74499f18";
        private const string StorageAppKey = "532a70d65e0a752d55673b86f10e53fc";

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTestContext"/> class.
        /// </summary>
        protected BaseTestContext()
        {
            this.VideoApi = new VideoApi(AppKey, AppSID, BaseProductUri);
            this.StorageApi = new StorageApi(AppKey, AppSID, BaseProductUri);
            this.AnotherStorage = new StorageApi(StorageAppKey, StorageAppSID, BaseProductUri);
            this.AnotherVideoApi = new VideoApi(StorageAppKey, StorageAppSID, BaseProductUri);
        }

        /// <summary>
        /// Base path to test data
        /// </summary>
        protected static string BaseTestDataPath
        {
            get
            {
                return "Temp/SdkTests/TestData/";
            }
        }

        /// <summary>
        /// Base path to output data
        /// </summary>
        protected static string BaseTestOutPath
        {
            get
            {
                return "TestOut/";
            }
        }

        /// <summary>
        /// Storage API
        /// </summary>
        protected StorageApi StorageApi { get; set; }

        /// <summary>
        /// Video API
        /// </summary>
        protected VideoApi VideoApi { get; set; }

        /// <summary>
        /// Storage API
        /// </summary>
        protected StorageApi AnotherStorage { get; set; }

        /// <summary>
        /// Video API
        /// </summary>
        protected VideoApi AnotherVideoApi { get; set; }

        /// <summary>
        /// Returns test data path
        /// </summary>
        /// <param name="subfolder">subfolder for specific tests</param>
        /// <returns>test data path</returns>
        protected static string GetDataDir(string subfolder = null)
        {
            return Path.Combine("TestData/", string.IsNullOrEmpty(subfolder) ? string.Empty : subfolder);
        }

        /// <summary>
        /// Returns Video api with enabled debug option
        /// </summary>
        /// <returns>instance of Video api in debug mode</returns>
        protected VideoApi GetDebugApi()
        {
            return new VideoApi(AppKey, AppSID, BaseProductUri, true);
        }
    }
}