public class Wielopak : Produkt
{
    public Produkt Produkt { get; set; }
    public ushort Ilość { get; set; }
    public decimal CenaNetto { get; set; }

    public override decimal CenaBrutto
    {
        get
        {
            // Implementacja wyliczania ceny brutto dla wielopaku
            return Produkt.CenaBrutto * Ilość;
        }
    }

    public override string KategoriaVAT
    {
        get { return Produkt.KategoriaVAT; }
        set { Produkt.KategoriaVAT = value; }
    }

    public override string KrajPochodzenia => Produkt.KrajPochodzenia;
}