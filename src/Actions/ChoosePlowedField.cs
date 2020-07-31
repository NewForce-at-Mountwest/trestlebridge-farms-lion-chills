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
                Console.WriteLine($"{i + 1}. {farm.PlowedFields[i]}");
            }

            Console.WriteLine();

            // IResource.Type
            Console.WriteLine($"Where should we place the seed?");
            
            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
                   //Adds the seed to natural field
                 if (farm.PlowedFields[choice -1].GetTotal() < farm.PlowedFields[choice - 1].Capacity)
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