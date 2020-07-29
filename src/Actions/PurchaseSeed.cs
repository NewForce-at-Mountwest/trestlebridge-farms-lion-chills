using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class PurchaseSeed 
    {
          public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Sunflower");
            Console.WriteLine("3. Wildflower");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to plant");

            Console.Write("> ");
            string input = Console.ReadLine();
            NewMethod(farm, input);
        }

        private static void NewMethod(Farm farm, string input)
        {
            switch (Int32.Parse(input))
            {
                // case 1:
                //     Console.WriteLine("\n\n\n");
                //     Console.WriteLine("Success you have planted a sesame seed! Press return key to go back to main menu.");
                //     Console.ReadLine();
                //     farm.AddSesame(new Sesame());
                //     break;

                // case 2:
                //     Console.WriteLine("\n\n\n");
                //     Console.WriteLine("Success you have planted a sunflower seed! Press return key to go back to main menu.");
                //     Console.ReadLine();
                //     farm.AddSunflower(new Sunflower());
                //     break;
                case 3:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Success you have a planted a wildflower seed! Press return key to go back to main menu.");
                    Console.ReadLine();
                    farm.AddWildflower(new Wildflower());
                    break;
                default:
                    break;
            }
        }
    }
}