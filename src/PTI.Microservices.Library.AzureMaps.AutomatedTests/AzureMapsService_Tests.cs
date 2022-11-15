using PTI.Microservices.Library.Interceptors;
using PTI.Microservices.Library.Services;

namespace PTI.Microservices.Library.AzureMaps.AutomatedTests
{
    [TestClass]
    public class AzureMapsService_Tests: TestsBase
    {
        [TestMethod]
        public async Task Test_GetSearchPOIAsync()
        {
            CustomHttpClientHandler customHttpClientHandler = new CustomHttpClientHandler(null);
            CustomHttpClient customHttpClient = new CustomHttpClient(customHttpClientHandler);
            AzureMapsService azureMapsService = new AzureMapsService(logger: null,
                azureMapsConfiguration: base._azureMapsConfiguration,
                httpClient: customHttpClient);
            var result = await azureMapsService
                .GetSearchPOIAsync("McDonalds, Miami, Florida", "us", CancellationToken.None);
            Assert.IsNotNull(result);
        }
    }
}