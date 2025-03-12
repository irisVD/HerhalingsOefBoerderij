using System;
using System.Reflection.Metadata.Ecma335;
using HerhOefBoerderij.Domein;

namespace HerhOefBoerderij.Cui;

public class BoerderijApp
{
    public void Run(){
        Console.WriteLine("boerderij");
        Eigendom eigendom = new Akker("Achteraan", 200000, 4000, GewasEnum.Aardappel);
        Persoon persoon = new Persoon("Ben",DateTime.Parse("13-03-2019"));
        Boerderij boerderij = new Boerderij("boerderij1", "45349255647", new List<Persoon>{{persoon}}, new List<Eigendom>{{eigendom}});

        System.Console.WriteLine(eigendom);
    }
}
