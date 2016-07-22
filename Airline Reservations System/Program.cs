using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservations_System
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool reservationmenu = true;
            
            while (reservationmenu)
            {
                // show options in the console menu
                Console.WriteLine(" Please make your reservation");
                Console.WriteLine(" 1. First Class");
                Console.WriteLine(" 2. Economy");
                Console.WriteLine(" 3. Exit");
                Console.WriteLine("----------------------------------");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1": // The "1" Key - Select Lotto 6 / 49"
                        Console.WriteLine("First Class slected");
                        Console.WriteLine();
                        break;
                    case "2": // The "2" Key - Select Lotto Max
                        
                        Console.WriteLine("Economy class selected");
                        Console.WriteLine();
                        break;
                    case "3": // The "3" Key - Exit the menu
                        reservationmenu = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
