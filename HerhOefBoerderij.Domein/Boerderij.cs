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
        throw new NotImplementedException();
    }
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
