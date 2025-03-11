using System;

namespace HerhOefBoerderij.Domein;

public class Werknemer : Persoon
{
    public double BasisLoon { get; set; }
    public string WerknemersNummer { get; set; }
    public Werknemer(string naam, DateTime geboorteDatum) : base(naam, geboorteDatum)
    {
    }

    public Werknemer(string naam, DateTime geboorteDatum, double loon) : base(naam, geboorteDatum)
    {
        BasisLoon = loon;
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }

    public override double BerekenLoonKost()
    {
        throw new NotImplementedException();
    }

    private static string GenereerWerknemersNummer(string naam)
    {
        throw new NotImplementedException();
    }
}
