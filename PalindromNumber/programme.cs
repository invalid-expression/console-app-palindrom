using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
       
namespace PalindromNumber
{                         
    public class programme
    {   
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("1) Pattern");
            Console.WriteLine("2) Prime Number");
            Console.WriteLine("3) Palindrom Number");
            Console.WriteLine("4) List");
            Console.WriteLine("5) Sum of Digit");
            Console.WriteLine("6) Array Elements");

            Console.Write("Enter The Number: ");
            number = Convert.ToInt32(Console.ReadLine());      

            switch (number)
            {
                case 1:
                    patternmethod objectofmethods = new patternmethod();
                    objectofmethods.Pattern();
                    break;

                case 2:
                    PrimeNUmber objectofprimenumber = new PrimeNUmber();
                    objectofprimenumber.PrimeNumber();
                    break;

                case 3:
                    PalindromNUmber objectofpalindrome = new PalindromNUmber();
                    objectofpalindrome.PalindromNumber();
                    break;

                case 4:
                    List objectoflist = new List();
                    objectoflist.ListMethod();
                    break;

                case 5:
                    sumofdigitclass sumofdigit = new sumofdigitclass();
                    sumofdigit.sumofdigit();
                    break;

                case 6:
                    ArrayElements arrayElements = new ArrayElements();
                    arrayElements.array();
                    break;

                default:
                    invailid invailidobject = new invailid();
                    invailidobject.InvailidEntry();
                    break;
            }
            Console.ReadLine();
        }
        
       
    }
}
