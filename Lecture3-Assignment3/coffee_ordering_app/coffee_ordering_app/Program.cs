using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee_ordering_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coffeeNum;
            bool done = false;
            int price = 0;
            do
            {
                Console.WriteLine("Please select your coffee size: 1 - small, 2 - medium, 3 - large");
                try
                {
                    coffeeNum = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                switch (coffeeNum)
                {
                    case 1:
                        price += 1;
                        break;
                    case 2:
                        price += 2;
                        break;
                    case 3:
                        price += 3;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        continue;
                }

                do
                {
                    Console.WriteLine("Do you want to buy another coffee: yes or no?");
                    String c = Console.ReadLine();
                    if(c.ToLower() == "no")
                    {
                        done = true;
                        break;
                    }
                    if(c.ToLower() == "yes")
                    {
                        break;
                    }
                } while (true);

            } while (!done);

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Total price is: " + price);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
