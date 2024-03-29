﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSolver.Hints
{
    internal class RightDigitWrongPlace : IHint
    {
        private readonly string hint;

        public RightDigitWrongPlace(string hint)
        {
            this.hint = hint;
        }

        public bool IsMatch(string candidate)
        {
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate.Contains(hint[i]) && candidate[i] != hint[i])
                    return true;
            }

            return false;

            // return candidate.Zip(hint, (c, h) => c != h && hint.Contains(c) ? 1 : 0).Sum() == 1;
        }
    }
}
