using System;
using System.Collections.Generic;

public class ProduktSpożywczy : Produkt
{
    public decimal Kalorie { get; set; }
    public HashSet<string> Alergeny { get; set; }

    public override decimal CenaBrutto
    {
        get
        {
            // Implementacja wyliczania ceny brutto dla produktu spożywczego
            decimal vat = ObliczVAT();
            return CenaNetto + (CenaNetto * vat);
        }
    }

    private decimal ObliczVAT()
    {
        // Implementacja obliczania stawki VAT dla produktu spożywczego
        // W tym przykładzie przyjmujemy stałą stawkę VAT na poziomie 23%
        return 0.23m;
    }
}
