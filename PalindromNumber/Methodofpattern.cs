using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromNumber
{
    public class patternmethod
    {
        public void Pattern()
        {
            int z = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    for (int k = 0; k < i; k++) { z = i + k; }
                    Console.Write(z);
                }
                Console.WriteLine();
            }
        }
    }
}
