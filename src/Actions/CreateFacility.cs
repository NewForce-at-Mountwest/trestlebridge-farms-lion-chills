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
            Console.WriteLine ("3. Natural Field");
            Console.WriteLine("4. Chicken House");

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
                    farm.AddGrazingField(new GrazingField());
                    break;
                case 4:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Success! Press return key to go back to main menu.");
                    Console.ReadLine();
                    farm.AddChickenHouse(new ChickenHouse());
                    break;
                default:
                    break;

                    case 3:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Success! Press return key to go back to main menu.");
                    Console.ReadLine();
                    farm.AddNaturalFields(new NaturalField());
                    break;
                // default:
                //     break;
            }
        }
    }
}