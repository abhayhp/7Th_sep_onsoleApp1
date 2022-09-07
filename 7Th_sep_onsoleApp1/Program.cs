using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Th_sep_onsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char input = 'd';

            //if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            //{
            //    Console.WriteLine(" vowel");

            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}
           // Console.WriteLine(15 % 10);

            Console.WriteLine("Enter two numbers--");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation number you want to perform");
            Console.WriteLine(" 1 for addition");
            Console.WriteLine(" 2 for subtraction");
            Console.WriteLine(" 3 for Multiplication");
            Console.WriteLine(" 4 for Division");
            Console.WriteLine(" 5 for Mod");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1: Console.WriteLine($" add is {(n1 + n2)}");
                    break;

                case 2: Console.WriteLine($" sub is {(n1 - n2)}");
                    break;

                case 3: Console.WriteLine($"mul is {(n1 * n2)}");
                    break;

                case 4: Console.WriteLine($" Div is {(n1/n2)}");
                    break;

                case 5: Console.WriteLine($" modulus is {(n1 % n2)}");
                    break;

                default:
                    Console.WriteLine("Wrong Input-");
                    break;




            }







            //if (n1 > n2)
            //{
            //    if(n1 > n3)
            //    {
            //        Console.WriteLine($" {n1} is the greatest");
            //    }
            //    else
            //    {
            //        Console.WriteLine($" {n3} is greatest");
            //    }
            //}
            //else
            //{

            //}






        }
    }
}
