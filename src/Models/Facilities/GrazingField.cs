using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 2;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }
        public void AddResource (IGrazing resource)
        {
            if(this._animals.Count >= _capacity )
            {
                Console.WriteLine("This field is full. Please select a different field.");
                Console.ReadLine();
            }
            else
            {
                _animals.Add(resource);
            }
           
        }
        public void AddResources(List<IGrazing> resources)
        {
            _animals.AddRange(resources);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}