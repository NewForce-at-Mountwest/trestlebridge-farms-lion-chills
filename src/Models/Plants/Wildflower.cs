using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    // wrong type --- try/catch
    // field is full --- if/else
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
            //name specific wildflower here IResource.Type?
            return $"Wildflower. So pretty!";
        }

        public double Compost()
        {
            return 30.3;
        }
    }
}