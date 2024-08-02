using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromNumber
{
    public class sumofdigitclass
    {
        public void sumofdigit()
        {
            int x, r, y = 0;
            Console.Write("Enter Your Number: ");
            x = Convert.ToInt32(Console.ReadLine());

            while (x != 0)
            {
                r = x % 10;
                y = r + y;
                x = x / 10;
            }
            Console.WriteLine(y);
            Console.ReadLine();
        }
       
    }
}
