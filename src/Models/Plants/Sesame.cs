using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    // plowed
    // seed
    // 520 seeds
    public class Sesame : IResource, ISeedProducing
    {
         private Guid _id = Guid.NewGuid();
        private int _seedsProduced = 520;
        public string Type { get; } = "Sesame";

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString()
        {
            return $"Sesame as an oil or a garnish on your salad, Sesame is delicious!!";
        }
    }
}