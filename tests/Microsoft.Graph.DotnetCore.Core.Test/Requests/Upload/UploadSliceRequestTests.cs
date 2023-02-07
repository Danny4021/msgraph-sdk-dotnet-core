// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.DotnetCore.Core.Test.Requests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Graph.DotnetCore.Core.Test.Mocks;
    using Microsoft.Graph.DotnetCore.Core.Test.TestModels.ServiceModels;
    using Xunit;

    public class UploadSliceRequests : RequestTestBase
    {
        [Fact]
        public async Task PutAsyncReturnsExpectedUploadSessionAsync()
        {
            
                /* Arrange */
                // 1. create a mock response
                string requestUrl = "https://localhost/";


            // 3. Create a batch request object to be tested
                var handlers = GraphClientFactory.CreateDefaultHandlers(null);
                handlers.Add(new UploadHttpMessageHandler());
                var httpClient = GraphClientFactory.Create(handlers);
                httpClient.Timeout = TimeSpan.FromSeconds(5);
                var baseClient = new BaseClient(requestUrl, httpClient);

            bool firstAttempt = true;
                try
                {
                    UploadSliceRequest<TestDriveItem> uploadSliceRequest = new UploadSliceRequest<TestDriveItem>(requestUrl, baseClient, 0, 200, 1000);
                    Stream stream = new MemoryStream(new byte[300]);

                    /* Act */
                    var uploadResult = await uploadSliceRequest.PutAsync(stream);
                }
                catch (ServiceException exception)
                {
                    if (exception.IsMatch("generalException") || exception.IsMatch("timeout"))
                    {
                        if (firstAttempt)
                        {
                            firstAttempt = false;
                            //exceptionTrackingList.Add(exception);
                        }
                        else
                        {
                            throw;
                        }
                    }
                    else if (exception.IsMatch("invalidRange"))
                    {
                        // Succeeded previously, but nothing to return right now
                         new UploadResult<string>();
                    }
                    else
                    {
                        throw;
                    }
                }
            

                //var uploadSession = uploadResult.UploadSession;

                /* Assert */
                //Assert.False(uploadResult.UploadSucceeded);

        }
    }
    public class UploadHttpMessageHandler : DelegatingHandler
    {
        public UploadHttpMessageHandler()
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var httpRequestMessage = new HttpRequestMessage() { RequestUri = new Uri("https://api.rapidmock.com/mocks/89mEw") };
            httpRequestMessage.Headers.TryAddWithoutValidation("x-rapidmock-delay", "9000");

            var testResponse =await base.SendAsync(httpRequestMessage, cancellationToken);
            //await Task.Delay(32000);
            HttpResponseMessage responseMessage = new HttpResponseMessage();

            string responseJSON = @"{
                  ""expirationDateTime"": ""2015 - 01 - 29T09: 21:55.523Z"",
                  ""nextExpectedRanges"": [
                  ""12345-55232"",
                  ""77829-99375""
                  ]
                }";
            HttpContent content = new StringContent(responseJSON, Encoding.UTF8, CoreConstants.MimeTypeNames.Application.Json);
            responseMessage.Content = content;

            return responseMessage;
        }

    }
}