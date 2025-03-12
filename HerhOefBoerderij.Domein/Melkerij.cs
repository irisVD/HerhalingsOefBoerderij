using System;

namespace HerhOefBoerderij.Domein;

public class Melkerij : Eigendom
{
    public readonly int AantalKoeien;
    public Melkerij(string naam, double kost, int aantalKoeien) : base(naam, kost)
    {
        AantalKoeien = aantalKoeien;
    }

    public override double BerekenOpbrengst()
    {
        return (AantalKoeien * 300) - base.Kost;
    }
}
