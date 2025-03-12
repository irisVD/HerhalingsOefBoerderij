using System;
using System.Collections;

namespace HerhOefBoerderij.Domein;

public class Akker : Eigendom
{
    public Akker(string naam, double kost, double oppervlaketeM2, GewasEnum gewas) : base(naam, kost)
    {
        if (oppervlaketeM2 <= 0)
            throw new ArgumentException();
        else
            OppervlakteM2 = oppervlaketeM2;
        OppervlakteM2 = oppervlaketeM2;
        Gewas = gewas;
    }

    public readonly double OppervlakteM2;
    public GewasEnum Gewas { get; set; }

    public override double BerekenOpbrengst()
    {
        switch (Gewas)
        {
            case GewasEnum.Aardappel:
                return OppervlakteM2 * 0.32;
            case GewasEnum.Prei:
                return OppervlakteM2 * 0.32;
            case GewasEnum.Hop:
                return OppervlakteM2 * 0.32;
        }
        throw new Exception("Gewas bestaat niet.");
    }
}
