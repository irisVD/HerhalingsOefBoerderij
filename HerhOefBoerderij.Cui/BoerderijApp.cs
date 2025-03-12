using System;
using System.Reflection.Metadata.Ecma335;
using HerhOefBoerderij.Domein;

namespace HerhOefBoerderij.Cui;

public class BoerderijApp
{
    public void Run(){
        Console.WriteLine("boerderij");
        Eigendom akker = new Akker("Achteraan", 200000, 4000, GewasEnum.Aardappel);
        Persoon persoon = new Persoon("Ben",DateTime.Parse("13-03-2019"));
        Boerderij boerderij = new Boerderij("boerderij1", "45349255647", new List<Persoon>{{persoon}}, new List<Eigendom>{{akker}});

        System.Console.WriteLine(akker);

        Eigendom melkerij = new Melkerij("Melkerij1", 1200, 13);
        System.Console.WriteLine("Opbrengst melkerij: " + melkerij.BerekenOpbrengst());

        System.Console.WriteLine("Opbrengst akker: " + akker.BerekenOpbrengst());
    }
}
