using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");

            Console.WriteLine ();
            Console.WriteLine ("Choose what you want to create");

            Console.Write ("> ");
            string input = Console.ReadLine ();

            switch (Int32.Parse(input))
            {
                case 1:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Success! Press return key to go back to main menu.");
                    Console.ReadLine();
                    farm.AddGrazingField(new GrazingField());
                    break;
                default:
                    break;
            }
        }
    }
}