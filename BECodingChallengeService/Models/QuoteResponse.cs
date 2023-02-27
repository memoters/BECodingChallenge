using BECodingChallengeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECodingChallengeService
{
    public class QuoteResponse
    {
        public double TotalPrice { get; set; }
        public List<Listing> Listings { get; set; }
    }
}
