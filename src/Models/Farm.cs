using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<PlowedField> PlowedFields {get; } = new List<PlowedField>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())

            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Goat":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Ostrich":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Pig":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Sheep":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }
        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);
        }
        public void AddPlowedField (PlowedField field)
        {
            PlowedFields.Add(field);
        }

          public void AddChickenHouse (ChickenHouse house)
        {
            ChickenHouses.Add(house);
        }

         public void AddNaturalFields(NaturalField field)
        {
            NaturalFields.Add(field);
        }
         public void AddDuckHouse (DuckHouse house)
        {
            DuckHouses.Add(house);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));

            PlowedFields.ForEach(pf => report.Append(pf));

            ChickenHouses.ForEach(ch => report.Append(ch));
            
            NaturalFields.ForEach(nf => report.Append(nf));

            DuckHouses.ForEach(dh => report.Append(dh));

            return report.ToString();
        }

        
    }
}