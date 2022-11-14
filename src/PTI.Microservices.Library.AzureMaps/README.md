# PTI.Microservices.Library.AzureMaps

This is part of PTI.Microservices.Library set of packages

The purpose of this package is to facilitate consuming Azure Maps APIs

**Examples:**

## Get Search POI
    CustomHttpClientHandler customHttpClientHandler = new CustomHttpClientHandler(new TestCustomHttpClientHandlerLogger());
    CustomHttpClient customHttpClient = new CustomHttpClient(customHttpClientHandler);
    PTI.Microservices.Library.Services.AzureMapsService azureMapsService =
        new Microservices.Library.Services.AzureMapsService(logger: null,
        azureMapsConfiguration: new Microservices.Library.Configuration.AzureMapsConfiguration()
        {
            Key = base.AzureMapsConfiguration.Key,
        },
        customHttpClient);
    string poi = "McDonalds, Miami, United States";
    var result = await azureMapsService.GetSearchPOIAsync(poi, "us");

## Get Search Address Reverse
    CustomHttpClientHandler customHttpClientHandler = new CustomHttpClientHandler(null);
    CustomHttpClient customHttpClient = new CustomHttpClient(customHttpClientHandler);
    PTI.Microservices.Library.Services.AzureMapsService azureMapsService =
        new Microservices.Library.Services.AzureMapsService(logger: null,
        azureMapsConfiguration: new Microservices.Library.Configuration.AzureMapsConfiguration()
        {
            Key = base.AzureMapsConfiguration.Key,
        },
        customHttpClient);
    var result = await azureMapsService.GetSearchAddressReverse(
        new Microservices.Library.Models.Shared.GeoCoordinates()
        {
            Latitude = [LATITUDE],
            Longitude = [LONGITUDE]
        });

## Get Current Conditions
    CustomHttpClientHandler customHttpClientHandler = new CustomHttpClientHandler(null);
    CustomHttpClient customHttpClient = new CustomHttpClient(customHttpClientHandler);
    PTI.Microservices.Library.Services.AzureMapsService azureMapsService =
        new Microservices.Library.Services.AzureMapsService(logger: null,
        azureMapsConfiguration: new Microservices.Library.Configuration.AzureMapsConfiguration()
        {
            Key = base.AzureMapsConfiguration.Key,
        },
        customHttpClient);
    var result = await azureMapsService.GetCurrentConditionsAsync(new Microservices.Library.Models.Shared.GeoCoordinates()
    {
        Latitude = [LATITUDE],
        Longitude = [LONGITUDE]
    });