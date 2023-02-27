using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECodingChallengeService
{
    public interface IListingsService
    {
        public Task<QuoteResponse> GetQuote(int numberOfPassengers);
    }
}
