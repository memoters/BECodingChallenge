using BECodingChallengeService;
using BECodingChallengeService.Models;
using Microsoft.AspNetCore.Mvc;

namespace BECodingChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILogger<CandidateController> _logger;
        private ILocationService _locationService;
        public LocationController(ILogger<CandidateController> logger, ILocationService locationService)
        {
            _logger = logger;
            _locationService = locationService;
        }

        [HttpGet("~/Location")]
        public ActionResult<string> GetLocation() 
        {
            string result = "City not found";
            string city = _locationService.GetLocation().Result;

            if (city != string.Empty)
            {
                result = $"City: {city}";
            }

            return Ok(result);
        }
    }
}