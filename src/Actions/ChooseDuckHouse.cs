using System;
using System.Linq;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IMeatProducing animal)
        {
            Utils.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {farm.DuckHouses[i]}");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

                // int32.parse changes string to integer, readline only does integer
            Console.Write("> ");
            // converting string to int
            int choice = Int32.Parse(Console.ReadLine());

            // farm.DuckHouses[choice - 1].AddResource(animal);

             if (farm.DuckHouses[choice -1].GetTotal() < farm.DuckHouses[choice - 1].Capacity)
            {
                farm.DuckHouses[choice - 1].AddResource(animal);
            }
                else
                {
                    Console.WriteLine("This field is full.");
                    Thread.Sleep(2000);
                }


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}