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
            List<string> seatingchart = new List<string>();
            seatingchart.Add("Economy");
            seatingchart.Add("Economy");
            seatingchart.Add("Economy");
            seatingchart.Add("Economy");
            seatingchart.Add("Economy");
            seatingchart.Add("First Class");
            seatingchart.Add("First Class");
            seatingchart.Add("First Class");
            seatingchart.Add("First Class");
            seatingchart.Add("First Class");
            List<string> assignedseats = new List<string>();
            
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
                    case "1": // The "1" neumeric key selects economy class
                        Console.WriteLine("First Class slected");
                        Console.WriteLine();
                        break;
                    case "2": // The "2" numeric key selects first class

                        Console.WriteLine("Economy class selected");
                        Console.WriteLine();
                        break;
                    case "3": // The "3" numeric Key to Exit the menu
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
