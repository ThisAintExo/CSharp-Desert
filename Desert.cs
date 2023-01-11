using System;
using System.Text.Json;

namespace Desert
{
    public class desert_testing
    {
        // Class we will use to deserialise the json
        public class Desert_Class
        {
            public string? GetThis { get; set; }
        }
        public static void Main(string[] args)
        {
            public String JsonDesert = "Enter your json here";

            public string Full_Desrt = JsonSerializer.Deserialize<Desert_Class>(JsonDesert);
        }
    }
}
