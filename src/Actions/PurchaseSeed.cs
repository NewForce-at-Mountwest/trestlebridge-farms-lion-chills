using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseSeed
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Sunflower - Natural Field");
            Console.WriteLine("3. Sunflower - Plowed Field");
            Console.WriteLine("4. Wildflower");

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
                case 1:
                    ChoosePlowedField.CollectInput(farm, new Sesame());
                    break;
                case 2:
                    ChooseNaturalField.CollectInput(farm, new Sunflower());
                    break;
                case 3:
                    ChoosePlowedField.CollectInput(farm, new Sunflower());
                    break;
                case 4:
                    ChooseNaturalField.CollectInput(farm, new Wildflower());
                    break;
                default:
                    break;
            }
        }
    }
}