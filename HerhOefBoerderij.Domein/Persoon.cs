using System;

namespace HerhOefBoerderij.Domein;

public class Persoon
{
    private string? _naam;
    public string Naam { get; set; }
    public DateTime GebooreDatum { get; set; }
    public Persoon(string naam, DateTime geboorteDatum)
    {
        Naam = naam;
        GebooreDatum = geboorteDatum;
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }

    public int CompareTo(Persoon other)
    {
        throw new NotImplementedException();
    }

    public virtual double BerekenLoonKost()
    {
        throw new NotImplementedException();
    }
}
