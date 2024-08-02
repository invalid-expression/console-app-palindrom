using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromNumber
{
    public class List
    {
        public void ListMethod()
       {
            List<int> listaddedobject = new List<int>();
            listaddedobject.Add(1);
            listaddedobject.Add(2);
            listaddedobject.Add(3);
            listaddedobject.Add(4);

            int firstnumber = listaddedobject[0];
            Console.WriteLine(firstnumber);

            int secondnumber = listaddedobject[1];
            Console.WriteLine(secondnumber);

            Console.WriteLine("All The Elements From The List");
            foreach (int numbers in listaddedobject)
            {
                Console.Write($" {numbers}");
            }

            Console.ReadLine();
        }
       
    }
}
