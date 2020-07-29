using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{

    public class NaturalField : IFacility<ICompostProducing>
    {
        private int _capacity = 60;
        private Guid _id = Guid.NewGuid();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public int GetTotal()
        {
            throw new NotImplementedException();
        }


        private List<ICompostProducing> _seeds = new List<ICompostProducing>();

        // add the seeds to the field
        public void AddResource(ICompostProducing seed)
        {
            _seeds.Add(seed);
        }

        public void AddResource(List<ICompostProducing> resources)
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