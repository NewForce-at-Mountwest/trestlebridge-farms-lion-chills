using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Natural Field");
            Console.WriteLine("4. Chicken House");
            Console.WriteLine("5. Duck House");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();
            NewMethod(farm, input);
        }

        private static void NewMethod(Farm farm, string input)
        {
            switch (Int32.Parse(input))
            {
                case 1:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Success! Press return key to go back to main menu.");
                    Console.ReadLine();
                    farm.AddGrazingField(new GrazingField());
                    break;

                case 2:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Success! Press return key to go back to main menu.");
                    Console.ReadLine();
                    farm.AddPlowedField(new PlowedField());
                    break;
                case 3:
                    farm.AddNaturalFields(new NaturalField());
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Success! You have created a natural field!");
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.Write(">");
                    Console.ReadLine();
                    
                    break;
                case 4:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Success! Press return key to go back to main menu.");
                    Console.ReadLine();
                    farm.AddChickenHouse(new ChickenHouse());
                    break;
                case 5:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Success! Press return key to go back to main menu.");
                    Console.ReadLine();
                    farm.AddDuckHouse(new DuckHouse());
                    break;
                default:
                    break;
            }
        }
    }
}