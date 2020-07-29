using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{

    public class NaturalField : IFacility<ICompostProducing>
    {

        private Guid _id = Guid.NewGuid();
        public double Capacity => throw new NotImplementedException();

        private List<ICompostProducing> _seeds = new List<ICompostProducing>();

            // add the seeds to the field
            public void AddResource(ICompostProducing resource)
        {
            _seeds.Add(resource);
        }

        public void AddResource(List<ICompostProducing> resources)
        {
            // _seeds.Add(resources);
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