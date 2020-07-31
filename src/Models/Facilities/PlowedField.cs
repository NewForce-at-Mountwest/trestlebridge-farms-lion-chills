using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<ISeedProducing>
    {
        private int _capacity = 2;
        // 13 rows of plants, 5 plants per row = 65
        private Guid _id = Guid.NewGuid();

        private List<ISeedProducing> _seeds = new List<ISeedProducing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        
        public double GetTotal()
        {
            return _seeds.Count;
        }

        public void AddResource(ISeedProducing resource)
        {
            _seeds.Add(resource);
        }
        public void AddResources(List<ISeedProducing> resources)
        {
            _seeds.AddRange(resources);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._seeds.Count} plants\n");
            this._seeds.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}