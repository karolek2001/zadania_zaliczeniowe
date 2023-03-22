using zadanie_03;

Wektor w1 = new Wektor(5, 1, 5);
Wektor w2 = new Wektor(8, 1, 5);
Wektor w3 = new Wektor(1, 2, 3);

var suma = w1 + w2 + w3;
var suma_różnica = w1 - w2 + w3;

Console.WriteLine("Iloczyn skalarny wynosi: " + Wektor.IloczynSkalarny(w1, w2));
Console.WriteLine("Suma wynosi: " + suma_różnica.Format);