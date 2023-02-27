using BECodingChallengeService;
using BECodingChallengeService.Models;
using Microsoft.AspNetCore.Mvc;

namespace BECodingChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListingsQuoteController : ControllerBase
    {
        private readonly ILogger<CandidateController> _logger;
        private IListingsService _listingService;
        public ListingsQuoteController(ILogger<CandidateController> logger, IListingsService listingService)
        {
            _logger = logger;
            _listingService = listingService;
        }

        [HttpGet("~/Listings/{passengerCount}")]
        public ActionResult<QuoteResponse> GetLocation(int passengerCount) 
        {
            var quote = _listingService.GetQuote(passengerCount).Result;

            return Ok(quote);
        }
    }
}