﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECodingChallengeService
{
    public interface ILocationService
    {
        Task<string> GetLocation();
    }
}
