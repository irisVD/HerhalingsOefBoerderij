using System;
using HerhOefBoerderij.Cui;

namespace HerhOefBoerderij.StartUp;

public class Program
{
    public static void Main(string[] args){
        BoerderijApp boerderijApp= new BoerderijApp();
        boerderijApp.Run();
    }
}
