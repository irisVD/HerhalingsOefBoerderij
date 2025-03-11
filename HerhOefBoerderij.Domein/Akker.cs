using System;

namespace HerhOefBoerderij.Domein;

public class Akker : Eigendom
{
    public Akker(string naam, double kost, double oppervlaketeM2, GewasEnum gewas) : base(naam, kost)
    {
        OppervlakteM2 = oppervlaketeM2;
        Gewas = gewas;
    }

    public double OppervlakteM2 { get; set; }
    public GewasEnum Gewas { get; set; }

    public override double BerekenOpbrengst(){
        throw new NotImplementedException();
    }
}
