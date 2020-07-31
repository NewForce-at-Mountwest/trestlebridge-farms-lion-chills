using System.Collections.Generic;

namespace Trestlebridge.Interfaces
{
    public interface ICompostProducing
    {
        double Compost ();

        string Type {get; }
    }
}