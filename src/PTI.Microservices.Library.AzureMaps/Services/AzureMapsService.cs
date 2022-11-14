using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PTI.Microservices.Library.Configuration;
using PTI.Microservices.Library.Interceptors;
using PTI.Microservices.Library.Models.AzureMapsService.GetCurrentConditions;
using PTI.Microservices.Library.Models.AzureMapsService.GetDailyForecast;
using PTI.Microservices.Library.Models.AzureMapsService.GetOptimizedRoute;
using PTI.Microservices.Library.Models.AzureMapsService.GetSearchAddressReverse;
using PTI.Microservices.Library.Models.AzureMapsService.GetSearchPOI;
using PTI.Microservices.Library.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PTI.Microservices.Library.Services
{
    /// <summary>
    /// Service in charge of exposing access to Azure Maps functionality
    /// </summary>
    public sealed class AzureMapsService
    {
        private ILogger<AzureMapsService> Logger { get; }
        private AzureMapsConfiguration AzureMapsConfiguration { get; }
        private CustomHttpClient CustomHttpClient { get; }

        /// <summary>
        /// Creates a new instance of <see cref="AzureMapsService"/>
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="azureMapsConfiguration"></param>
        /// <param name="httpClient"></param>
        public AzureMapsService(ILogger<AzureMapsService> logger, AzureMapsConfiguration azureMapsConfiguration,
            CustomHttpClient httpClient)
        {
            this.Logger = logger;
            this.AzureMapsConfiguration = azureMapsConfiguration;
            this.CustomHttpClient = httpClient;
        }

        /// <summary>
        /// Gets the Daily Forecast for the specified Geo-Coordinates
        /// </summary>
        /// <param name="geoCoordinates"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<GetDailyForecastResponse> GetDailyForecastAsync(GeoCoordinates geoCoordinates,
            CancellationToken cancellationToken = default)
        {
            try
            {
                string query = $"{geoCoordinates.Latitude},{geoCoordinates.Longitude}";
                string requestUrl = $"https://atlas.microsoft.com/weather/forecast/daily/json" +
                    $"?subscription-key={this.AzureMapsConfiguration.Key}" +
                    $"&api-version=1.0" +
                    $"&query={query}" +
                    $"&duration={10}";
                var result = await this.CustomHttpClient.GetFromJsonAsync<GetDailyForecastResponse>(requestUrl, cancellationToken);
                return result;
            }
            catch (Exception ex)
            {
                this.Logger?.LogError(ex, ex.Message);
                throw;
            }
        }

        #region Weather
        /// <summary>
        /// Geths the current conditions for the specified Geo-Coordinates
        /// </summary>
        /// <param name="geoCoordinates"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<GetCurrentConditionsResponse> GetCurrentConditionsAsync(GeoCoordinates geoCoordinates,
            CancellationToken cancellationToken = default)
        {
            try
            {
                string query = $"{geoCoordinates.Latitude},{geoCoordinates.Longitude}";
                string requestUrl = $"https://atlas.microsoft.com/weather/currentConditions/json" +
                    $"?subscription-key={this.AzureMapsConfiguration.Key}" +
                    $"&api-version=1.0" +
                    $"&query={query}" +
                    $"&details={true}" +
                    $"&duration={0}";
                var response = await this.CustomHttpClient.GetFromJsonAsync<GetCurrentConditionsResponse>(requestUrl, cancellationToken);
                return response;
            }
            catch (Exception ex)
            {
                this.Logger?.LogError(ex, ex.Message);
                throw;
            }
        }
        #endregion

        #region "Routes"
        /// <summary>
        /// Gets the optimized route from the starting point to the final point including stops
        /// </summary>
        /// <param name="startingPoint"></param>
        /// <param name="finalPoint"></param>
        /// <param name="pointsInRoute"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<GetOptimizedRouteResponse> GetOptimizedRouteAsync(GeoCoordinates startingPoint, GeoCoordinates finalPoint,
            IList<GeoCoordinates> pointsInRoute, CancellationToken cancellationToken = default)
        {
            string routeType = "fastest";
            //string alternativeType = "betterRoute";
            string formattedWaypoints = null;
            if (pointsInRoute?.Count > 0)
                formattedWaypoints = 
                    $":{String.Join(":", pointsInRoute?.Select(p => $"{p.Latitude},{p.Longitude}").ToArray()) ?? null}:";
            string query = $"{startingPoint.Latitude},{startingPoint.Longitude}{formattedWaypoints??":"}{finalPoint.Latitude},{finalPoint.Longitude}";
            string requestUrl = $"https://atlas.microsoft.com/route/directions/json" +
                $"?subscription-key={this.AzureMapsConfiguration.Key}" +
                $"&api-version=1.0" +
                $"&query={query}" +
                //$"&maxAlternatives={maxAlternatives}" +
                //$"&alternativeType={alternativeType}" +
                //$"&minDeviationDistance={minDeviationDistance}" +
                //$"&arriveAt={arriveAt}" +
                //$"&departAt={departAt}" +
                //$"&minDeviationTime={minDeviationTime}" +
                //$"&instructionsType={instructionsType}" +
                //$"&language={language}" +
                //$"&computeBestOrder={computeBestOrder}" +
                //$"&routeRepresentation={routeRepresentation}" +
                //$"&computeTravelTimeFor={computeTravelTimeFor}" +
                //$"&vehicleHeading={vehicleHeading}" +
                //$"&report={report}" +
                //$"&sectionType={sectionType}" +
                //$"&vehicleAxleWeight={vehicleAxleWeight}" +
                //$"&vehicleWidth={vehicleWidth}" +
                //$"&vehicleHeight={vehicleHeight}" +
                //$"&vehicleLength={vehicleLength}" +
                //$"&vehicleMaxSpeed={vehicleMaxSpeed}" +
                //$"&vehicleWeight={vehicleWeight}" +
                //$"&vehicleCommercial={vehicleCommercial}" +
                //$"&windingness={windingness}" +
                //$"&hilliness={hilliness}" +
                //$"&travelMode={travelMode}" +
                //$"&avoid={avoid}" +
                //$"&traffic={traffic}" +
                $"&routeType={routeType}";
            //$"&vehicleLoadType={vehicleLoadType}" +
            //$"&vehicleEngineType={vehicleEngineType}" +
            //$"&constantSpeedConsumptionInLitersPerHundredkm={constantSpeedConsumptionInLitersPerHundredkm}" +
            //$"&currentFuelInLiters={currentFuelInLiters}" +
            //$"&auxiliaryPowerInLitersPerHour={auxiliaryPowerInLitersPerHour}" +
            //$"&fuelEnergyDensityInMJoulesPerLiter={fuelEnergyDensityInMJoulesPerLiter}" +
            //$"&accelerationEfficiency={accelerationEfficiency}" +
            //$"&decelerationEfficiency={decelerationEfficiency}" +
            //$"&uphillEfficiency={uphillEfficiency}" +
            //$"&downhillEfficiency={downhillEfficiency}" +
            //$"&constantSpeedConsumptionInkWhPerHundredkm={constantSpeedConsumptionInkWhPerHundredkm}" +
            //$"&currentChargeInkWh={currentChargeInkWh}" +
            //$"&maxChargeInkWh={maxChargeInkWh}" +
            //$"&auxiliaryPowerInkW={auxiliaryPowerInkW}";
            try
            {
                var response = await this.CustomHttpClient.GetFromJsonAsync<GetOptimizedRouteResponse>(requestUrl);
                return response;

            }
            catch (Exception ex)
            {
                this.Logger?.LogError(ex, ex.Message);
                throw;
            }
        }
        #endregion "Routes"

        #region "Search"
        /// <summary>
        /// Gets the address corresponding to the specified Geo-Coordinates
        /// </summary>
        /// <param name="geoCoordinates"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<GetSearchAddressReverseResponse> GetSearchAddressReverse(GeoCoordinates geoCoordinates, CancellationToken cancellationToken=default)
        {
            try
            {
                string query = $"{geoCoordinates.Latitude},{geoCoordinates.Longitude}";
                string requestUrl = $"https://atlas.microsoft.com/search/address/reverse/json" +
                    $"?subscription-key={this.AzureMapsConfiguration.Key}" +
                    $"&api-version=1.0" +
                    $"&query={query}";
                var result = await this.CustomHttpClient.GetFromJsonAsync<GetSearchAddressReverseResponse>(requestUrl);
                return result;
            }
            catch (Exception ex)
            {
                this.Logger?.LogError(ex.Message, ex);
                throw;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <param name="countryCode"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<GetSearchPOIResponse> GetSearchPOIAsync(string searchTerm, 
            string countryCode,
            CancellationToken cancellationToken=default)
        {
            try
            {
                string query = searchTerm;
                string requestUrl = $"https://atlas.microsoft.com/search/poi/json" +
                    $"?subscription-key={this.AzureMapsConfiguration.Key}&api-version=1.0&query={query}" +
                    //$"&typeahead={typeahead}" +
                    //$"&limit={limit}" +
                    //$"&ofs={ofs}" +
                    //$"&categorySet={categorySet}" +
                    $"&countrySet={countryCode}";
                    //$"&lat={lat}" +
                    //$"&lon={lon}" +
                    //$"&radius={radius}" +
                    //$"&topLeft={topLeft}" +
                    //$"&btmRight={btmRight}" +
                    //$"&language={language}" +
                    //$"&extendedPostalCodesFor={extendedPostalCodesFor}" +
                    //$"&brandSet={brandSet}" +
                    //$"&connectorSet={connectorSet}" +
                    //$"&view={view}" +
                    //$"&openingHours=nextSevenDays";
                var result = await this.CustomHttpClient.GetFromJsonAsync<GetSearchPOIResponse>(requestUrl, cancellationToken);
                return result;
            }
            catch(Exception ex)
            {
                this.Logger?.LogError(ex.Message, ex);
                throw;
            }
        }

        #endregion "Search"

    }
}
