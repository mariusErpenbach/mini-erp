class Kunde : Person
{
    public required string Kundennummer {get;set;}
    public void Begrüßen(){
        Console.WriteLine($"Hallo {VollerName} (Kundennr:{Kundennummer}) ");
    }
}