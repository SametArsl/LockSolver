using LockSolver.Hints;

namespace LockSolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LockSolverClass lockSolver = new(GetHingts_2(), 3);

            var key = lockSolver.Solve();

            Console.WriteLine("Key: {0}", key);
            /*
                682 -> 1 rakam doğru ve yeri de doğru.
                614 -> 1 rakam doğru ama yeri yanlış.
                206 -> 2 rakam doğru ama yeri yanlış.
                738 -> Hiçbir rakam doğru değil.
                780 -> 1 rakam doğru ama yeri yanlış.
            */

            List<IHint> GetHingts_1()
            {
                return new List<IHint>()
                {
                    new ExactMatchHint("682"),
                    new RightDigitWrongPlace("614"),
                    new TwoRightDigitWrongPlace("206"),
                    new NoMatchHint("738"),
                    new RightDigitWrongPlace("708")
                };
            }

            List<IHint> GetHingts_2()
            {
                return new List<IHint>()
                {
                    new ExactMatchHint("189"),
                    new RightDigitWrongPlace("147"),
                    new TwoRightDigitWrongPlace("964"),
                    new NoMatchHint("523"),
                    new RightDigitWrongPlace("286")
                };
            }
        }
    }
}