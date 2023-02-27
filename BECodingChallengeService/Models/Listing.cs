using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECodingChallengeService.Models
{
    public class QuoteResult 
    { 
        public string From { get; set; }
        public string To { get; set; }
        public IEnumerable<Listing> Listings { get; set; }
    }

    public class Listing
    {
        public string Name { get; set; }
        public double PricePerPassenger { get; set; }
        public VehicleType VehicleType { get; set; }
       
    }

    public class VehicleType
    { 
        public string Name { get; set; }
        public int MaxPassengers { get; set; }
    }
}
