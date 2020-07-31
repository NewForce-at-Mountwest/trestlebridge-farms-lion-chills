using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;

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

        public double GetTotal()
        {
            return _animals.Count;
        }
        public void AddResource (IGrazing resource)
        {
           _animals.Add(resource);
        }
        public void AddResources(List<IGrazing> resources)
        {
            _animals.AddRange(resources);
        }

        public int OstrichCount (){
            int count = 0;
            count = _animals.Where(animal => animal.Type == "Ostrich").Count();
            return count;
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