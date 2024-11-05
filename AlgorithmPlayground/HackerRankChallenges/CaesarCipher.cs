using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.HackerRankChallenges
{
    public class CaesarCipher
    {
        public static string Encrypt(string input, int shift)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var charIndexTable = new Dictionary<char, int>();
            int i = 0;
            foreach (var c in alphabet)
            {
                charIndexTable.Add(c, i);
                i++;
            }

            var inputArray = input.ToCharArray();
            var retVal = string.Empty;

            foreach (var c in inputArray)
            {
                char lookup = c.ToString().ToLower()[0];
                var charToAdd = charIndexTable.TryGetValue(lookup, out var value) ? alphabet[(value+shift) % alphabet.Length] : c;

                if(!charIndexTable.ContainsKey(c))
                    charToAdd = charToAdd.ToString().ToUpper()[0];

                retVal += charToAdd;
            }

            return retVal;
        }
    }
}
