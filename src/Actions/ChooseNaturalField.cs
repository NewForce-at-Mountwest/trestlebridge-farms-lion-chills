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
                try
                {


                    Console.WriteLine($"{i + 1}. Natural Field ({farm.NaturalFields[i].GetTotal()} plants)");
                    Console.WriteLine($"{farm.NaturalFields[i].SunflowerCount()} Sunflower");
                    Console.WriteLine($"{farm.NaturalFields[i].WildflowerCount()} Wildflower");
                }

                catch (Exception)
                {
                    Console.WriteLine("All fields are full. Please go back to main menu to create a new field!");
                    Console.WriteLine();
                }
            }


            Console.WriteLine();

            Console.WriteLine($"Which field would you like to choose to plant this seed?");

            Console.WriteLine("> ");
            int choice = Int32.Parse(Console.ReadLine());

            //    code for full field
            if (farm.NaturalFields[choice - 1].GetTotal() < farm.NaturalFields[choice - 1].Capacity)
            {
                farm.NaturalFields[choice - 1].AddResource(plant);
            }
            else
            {
                Console.WriteLine("This field is full.");
                Thread.Sleep(2000);
            }
        }

    }

}