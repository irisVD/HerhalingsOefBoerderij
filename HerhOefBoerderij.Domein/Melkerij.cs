using System;

namespace HerhOefBoerderij.Domein;

public class Melkerij : Eigendom
{
    public int AantalKoeien { get; set; }
    public Melkerij(string naam, double kost, int aantalKoeien) : base(naam, kost)
    {
        AantalKoeien = aantalKoeien;
    }

    public override double BerekenOpbrengst()
    {
        throw new NotImplementedException();
    }
}
