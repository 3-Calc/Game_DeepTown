using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeelTownCalculator
{
    class SimpleDebugger
    {
        private static int State = 0;

        public static void PrintLine(string s)
        {
            if (State > 0)
                Console.WriteLine(s);
        }
    }
}
