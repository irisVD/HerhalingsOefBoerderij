using System;

namespace HerhOefBoerderij.Domein;

public class Eigendom
{

    public string Naam { get; set; }
    protected double Kost { get; set; }

    public Eigendom(string naam, double kost)
    {
        Naam = naam;
        Kost = kost;
    }

    public virtual double BerekenOpbrengst()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return String.Format("{0} \"Achteraan\" met kost {1}.", this.GetType().Name, Kost);
    }


}
