using System;

namespace HerhOefBoerderij.Domein;

public class Boer : Persoon
{
    private double _aandeelInDeOnderneming;

    public Boer(string naam, DateTime geboorteDatum, double aandeelInDeOnderneming) : base(naam, geboorteDatum)
    {
        AandeelInDeOnderneming = aandeelInDeOnderneming;
    }

    public double AandeelInDeOnderneming { get; set; }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
