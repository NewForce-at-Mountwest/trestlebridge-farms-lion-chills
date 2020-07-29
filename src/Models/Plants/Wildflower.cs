using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    // natural field
    // compost
    // amount 30.3kg
    public class Wildflower : IResource, ISeedProducing
    {
        private Guid _id = Guid.NewGuid();

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public string Type => throw new NotImplementedException();

        public double Harvest()
        {
            throw new NotImplementedException();
        }
    }
}