using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.Dynamic
{
    public class Fib
    {
        public static long Fibonacci(int elementAt, Dictionary<int, long> memo = null)
        {
            if(memo == null) memo = new Dictionary<int, long>();

            if(memo.TryGetValue(elementAt, out var fibonacci)) return fibonacci;

            if (elementAt <= 2) return 1;

            var result = Fibonacci(elementAt - 1, memo) + Fibonacci(elementAt - 2, memo);
            memo.Add(elementAt, result);

            return result;
        }
    }
}
