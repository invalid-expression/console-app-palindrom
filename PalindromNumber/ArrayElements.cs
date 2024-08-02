using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromNumber
{
    public class ArrayElements
    {
        public void array()
        {
            string[] StudentsName = { "Rohit", "Raju", "BabuBhaiya", "Shyam", "TotlaSeth"};

            foreach (string StudentsArrayNamePrint in StudentsName)
            {
                Console.Write($" {StudentsArrayNamePrint}");
                
            }
            Console.WriteLine(" ");
            Array.Resize(ref StudentsName, StudentsName.Length - 2);
            foreach(string afterremovearray in StudentsName)
            {
                
                Console.Write($" {afterremovearray}");
            }
            Console.ReadLine(); 
        }
       
    }
}
