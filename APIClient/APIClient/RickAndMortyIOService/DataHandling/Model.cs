using System;

namespace APIClient.RickAndMortyIOService.DataHandling
{
    public class SingleEpisodeResponse : IResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string air_date { get; set; }
        public string episode { get; set; }
        public string[] @characters { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
        public string error { get; set; }

    }

    public class SingleCharacterResponse : IResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public Origin origin { get; set; }
        public Location location { get; set; }
        public string image { get; set; }
        public string[] episode { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
    }

    public class BulkEpisodeResponse : IResponse
    {
        public Info info { get; set; }
        public Result[] results { get; set; }
        public string error { get; set; }
    }

    public class BulkCharacterResponse : IResponse
    {
        public Info info { get; set; }
        public SingleCharacterResponse[] results { get; set; }
    }

    public class Info
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public object prev { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public string name { get; set; }
        public string air_date { get; set; }
        public string episode { get; set; }
        public string[] characters { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
    }

    public class Origin
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Location
    {
        public string name { get; set; }
        public string url { get; set; }
    }

}
