using zadanie_05;

Macierz<int> macierz1 = new Macierz<int>(2, 2);
macierz1[0, 0] = 1;
macierz1[0, 1] = 2;
macierz1[1, 0] = 3;
macierz1[1, 1] = 4;

Macierz<int> macierz2 = new Macierz<int>(2, 2);
macierz2[0, 0] = 1;
macierz2[0, 1] = 2;
macierz2[1, 0] = 3;
macierz2[1, 1] = 4;

Macierz<int> macierz3 = new Macierz<int>(2, 2);
macierz3[0, 0] = 1;
macierz3[0, 1] = 2;
macierz3[1, 0] = 3;
macierz3[1, 1] = 5;

Console.WriteLine(macierz1 == macierz2);  // true
Console.WriteLine(macierz1 != macierz2);  // false
Console.WriteLine(macierz1 == macierz3);  // false
Console.WriteLine(macierz1 != macierz3);  // true