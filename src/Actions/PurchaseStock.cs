using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Chicken");
            Console.WriteLine("2. Cow");
            Console.WriteLine("3. Duck");
            Console.WriteLine("4. Ostrich");



            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 2:
                    //  this does not work.  Breaks when we attempt to put a cow in a field.  
                    //  Good example code for purchasing an animal.
                    // This does not work. Breaks when attempt to put cow in field. Good example code for purchasing an animal though.
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                case 1:
                    //  this does not work.  Breaks when we attempt to put a Chicken in a field.  
                    //  Good example code for purchasing an animal.
                    // This does not work. Breaks when attempt to put Chicken in field. Good example code for purchasing an animal though.
                    ChooseChickenHouse.CollectInput(farm, new Chicken());
                    break;
                case 3:
                    //  this does not work.  Breaks when we attempt to put a duck in a field.  
                    //  Good example code for purchasing an animal.
                    // This does not work. Breaks when attempt to put duck in field. Good example code for purchasing an animal though.
                    ChooseDuckHouse.CollectInput(farm, new Duck());
                    break;
                case 4:
                    //  this does not work.  Breaks when we attempt to put a duck in a field.  
                    //  Good example code for purchasing an animal.
                    // This does not work. Breaks when attempt to put duck in field. Good example code for purchasing an animal though.
                    ChooseGrazingField.CollectInput(farm, new Ostrich());
                    break;
                default:
                    break;
            }
        }
    }
}