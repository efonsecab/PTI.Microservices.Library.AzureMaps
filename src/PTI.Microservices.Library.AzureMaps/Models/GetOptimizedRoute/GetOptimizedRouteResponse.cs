using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTI.Microservices.Library.Models.AzureMapsService.GetOptimizedRoute
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class GetOptimizedRouteResponse
    {
        public string formatVersion { get; set; }
        public Route[] routes { get; set; }
    }

    public class Route
    {
        public Summary summary { get; set; }
        public Leg[] legs { get; set; }
        public Section[] sections { get; set; }
    }

    public class Summary
    {
        public int lengthInMeters { get; set; }
        public int travelTimeInSeconds { get; set; }
        public int trafficDelayInSeconds { get; set; }
        public DateTime departureTime { get; set; }
        public DateTime arrivalTime { get; set; }
    }

    public class Leg
    {
        public Summary1 summary { get; set; }
        public Point[] points { get; set; }
    }

    public class Summary1
    {
        public int lengthInMeters { get; set; }
        public int travelTimeInSeconds { get; set; }
        public int trafficDelayInSeconds { get; set; }
        public DateTime departureTime { get; set; }
        public DateTime arrivalTime { get; set; }
    }

    public class Point
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
    }

    public class Section
    {
        public int startPointIndex { get; set; }
        public int endPointIndex { get; set; }
        public string sectionType { get; set; }
        public string travelMode { get; set; }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
