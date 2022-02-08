using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaronMillerAssignment2PROG2070
{
    class Program
    {
        static void Main(string[] args)
        {
            int optionSelected;
            int width = 0;
            int length = 0;
            bool showMenu = true;
            Console.WriteLine("Hello, welcome to the Rectangle application.");
            while (width == 0 || length == 0)
            {
                try
                {
                    Console.WriteLine("Please enter a single number above 0 for the rectangle's length.");
                    length = Convert.ToInt32(Console.ReadLine());
                    if (length <= 0)
                    {
                        throw new Exception();
                    }
                    Console.WriteLine("Please enter a whole number greater than 0 for the rectangle's width.");
                    width = Convert.ToInt32(Console.ReadLine());
                    if (width <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("-----------------\nError, incorrect input received, please enter a whole number greater than 0.\n-----------------\n");
                }
            }
            Rectangle rect = new Rectangle(length, width);
            while (showMenu)
            {
                Console.WriteLine("-----------------\nPlease choose an option by typing a number between 1 and 7.\n-----------------\n" +
                "1. Get Rectangle Length\n" +
                "2. Change Rectangle Length\n" +
                "3. Get Rectangle Width\n" +
                "4. Change Rectangle Width\n" +
                "5. Get Rectangle Perimeter\n" +
                "6. Get Rectangle Area\n" +
                "7. Exit");
                try
                {
                    optionSelected = Convert.ToInt32(Console.ReadLine());
                    switch (optionSelected)
                    {
                        case 1:
                            Console.WriteLine("The length is: " + rect.GetLength());
                            break;
                        case 2:
                            Console.WriteLine("Please enter a single number above 0 for the rectangle's legnth.");
                            rect.SetLength(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 3:
                            Console.WriteLine("The width is: " + rect.GetWidth());
                            break;
                        case 4:
                            Console.WriteLine("Please enter a single number above 0 for the rectangle's width.");
                            rect.SetWidth(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 5:
                            Console.WriteLine("The perimeter is: " + rect.GetPerimeter());
                            break;
                        case 6:
                            Console.WriteLine("The area is: " + rect.GetArea());
                            break;
                        case 7:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("-----------------\nError, incorrect input received. Please enter a whole number between 1 and 7.\n-----------------\n");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("-----------------\nError, incorrect input received. Please enter a whole number between 1 and 7.\n-----------------\n");
                }
            }
                            
        }

    }
}
