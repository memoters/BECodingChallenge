using BECodingChallengeService;
using BECodingChallengeService.Models;
using Microsoft.AspNetCore.Mvc;

namespace BECodingChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidateController : ControllerBase
    {
        private readonly ILogger<CandidateController> _logger;
        private ICandidateService _candidateService;
        public CandidateController(ILogger<CandidateController> logger, ICandidateService candidateService)
        {
            _logger = logger;
            _candidateService = candidateService;
        }

        [HttpGet("~/Candidate")]
        public ActionResult<Candidate> GetCandidate() 
        {
            return Ok(_candidateService.GetCandicate());
        }
    }
}