using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    // natural field
    // compost
    // amount 30.3kg
    public class Wildflower : IResource, ICompostProducing
    {
        private Guid _id = Guid.NewGuid();

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public string Type { get; } = "Wildflower";

          public override string ToString () {
            return $"Wildflower. So pretty!";
        }

        public double Compost()
        {
            throw new NotImplementedException();
        }
    }
}