using System;
using System.Collections.Generic;
using System.Text;

namespace PTI.Microservices.Library.Models.AzureMapsService.GetDailyForecast
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class GetDailyForecastResponse
    {
        public Summary summary { get; set; }
        public Forecast[] forecasts { get; set; }
    }

    public class Summary
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int severity { get; set; }
        public string phrase { get; set; }
        public string category { get; set; }
    }

    public class Forecast
    {
        public DateTime date { get; set; }
        public Temperature temperature { get; set; }
        public Realfeeltemperature realFeelTemperature { get; set; }
        public Realfeeltemperatureshade realFeelTemperatureShade { get; set; }
        public float hoursOfSun { get; set; }
        public Degreedaysummary degreeDaySummary { get; set; }
        public Airandpollen[] airAndPollen { get; set; }
        public Day day { get; set; }
        public Night night { get; set; }
        public string[] sources { get; set; }
    }

    public class Temperature
    {
        public Minimum minimum { get; set; }
        public Maximum maximum { get; set; }
    }

    public class Minimum
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Maximum
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Realfeeltemperature
    {
        public Minimum1 minimum { get; set; }
        public Maximum1 maximum { get; set; }
    }

    public class Minimum1
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Maximum1
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Realfeeltemperatureshade
    {
        public Minimum2 minimum { get; set; }
        public Maximum2 maximum { get; set; }
    }

    public class Minimum2
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Maximum2
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Degreedaysummary
    {
        public Heating heating { get; set; }
        public Cooling cooling { get; set; }
    }

    public class Heating
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Cooling
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Day
    {
        public int iconCode { get; set; }
        public string iconPhrase { get; set; }
        public bool hasPrecipitation { get; set; }
        public string precipitationType { get; set; }
        public string precipitationIntensity { get; set; }
        public string shortPhrase { get; set; }
        public string longPhrase { get; set; }
        public int precipitationProbability { get; set; }
        public int thunderstormProbability { get; set; }
        public int rainProbability { get; set; }
        public int snowProbability { get; set; }
        public int iceProbability { get; set; }
        public Wind wind { get; set; }
        public Windgust windGust { get; set; }
        public Totalliquid totalLiquid { get; set; }
        public Rain rain { get; set; }
        public Snow snow { get; set; }
        public Ice ice { get; set; }
        public float hoursOfPrecipitation { get; set; }
        public float hoursOfRain { get; set; }
        public float hoursOfSnow { get; set; }
        public float hoursOfIce { get; set; }
        public float cloudCover { get; set; }
    }

    public class Wind
    {
        public Direction direction { get; set; }
        public Speed speed { get; set; }
    }

    public class Direction
    {
        public float degrees { get; set; }
        public string localizedDescription { get; set; }
    }

    public class Speed
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Windgust
    {
        public Direction1 direction { get; set; }
        public Speed1 speed { get; set; }
    }

    public class Direction1
    {
        public float degrees { get; set; }
        public string localizedDescription { get; set; }
    }

    public class Speed1
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Totalliquid
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Rain
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Snow
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Ice
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Night
    {
        public int iconCode { get; set; }
        public string iconPhrase { get; set; }
        public bool hasPrecipitation { get; set; }
        public string precipitationType { get; set; }
        public string precipitationIntensity { get; set; }
        public string shortPhrase { get; set; }
        public string longPhrase { get; set; }
        public int precipitationProbability { get; set; }
        public int thunderstormProbability { get; set; }
        public int rainProbability { get; set; }
        public int snowProbability { get; set; }
        public int iceProbability { get; set; }
        public Wind1 wind { get; set; }
        public Windgust1 windGust { get; set; }
        public Totalliquid1 totalLiquid { get; set; }
        public Rain1 rain { get; set; }
        public Snow1 snow { get; set; }
        public Ice1 ice { get; set; }
        public float hoursOfPrecipitation { get; set; }
        public float hoursOfRain { get; set; }
        public float hoursOfSnow { get; set; }
        public float hoursOfIce { get; set; }
        public float cloudCover { get; set; }
    }

    public class Wind1
    {
        public Direction2 direction { get; set; }
        public Speed2 speed { get; set; }
    }

    public class Direction2
    {
        public float degrees { get; set; }
        public string localizedDescription { get; set; }
    }

    public class Speed2
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Windgust1
    {
        public Direction3 direction { get; set; }
        public Speed3 speed { get; set; }
    }

    public class Direction3
    {
        public float degrees { get; set; }
        public string localizedDescription { get; set; }
    }

    public class Speed3
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Totalliquid1
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Rain1
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Snow1
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Ice1
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Airandpollen
    {
        public string name { get; set; }
        public float value { get; set; }
        public string category { get; set; }
        public int categoryValue { get; set; }
        public string type { get; set; }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
