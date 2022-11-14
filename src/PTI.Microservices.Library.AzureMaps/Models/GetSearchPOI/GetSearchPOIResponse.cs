using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTI.Microservices.Library.Models.AzureMapsService.GetSearchPOI
{

    public class GetSearchPOIResponse
    {
        public Summary summary { get; set; }
        public Result[] results { get; set; }
    }

    public class Summary
    {
        public string query { get; set; }
        public string queryType { get; set; }
        public int queryTime { get; set; }
        public int numResults { get; set; }
        public int offset { get; set; }
        public int totalResults { get; set; }
        public int fuzzyLevel { get; set; }
    }

    public class Result
    {
        public string type { get; set; }
        public string id { get; set; }
        public float score { get; set; }
        public string info { get; set; }
        public Poi poi { get; set; }
        public Address address { get; set; }
        public Position position { get; set; }
        public Viewport viewport { get; set; }
        public Entrypoint[] entryPoints { get; set; }
        public Datasources dataSources { get; set; }
    }

    public class Poi
    {
        public string name { get; set; }
        public string phone { get; set; }
        public Categoryset[] categorySet { get; set; }
        public string url { get; set; }
        public string[] categories { get; set; }
        public Classification[] classifications { get; set; }
    }

    public class Categoryset
    {
        public int id { get; set; }
    }

    public class Classification
    {
        public string code { get; set; }
        public Name[] names { get; set; }
    }

    public class Name
    {
        public string nameLocale { get; set; }
        public string name { get; set; }
    }

    public class Address
    {
        public string municipality { get; set; }
        public string countrySecondarySubdivision { get; set; }
        public string countrySubdivision { get; set; }
        public string countryCode { get; set; }
        public string country { get; set; }
        public string countryCodeISO3 { get; set; }
        public string freeformAddress { get; set; }
        public string localName { get; set; }
    }

    public class Position
    {
        public float lat { get; set; }
        public float lon { get; set; }
    }

    public class Viewport
    {
        public Topleftpoint topLeftPoint { get; set; }
        public Btmrightpoint btmRightPoint { get; set; }
    }

    public class Topleftpoint
    {
        public float lat { get; set; }
        public float lon { get; set; }
    }

    public class Btmrightpoint
    {
        public float lat { get; set; }
        public float lon { get; set; }
    }

    public class Datasources
    {
        public Poidetail[] poiDetails { get; set; }
    }

    public class Poidetail
    {
        public string id { get; set; }
        public string sourceName { get; set; }
    }

    public class Entrypoint
    {
        public string type { get; set; }
        public Position1 position { get; set; }
    }

    public class Position1
    {
        public float lat { get; set; }
        public float lon { get; set; }
    }

}
