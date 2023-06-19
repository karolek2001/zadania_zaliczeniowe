namespace zadanie_05
{
    class Macierz<T> : IEquatable<Macierz<T>>
    {
        private T[,] dane;

        public Macierz(int liczbaWierszy, int liczbaKolumn)
        {
            dane = new T[liczbaWierszy, liczbaKolumn];
        }

        public T this[int wiersz, int kolumna]
        {
            get { return dane[wiersz, kolumna]; }
            set { dane[wiersz, kolumna] = value; }
        }

        public static bool operator ==(Macierz<T> macierz1, Macierz<T> macierz2)
        {
            if (ReferenceEquals(macierz1, macierz2))
                return true;

            if (ReferenceEquals(macierz1, null) || ReferenceEquals(macierz2, null))
                return false;

            if (macierz1.dane.GetLength(0) != macierz2.dane.GetLength(0) ||
                macierz1.dane.GetLength(1) != macierz2.dane.GetLength(1))
                return false;

            for (int i = 0; i < macierz1.dane.GetLength(0); i++)
            {
                for (int j = 0; j < macierz1.dane.GetLength(1); j++)
                {
                    if (!macierz1.dane[i, j].Equals(macierz2.dane[i, j]))
                        return false;
                }
            }

            return true;
        }

        public static bool operator !=(Macierz<T> macierz1, Macierz<T> macierz2)
        {
            return !(macierz1 == macierz2);
        }

        public bool Equals(Macierz<T> other)
        {
            return this == other;
        }

        public override bool Equals(object obj)
        {
            if (obj is Macierz<T>)
                return Equals((Macierz<T>)obj);

            return false;
        }

        public override int GetHashCode()
        {
            return dane.GetHashCode();
        }
    }
}