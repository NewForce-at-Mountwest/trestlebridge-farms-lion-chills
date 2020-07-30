using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

// Don't forget to add the appropriate namespace in the new classes that we are creating. Make files in the right place to make it easy!
namespace Trestlebridge.Models.Animals {
    public class Pig : IResource, IGrazing, IMeatProducing {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 8.4;
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 3.2;
        public string Type { get; } = "Pig";

        // Methods
        public void Graze () {
            Console.WriteLine($"Pig {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double Butcher () {
            return _meatProduced;
        }

            // will come in handy when console writelining for a cow
        public override string ToString () {
            return $"Pig {this._shortId}. Oink!";
        }
    }
}