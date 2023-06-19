using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        ProduktSpożywczy jabłko = new ProduktSpożywczy
        {
            Nazwa = "Jabłko",
            CenaNetto = 2.50m,
            KategoriaVAT = "A",
            Kalorie = 52,
            Alergeny = new HashSet<string> { "Orzechy" }
        };

        Wielopak wielopakJabłek = new Wielopak
        {
            Produkt = jabłko,
            Ilość = 6,
            CenaNetto = 14.50m
        };

        Console.WriteLine($"Produkt: {jabłko.Nazwa}");
        Console.WriteLine($"Cena netto: {jabłko.CenaNetto} zł");
        Console.WriteLine($"Cena brutto: {jabłko.CenaBrutto} zł");
        Console.WriteLine($"Kategoria VAT: {jabłko.KategoriaVAT}");
        Console.WriteLine($"Kraj pochodzenia: {jabłko.KrajPochodzenia}");
        Console.WriteLine($"Kalorie: {jabłko.Kalorie}");
        Console.WriteLine($"Alergeny: {string.Join(", ", jabłko.Alergeny)}");
        Console.WriteLine();

        Console.WriteLine($"Wielopak: {wielopakJabłek.Produkt.Nazwa}");
        Console.WriteLine($"Ilość: {wielopakJabłek.Ilość}");
        Console.WriteLine($"Cena netto: {wielopakJabłek.CenaNetto} zł");
        Console.WriteLine($"Cena brutto: {wielopakJabłek.CenaBrutto} zł");
        Console.WriteLine($"Kategoria VAT: {wielopakJabłek.KategoriaVAT}");
        Console.WriteLine($"Kraj pochodzenia: {wielopakJabłek.KrajPochodzenia}");

        Console.ReadLine();
    }
}