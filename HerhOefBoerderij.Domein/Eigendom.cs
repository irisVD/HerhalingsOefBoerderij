using System;

namespace HerhOefBoerderij.StartUp;

public class Eigendom
{
    public Eigendom(string naam, double kost)
    {
        Naam = naam;
        Kost = kost;
    }

    public string Naam { get; set; }
    protected double Kost { get; set; }

    public double BerekenOpbrengst(){
        throw new NotImplementedException();
    }

    public override string ToString(){
        throw new NotImplementedException();
        // geeft dynamisch type van het object toe, gevolgd door de naam en kost
    }


}
