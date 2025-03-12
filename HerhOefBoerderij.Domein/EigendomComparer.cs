using System;

namespace HerhOefBoerderij.Domein;

public class EigendomComparer
{
    public int Compare(Eigendom x, Eigendom y){
        // check if name is equal
        return x.Naam.CompareTo(y.Naam);
    }
}
