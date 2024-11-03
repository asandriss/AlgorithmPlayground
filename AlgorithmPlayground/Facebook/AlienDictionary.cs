using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.Facebook
{
    public class AlienDictionary
    {
        private readonly string _alphabetOrder;
        private readonly Dictionary<char, short> _indexCache = new Dictionary<char, short>();

        public AlienDictionary(string alphabetOrder)
        {
            _alphabetOrder = alphabetOrder;
        }

        public bool Verify(string[] words)
        {
            return false;
        }

        public short GetCharacterIndex(char character)
        {
            if (_indexCache.ContainsKey(character))
                return _indexCache[character];

            for(short i=0; i<_alphabetOrder.Length; i++)
            {
                if (_alphabetOrder[i] != character) continue;
                
                _indexCache[character] = i;
                return i;
            }

            return -1;
        }
    }
}
