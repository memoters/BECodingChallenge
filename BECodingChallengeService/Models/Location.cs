using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECodingChallengeService.Models
{
    public class LocationDetail
    {
        public string IP { get; set; }
        public string Type { get; set; }
        public string Continent_code { get; set; }
        public string Continent_name { get; set; }
        public string Country_node { get; set; }
        public string Country_name { get; set; }
        public string Region_code { get; set; }
        public string Region_name { get; set;}
        public string City { get; set; }
        public string Zip { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Location Location { get; set; }

    }

    public class Location
    {
        public int Geoname_Id { get; set; }
        public string Capital { get; set; }
        public IEnumerable<Languages> Languages { get; set; }
        public string Country_flag { get; set; }
        public string Country_flag_emoji { get; set; }
        public string Country_flag_emoji_unicode { get; set; }
        public string Calling_code { get; set; }
        public bool Is_Eu { get; set; }

    }

    public class Languages 
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Native { get; set; }
    }
}
