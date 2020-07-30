using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{

    public class NaturalField : IFacility<ICompostProducing>
    {
        private int _capacity = 60;
        // 10 rows of plants, 6 plants per row = 60
        private Guid _id = Guid.NewGuid();
        private List<ICompostProducing> _seeds = new List<ICompostProducing>();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void AddResource(ICompostProducing resource)
        {
            _seeds.Add(resource);
        }
        public void AddResources(List<ICompostProducing> resources)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._seeds.Count} seeds\n");
            this._seeds.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}