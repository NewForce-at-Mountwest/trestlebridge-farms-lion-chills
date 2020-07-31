using System;
using System.Linq;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Utils.Clear();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                if(farm.GrazingFields[i].GetTotal() < farm.GrazingFields[i].Capacity){
                    Console.WriteLine($"{i + 1}. Grazing Field ({farm.GrazingFields[i].GetTotal()} animals)");
                    Console.WriteLine($"{farm.GrazingFields[i].OstrichCount()} Ostriches");
                }
                
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

                // int32.parse changes string to integer, readline only does integer
            Console.Write("> ");
            // converting string to int
            int choice = Int32.Parse(Console.ReadLine());

            farm.GrazingFields[choice - 1].AddResource(animal);

            //  if (farm.GrazingFields[choice -1].GetTotal() < farm.GrazingFields[choice - 1].Capacity)
            // {
            //     farm.GrazingFields[choice - 1].AddResource(animal);
            // }
            //     else
            //     {
            //         Console.WriteLine("This field is full.");
            //         Thread.Sleep(2000);
            //     }


        }
    }
}