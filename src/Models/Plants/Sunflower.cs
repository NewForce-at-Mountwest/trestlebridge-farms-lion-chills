using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing
    {

        private Guid _id = Guid.NewGuid();

        private int _seedsProduced = 650;

        private double _compostProduced = 21.6;

        public string Type { get; } = "Sunflower";

        public double Harvest()
        {
            return _seedsProduced;
        }

        public double Compost()
        {
            return _compostProduced;
        }


        public override string ToString()
        {
            return $"Sunflowers are beautiful and nutritious!";
        }
    }
}