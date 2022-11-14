using System;
using System.Collections.Generic;
using System.Text;

namespace PTI.Microservices.Library.Models.AzureMapsService.GetCurrentConditions
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Represents the response for the GetCurrentConditions endpoint in Azure Maps
    /// </summary>
    public class GetCurrentConditionsResponse
    {
        /// <summary>
        /// Object with results
        /// </summary>
        public Result[] results { get; set; }
    }

    /// <summary>
    /// Has all the data related to the weather
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Datetime for the weather
        /// </summary>
        public DateTime dateTime { get; set; }
        /// <summary>
        /// Phrase
        /// </summary>
        public string phrase { get; set; }
        /// <summary>
        /// Icon Code
        /// </summary>
        public int iconCode { get; set; }
        /// <summary>
        /// Indicates if there is precipitation
        /// </summary>
        public bool hasPrecipitation { get; set; }
        /// <summary>
        /// Indicates if is is datetime
        /// </summary>
        public bool isDayTime { get; set; }
        /// <summary>
        /// Temperature information
        /// </summary>
        public Temperature temperature { get; set; }
        /// <summary>
        /// Real Feel Temperature information
        /// </summary>
        public Realfeeltemperature realFeelTemperature { get; set; }
        /// <summary>
        /// Real Feel Temperature Shade
        /// </summary>
        public Realfeeltemperatureshade realFeelTemperatureShade { get; set; }
        /// <summary>
        /// Indicates Relative Humidity level
        /// </summary>
        public int relativeHumidity { get; set; }
        /// <summary>
        /// Dew Point Information
        /// </summary>
        public Dewpoint dewPoint { get; set; }
        /// <summary>
        /// Wind Information
        /// </summary>
        public Wind wind { get; set; }
        /// <summary>
        /// Wind Gust Information
        /// </summary>
        public Windgust windGust { get; set; }
        /// <summary>
        /// UV Index Information
        /// </summary>
        public int uvIndex { get; set; }
        /// <summary>
        /// Uv Index Phrase
        /// </summary>
        public string uvIndexPhrase { get; set; }
        /// <summary>
        /// Visibility Information
        /// </summary>
        public Visibility visibility { get; set; }
        /// <summary>
        /// Obstructions to Visibility Information
        /// </summary>
        public string obstructionsToVisibility { get; set; }
        /// <summary>
        /// Cloud Cover Level
        /// </summary>
        public int cloudCover { get; set; }
        /// <summary>
        /// Ceiling Information
        /// </summary>
        public Ceiling ceiling { get; set; }
        /// <summary>
        /// Pressure Information
        /// </summary>
        public Pressure pressure { get; set; }
        /// <summary>
        /// Pressure Tendency Information
        /// </summary>
        public Pressuretendency pressureTendency { get; set; }
        /// <summary>
        /// Past 24 Hours Temperature Departure Information
        /// </summary>
        public Past24hourtemperaturedeparture past24HourTemperatureDeparture { get; set; }
        /// <summary>
        /// Apparent Temperature Information
        /// </summary>
        public Apparenttemperature apparentTemperature { get; set; }
        /// <summary>
        /// Windchill Temperature Information
        /// </summary>
        public Windchilltemperature windChillTemperature { get; set; }
        /// <summary>
        /// Wet Bulb Temperature Information
        /// </summary>
        public Wetbulbtemperature wetBulbTemperature { get; set; }
        /// <summary>
        /// Precipitation Summary
        /// </summary>
        public Precipitationsummary precipitationSummary { get; set; }
        /// <summary>
        /// Temperature Summary
        /// </summary>
        public Temperaturesummary temperatureSummary { get; set; }
    }

    /// <summary>
    /// Represents the Temperature information
    /// </summary>
    public class Temperature
    {
        /// <summary>
        /// Temperature Level
        /// </summary>
        public float value { get; set; }
        /// <summary>
        /// Temperature Unit
        /// </summary>
        public string unit { get; set; }
        /// <summary>
        /// Temperature Unit Type
        /// </summary>
        public int unitType { get; set; }
    }

    /// <summary>
    /// Represents the Real Feel Temperature Information
    /// </summary>
    public class Realfeeltemperature
    {
        /// <summary>
        /// Temperature Level
        /// </summary>
        public float value { get; set; }
        /// <summary>
        /// Temperature Unit
        /// </summary>
        public string unit { get; set; }
        /// <summary>
        /// Temperature Unit Type
        /// </summary>
        public int unitType { get; set; }
    }

    /// <summary>
    /// Represents the Real Feel Temperature Shade
    /// </summary>
    public class Realfeeltemperatureshade
    {
        /// <summary>
        /// Temperature Level
        /// </summary>
        public float value { get; set; }
        /// <summary>
        /// Temperature Unit
        /// </summary>
        public string unit { get; set; }
        /// <summary>
        /// Temperature Unit Type
        /// </summary>
        public int unitType { get; set; }
    }

    public class Dewpoint
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Wind
    {
        public Direction direction { get; set; }
        public Speed speed { get; set; }
    }

    public class Direction
    {
        public double degrees { get; set; }
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
        public Speed1 speed { get; set; }
    }

    public class Speed1
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Visibility
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Ceiling
    {
        public double value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Pressure
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Pressuretendency
    {
        public string localizedDescription { get; set; }
        public string code { get; set; }
    }

    public class Past24hourtemperaturedeparture
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Apparenttemperature
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Windchilltemperature
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Wetbulbtemperature
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Precipitationsummary
    {
        public Pasthour pastHour { get; set; }
        public Past3hours past3Hours { get; set; }
        public Past6hours past6Hours { get; set; }
        public Past9hours past9Hours { get; set; }
        public Past12hours past12Hours { get; set; }
        public Past18hours past18Hours { get; set; }
        public Past24hours past24Hours { get; set; }
    }

    public class Pasthour
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Past3hours
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Past6hours
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Past9hours
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Past12hours
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Past18hours
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Past24hours
    {
        public float value { get; set; }
        public string unit { get; set; }
        public int unitType { get; set; }
    }

    public class Temperaturesummary
    {
        public Past6hours1 past6Hours { get; set; }
        public Past12hours1 past12Hours { get; set; }
        public Past24hours1 past24Hours { get; set; }
    }

    public class Past6hours1
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

    public class Past12hours1
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

    public class Past24hours1
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
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
