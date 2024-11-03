using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.Search
{
    public class LinearSearch<T>
    {
        public const int ResultNotFound = -1;
        
        public int Search(IEnumerable<T> input, T searchTerm)
        {
            if (input == null) throw new ArgumentNullException(nameof(input), "Input must be provided");

            var retVal = 0;

            foreach (var item in input)
            {
                if (item.Equals(searchTerm))
                {
                    return retVal;
                }

                retVal++;
            }

            return ResultNotFound;  // result not found
        }
    }
}
