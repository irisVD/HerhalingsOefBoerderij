using System;
using System.Reflection.Metadata.Ecma335;
using HerhOefBoerderij.Domein;

namespace HerhOefBoerderij.Cui;

public class BoerderijApp
{
    public void Run(){
        Console.WriteLine("boerderij");
        Eigendom akker = new Akker("Achteraan", 200000, 4000, GewasEnum.Aardappel);
        Persoon boer = new Boer("Ben",DateTime.Parse("06-09-2003"), 15.99);
        Persoon persoon = new Persoon("Bert",DateTime.Parse("05-03-2001"));
        Boerderij boerderij = new Boerderij("boerderij1", "BE45349255647", new List<Persoon>{{boer}}, new List<Eigendom>{{akker}});

        System.Console.WriteLine(akker);

        Eigendom melkerij = new Melkerij("Melkerij1", 1200, 13);
        System.Console.WriteLine("Opbrengst melkerij: " + melkerij.BerekenOpbrengst());

        System.Console.WriteLine("Opbrengst akker: " + akker.BerekenOpbrengst());

        System.Console.WriteLine(persoon);
        System.Console.WriteLine(boer);

        Persoon werknemer = new Werknemer("Samaël", DateTime.Parse("02-08-1990"));
        System.Console.WriteLine(werknemer);

        System.Console.WriteLine(boerderij);
    }
}
