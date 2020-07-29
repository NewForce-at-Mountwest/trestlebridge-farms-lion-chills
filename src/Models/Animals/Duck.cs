using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

// Don't forget to add the appropriate namespace in the new classes that we are creating. Make files in the right place to make it easy!
namespace Trestlebridge.Models.Animals {
    public class Duck : IResource, IGrazing {

        private Guid _id = Guid.NewGuid();
        private double _eggProduced = 6.0;
        private double _featherProduced = 0.75;

                // shortens animal id
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 5.4;
        public string Type { get; } = "Duck";

        // Methods
        public void Graze () {
            Console.WriteLine($"Duck {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

            // will come in handy when console writelining for a cow
        public override string ToString () {
            return $"Duck {this._shortId}. Quack!";
        }
    }
}