using System;

public class Produkt
{
    public string Nazwa { get; set; }
    private decimal cenaNetto;
    public decimal CenaNetto
    {
        get { return cenaNetto; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Cena netto nie może być ujemna.");

            cenaNetto = value;
        }
    }

    private string kategoriaVAT;
    public virtual string KategoriaVAT
    {
        get { return kategoriaVAT; }
        set
        {
            // Tutaj można dodać walidację względem zbioru/kluczy słownika
            kategoriaVAT = value;
        }
    }

    public virtual decimal CenaBrutto => throw new NotImplementedException();

    public virtual string KrajPochodzenia => throw new NotImplementedException();
}