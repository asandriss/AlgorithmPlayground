using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            // init basic repo info
            var getGithubRepo = GetUrl("https://github.com/");
            
            // ... later
            var myRepo = getGithubRepo("asandriss/AlgorithmPlayground");
            
            Console.WriteLine(myRepo);
        }

        static Func<string, string> GetUrl(string baseHost)
        {
            return x => $"{baseHost}/{x}";
        }
    }
}
