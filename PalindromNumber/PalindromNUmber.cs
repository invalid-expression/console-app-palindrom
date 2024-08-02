using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromNumber
{
    public class PalindromNUmber
    {
        public void PalindromNumber()
        {

            int x, r, y = 0, number;
            Console.Write("GITHUB>>Enter Your Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            x = number;

            while (x != 0)
            {
                r = x % 10;
                y = y * 10 + r;
                x = x / 10;
            }

            if(number == y)
            {
                Console.WriteLine("You Entered The Palindrom Number");
            }
            else
            {
                Console.WriteLine("You Not Entered The Palindrom Number Execute Code Again And Enter New Number");
            }
            Console.ReadLine();
        }
       
    }
}
