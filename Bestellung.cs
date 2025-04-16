using System;
using System.Collections.Generic;
using System.Linq;

class Bestellung
{
    public required string Bestellnummer {get;set;}
    public required Kunde Besteller {get;set;}
    public List<Artikel> ArtikelListe {get;set;} = new();

    public decimal Gesamtpreis => ArtikelListe.Sum(a=>a.Preis);
    public void DruckeBeleg(){
        Console.WriteLine($"\n Bestellbeleg {Bestellnummer} für {Besteller.VollerName}");
        foreach (var artikel in ArtikelListe){
            Console.WriteLine($" - {artikel.Bezeichnung} ({artikel.Artikelnummer}): {artikel.Preis}€");
        }
        Console.WriteLine($"Gesamtpreis: {Gesamtpreis} € \n");
    }
}