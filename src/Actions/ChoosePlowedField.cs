using System;
using System.Linq;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, ISeedProducing seed)
        {
            Utils.Clear();

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                try {
                    // farm.PlowedFields[i].GetTotal() < farm.PlowedFields[i].Capacity
                    
                        Console.WriteLine($"{i + 1}. Plowed Field ({farm.PlowedFields[i].GetTotal()} plants)");
                        Console.WriteLine($"{farm.PlowedFields[i].SesameCount()} Sesame");
                        Console.WriteLine($"{farm.PlowedFields[i].SunflowerCount()} Sunflower");
                    }
                
                catch (Exception)
                {
                    Console.WriteLine("All fields are full. Please go back to main menu to create a new field!");
                    Console.WriteLine();
                }
            }
            // IResource.Type
            Console.WriteLine($"Where should we place the seed?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if (farm.PlowedFields[choice - 1].GetTotal() < farm.PlowedFields[choice - 1].Capacity)
            {
                farm.PlowedFields[choice - 1].AddResource(seed);
            }
            else
            {
                Console.WriteLine("This field is full.");
                Thread.Sleep(2000);
            }


        }
    }
}
