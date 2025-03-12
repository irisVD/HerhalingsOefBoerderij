using System;

namespace HerhOefBoerderij.Domein;

public class Werknemer : Persoon
{
    public double BasisLoon { get; set; }
    public string WerknemersNummer { get; set; }
    public Werknemer(string naam, DateTime geboorteDatum) : base(naam, geboorteDatum)
    {
        BasisLoon = 0.0;
        WerknemersNummer = GenereerWerknemersNummer(naam);
    }

    public Werknemer(string naam, DateTime geboorteDatum, double loon) : base(naam, geboorteDatum)
    {
        BasisLoon = loon;
        WerknemersNummer = GenereerWerknemersNummer(naam);
    }

    public override string ToString()
    {
        return String.Format("{0} met nummer {1} kost {2}.", base.ToString(), WerknemersNummer, BerekenLoonKost());
    }

    public override double BerekenLoonKost()
    {
        return BasisLoon * 1.45;
    }

    private static string GenereerWerknemersNummer(string naam)
    {
        Random rd = new Random();
        return naam.Substring(0, 3) + DateTime.Now.ToString("yyyyMMdd") + rd.Next(100, 1001);
    }
}
