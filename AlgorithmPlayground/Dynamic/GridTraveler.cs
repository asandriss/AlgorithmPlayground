using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.Dynamic
{
    public class GridTraveler
    {
        public static int Travel(int rows, int columns, Dictionary<(int, int), int> memo = null)
        {
            if(memo == null) memo = new Dictionary<(int, int), int>();

            if (memo.ContainsKey((rows, columns))) return memo[(rows, columns)];
            if (memo.ContainsKey((columns, rows))) return memo[(columns, rows)];

            if (rows == 1 && columns == 1) return 1;
            if(rows == 0 || columns == 0) return 0;

            var result = Travel(rows-1, columns, memo) + Travel(rows, columns-1, memo);
            memo[(rows, columns)] = result;

            return result;
        }
    }
}
