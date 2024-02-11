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
            bool b = true;
            int price = 0;
            do
            {

                Console.WriteLine("1:small , 2:medium, 3:large");
                try
                {
                    coffeeNum = int.Parse(Console.ReadLine());
                    switch (coffeeNum)
                    {
                        case 1:
                            Console.WriteLine("small");
                            price += 1;
                            break;
                        case 2:
                            Console.WriteLine("medium");
                            price += 2;
                            break;
                        case 3:
                            Console.WriteLine("large");
                            price += 3;
                            break;
                        default:
                            Console.WriteLine("wrong input");
                            break;
                    }
                    Console.WriteLine("continue?");
                    String c = Console.ReadLine();
                    c = c.ToLower();
                    if (c.Equals("yes"))
                    {
                        b = true;
                    }
                    else if (c.Equals("no"))
                    {
                        Console.WriteLine("thank you for shopping");
                        b = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("yes or no only");
                    }

                }
                catch (OverflowException ex)
                {

                }
            } while (b);
            Console.WriteLine("Total price is: " + price);
            Console.ReadLine();

            
        }
    }
}
