using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 4;

            // if (x==3)
            // {
            //     Console.WriteLine("3cu yerde otura bilersiz");
            // }
        
            // if (x == 5)
            //{
            //    Console.WriteLine("5cu yerde otura bilersiz");
            // }
            // else
            // {
            //     Console.WriteLine("butun yerler doludur");
            // }

            int yer = 5;

            switch (yer)
            {
                case 5:
                    Console.WriteLine("5ci yer");
                    break;

                default:
                Console.WriteLine("default");
                    break;
            }


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }








            Console.ReadKey();
        }
    }
}
