using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

// Don't forget to add the appropriate namespace in the new classes that we are creating. Make files in the right place to make it easy!
namespace Trestlebridge.Models.Animals {
    public class Goat : IResource, IGrazing {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 18.25;
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double CompostPerDay {get; set;} = 7.5;
        public double GrassPerDay { get; set; } = 4.1;
        public string Type { get; } = "Goat";

        // Methods
        public void Graze () {
            Console.WriteLine($"Goat {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }


            // will come in handy when console writelining for a cow
        public override string ToString () {
            return $"Goat {this._shortId}. Baaa!";
        }
    }
}