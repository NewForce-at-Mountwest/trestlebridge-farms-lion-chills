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

        //  this has the potential for merge conflicts. Communicate
        // when you add your resource.
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
    // example code for adding plowing fields and natural fields.  If it works.
        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);
        }

    // this might display farm status and id
        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

    // this might be example code for displaying plow field and natural field.

            GrazingFields.ForEach(gf => report.Append(gf));

            return report.ToString();
        }
    }
}