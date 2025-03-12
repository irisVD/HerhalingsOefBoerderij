using System;

namespace HerhOefBoerderij.Domein;

public class Boerderij
{
    public string Naam { get; set; }
    public string BTWNummer { get; set; }
    public List<Persoon> Personen { get; set; }
    public List<Eigendom> Eigendommen { get; set; }

    public Boerderij(string naam, string btwNummer, List<Persoon> personen, List<Eigendom> eigendommen)
    {
        Naam = naam;
        BTWNummer = btwNummer;
        Personen = personen;
        Eigendommen = eigendommen;
    }

    public double BerekenWinst()
    {
        double opbrengstEigendommen = Eigendommen.Aggregate(0.0, (acc, x) => acc + x.BerekenOpbrengst());
        double lonenPersonen = Personen.Aggregate(0.0, (acc, y) => acc + y.BerekenLoonKost());
        return opbrengstEigendommen - lonenPersonen;
    }
    public override string ToString()
    {
        return String.Format("{0} ({1}) met winst {2}.", Naam, BTWNummer, BerekenWinst());
    }
}
