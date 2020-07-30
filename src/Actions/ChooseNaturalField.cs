using System;
using System.Linq;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, ICompostProducing plant)
        {
            Utils.Clear();

            //Prints each available natural field 
            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                {
                    Console.WriteLine($"{i + 1}. Natural Field");
                }

            }

            Console.WriteLine();

            Console.WriteLine($"Choose a field to plant your seed in?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if (farm.NaturalFields[choice -1].GetTotal() < farm.NaturalFields[choice - 1].Capacity)
            {
                farm.NaturalFields[choice - 1].AddResource(plant);
            }
                else
                {
                    Console.WriteLine("This field is full.");
                    Thread.Sleep(2000);
                }


            //Adds the plant/seed to the selected natural field
            // if (farm.NaturalFields[choice - 1].GetTotal == farm.NaturalFields[choice - 1].Capacity)
            // {
            //     farm.NaturalFields[choice - 1].AddResource(plant);
            // }
            //     else
            //     {
            //         Console.WriteLine("This field is full.");
            //     }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<ICompostProducing>(plant, choice);

        }
    }
}