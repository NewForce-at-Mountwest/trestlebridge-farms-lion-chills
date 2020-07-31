using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IMeatProducing>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IMeatProducing> _animals = new List<IMeatProducing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public double GetTotal()
        {
            return _animals.Count;
        }
        public List<IMeatProducing> resources { get; set; }

        public void AddResource(IMeatProducing animal)
        {

            _animals.Add(animal);


        }

        public void AddResources(List<IMeatProducing> resources)
        {
            throw new NotImplementedException();
        }

        public double Butcher()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken House {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }


    }
}