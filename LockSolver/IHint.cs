﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSolver
{
    public interface IHint
    {
        bool IsMatch(string candidate);
    }
}
