using System;

namespace HerhOefBoerderij.Domein;

public class Boer : Persoon
{
    private double _aandeelInDeOnderneming;

    public Boer(string naam, DateTime geboorteDatum, double aandeelInDeOnderneming) : base(naam, geboorteDatum)
    {
        if(aandeelInDeOnderneming<0 || aandeelInDeOnderneming>100)
            throw new ArgumentException("Aandeel in de onderneming moet tussen 0 en 100 liggen.");
        else
            AandeelInDeOnderneming = aandeelInDeOnderneming;
    }

    public double AandeelInDeOnderneming { get; set; }

    public override string ToString()
    {
        return String.Format("{0} bezit {1}% van de onderneming.", base.ToString(), AandeelInDeOnderneming);
    }
}
