using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, ISeedProducing seed)
        {
            Utils.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field");

                Console.WriteLine();

                Console.WriteLine($"Which field would you like to choose to plant this seed?");

                Console.WriteLine("> ");
                int choice = Int32.Parse(Console.ReadLine());

                //Adds the seed to natural field
            farm.NaturalFields[choice - 1].AddResource(seed);
            }
        }

    }

}





    