using zadanie_01;
using static System.Console;

var o1 = new Osoba("Karol Lewandowski");
o1.Imię = "Karol";
o1.DataUrodzenia = new DateTime(2001, 10, 25);
o1.DataŚmierci = new DateTime(2050, 10, 25);

Console.WriteLine($"Imię: {o1.Imię}");
Console.WriteLine($"Nazwisko: {o1.Nazwisko}");
Console.WriteLine($"Imię i nazwisko: {o1.ImięNazwisko}");
Console.WriteLine($"Twój wiek: {Convert.ToInt16(o1.Wiek?.TotalDays / 365)} lat");