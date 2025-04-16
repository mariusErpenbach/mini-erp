class Person{
    public required string Vorname {get;set;}
    public required string Nachname {get;set;}
    public required string Email {get;set;}
    public string VollerName => $"{Vorname} {Nachname}";
    
}