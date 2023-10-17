using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSolver.Hints
{
    internal class TwoRightDigitWrongPlace : IHint
    {
        private readonly string hint;

        public TwoRightDigitWrongPlace(string hint)
        {
            this.hint = hint;
        }

        public bool IsMatch(string candidate)
        {
            int matchCount = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate.Contains(hint[i]) && candidate[i] != hint[i])
                    matchCount++;
            }

            return matchCount == 2;

            // return candidate.Zip(hint, (c, h) => c != h && hint.Contains(c) ? 1 : 0).Sum() == 1;
        }
    }
}
