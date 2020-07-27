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

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */

// This has the potential for merge conflicts. Communicate when you add your resource so that we do not have rouge code.
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }

// This is example code for adding plowing fields and natural fields. If it works.
        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);
        }

        // This might display farm status 

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();


// This might be example code for displaying plow field and natural field
            GrazingFields.ForEach(gf => report.Append(gf));

            return report.ToString();
        }
    }
}