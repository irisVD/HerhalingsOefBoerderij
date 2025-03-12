using System;

namespace HerhOefBoerderij.Domein;

public class Persoon
{
    private string? _naam;
    public string Naam { get; set; }
    public readonly DateTime GeboorteDatum;
    public Persoon(string naam, DateTime geboorteDatum)
    {
        if(String.IsNullOrEmpty(naam) || String.IsNullOrWhiteSpace(naam))
            throw new ArgumentException("Naam mag niet leeg zijn!");
        else
            Naam = naam;

        // Check age
        int age = DateTime.Now.Year - geboorteDatum.Year;
        // Check if we're already past the persons birthday this year
        if(geboorteDatum.AddYears(18) > DateTime.Now)
            age--;
        if(age < 18)
            throw new ArgumentException("Persoon is nog geen 18 jaar!");
        else
            GeboorteDatum = geboorteDatum;
    }

    public override string ToString()
    {
        return String.Format("{0} {1} ({2})", this.GetType().Name, Naam, GeboorteDatum.ToString("yyyy/MM/dd"));
    }

    public int CompareTo(Persoon other)
    {
        // -1 is smaller than
        // 0 is equal
        // 1 is bigger than
        return this.Naam.CompareTo(other.Naam);
    }

    public virtual double BerekenLoonKost()
    {
        return 0.0;
    }
}
