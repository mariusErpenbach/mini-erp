using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Kunde kunde = new Kunde{ 
            Vorname="Oliver",
            Nachname="Prollinger",
            Email="kontakt@erp-it.net",
            Kundennummer = "K-1001"
        };

        Artikel tastatur = new Artikel {Artikelnummer = "A001", Bezeichnung = "Tastatur", Preis=119.00m};
        Artikel maus = new Artikel {Artikelnummer = "A001", Bezeichnung = "Maus", Preis=39m};
    
        Bestellung bestellung = new Bestellung{
            Bestellnummer = "B-2025-001",
            Besteller = kunde,
            ArtikelListe = new List<Artikel> {tastatur, maus}
        };
        
        kunde.Begrüßen();
        bestellung.DruckeBeleg();
        
    }
}
