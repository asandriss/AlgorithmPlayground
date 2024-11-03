using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.Search
{
    public class BinarySearch<T> where T : IComparable<T>
    {
        public const int NotFound = -1;

        public int Search(IList<T> inputEnumerable, T searchValue)
        {
            // else do recursion until found
            int retVal = Search_Impl(inputEnumerable, searchValue, 0);
            return retVal;
        }

        private int Search_Impl(IList<T> inputEnumerable, T searchValue, int index)
        {
            if (!inputEnumerable.Any()) return NotFound;        // empty list, can't have results
            if (inputEnumerable.Count == 1) return inputEnumerable[0].Equals(searchValue) ? 0 : NotFound;           // if only one element check if matches

            var indexToCheck = inputEnumerable.Count / 2;

            if (inputEnumerable[indexToCheck].Equals(searchValue))
            {
                // we found the value, return the index
                return index + indexToCheck;
            }

            if (inputEnumerable[indexToCheck].CompareTo(searchValue) > 0)
            {
                // value at index is bigger than searched value - we can discard the second half of the array
                var newList = inputEnumerable.Take(indexToCheck).ToList();
                return Search_Impl(newList, searchValue, index);
            }
            
            if (inputEnumerable[indexToCheck].CompareTo(searchValue) < 0)
            {
                var newList = inputEnumerable.Skip(indexToCheck).ToList();
                return Search_Impl(newList, searchValue, index+indexToCheck);
            }

            return NotFound;
        }
    }
}
