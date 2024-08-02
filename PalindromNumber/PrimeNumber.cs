using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromNumber
{
    public class PrimeNUmber
    {
       public void PrimeNumber()
        {
            Console.Write("Enter The Number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x==2 || x % 2 != 0)
            {
                Console.WriteLine($"{x} is an prime number");
            }
            else
            {
                Console.WriteLine($"{x} is not a prime number");
            }
            Console.WriteLine("Press Enter To Exit");

            Console.ReadLine();
        }
       
    }
}
