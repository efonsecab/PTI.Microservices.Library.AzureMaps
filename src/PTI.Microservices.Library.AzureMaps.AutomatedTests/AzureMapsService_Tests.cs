using PTI.Microservices.Library.Interceptors;
using PTI.Microservices.Library.Services;

namespace PTI.Microservices.Library.AzureMaps.AutomatedTests
{
    [TestClass]
    public class AzureMapsService_Tests: TestsBase
    {
        [TestMethod]
        public async Task Test_GetDailyForecastAsync()
        {
            AzureMapsService azureMapsService = CreateAzureMapsService();
            var result = await
            azureMapsService.GetDailyForecastAsync(geoCoordinates:
                new Models.Shared.GeoCoordinates()
                {
                    Latitude = 43.0828201,
                    Longitude = -79.0763516
                });
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.forecasts);
            Assert.IsNotNull(result.summary);
        }

        [TestMethod]
        public async Task Test_GetSearchAddressReverse()
        {
            AzureMapsService azureMapsService = CreateAzureMapsService();
            var result = await azureMapsService.GetSearchAddressReverse(
                geoCoordinates:
                new Models.Shared.GeoCoordinates()
                {
                    Latitude = 43.0828201,
                    Longitude = -79.0763516
                });
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.addresses);
            Assert.IsNotNull(result.summary);
            Assert.AreEqual<string>(result.addresses[0].address.streetNameAndNumber,
                "6430 Niagara River Parkway");
        }

        [TestMethod]
        public async Task Test_GetSearchPOIAsync()
        {
            AzureMapsService azureMapsService = CreateAzureMapsService();
            var result = await azureMapsService
                .GetSearchPOIAsync("McDonalds, Miami, Florida", "us", CancellationToken.None);
            Assert.IsNotNull(result);
        }

        private AzureMapsService CreateAzureMapsService()
        {
            CustomHttpClientHandler customHttpClientHandler = new CustomHttpClientHandler(null);
            CustomHttpClient customHttpClient = new CustomHttpClient(customHttpClientHandler);
            AzureMapsService azureMapsService = new AzureMapsService(logger: null,
                azureMapsConfiguration: base._azureMapsConfiguration,
                httpClient: customHttpClient);
            return azureMapsService;
        }
    }
}