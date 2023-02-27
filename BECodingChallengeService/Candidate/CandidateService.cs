using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BECodingChallengeService.Models;

namespace BECodingChallengeService
{
    public class CandidateService : ICandidateService
    {
        public Candidate GetCandicate()
        {
            return new Candidate();
        }
    }
}
