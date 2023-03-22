namespace zadanie_03
{
    internal class Wektor
    {

        public string Format
            => $"({string.Join(", ", współrzędne)})";
    
        private readonly double[] współrzędne;

        public Wektor(byte wymiar)
        {
            współrzędne = new double[wymiar];
        }
        public Wektor(params double[] współrzędne)
        {
            foreach (double współrzędna in współrzędne)
                if (!double.IsFinite(współrzędna))
                    throw new ArgumentException(
                        $"value was {współrzędna} but should be finite"
                        );
            this.współrzędne = (double[])współrzędne.Clone();
        }
        public byte Wymiar => (byte)współrzędne.Length;

        public double this[byte indeks]
        {
            get => współrzędne[indeks];
            set
            {
                if (double.IsFinite(value))
                    współrzędne[indeks] = value;
                else
                    throw new ArgumentException(
                        $"value was {value} but should be finite"
                        );
            }
        }

        public static double IloczynSkalarny(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
            {
                return double.NaN;
            }

            double iloczyn_skalarny=0;
            for (byte i = 0; i < V.Wymiar; i++)
            {
                iloczyn_skalarny += V.współrzędne[i] * V.współrzędne[i];
            }
            return iloczyn_skalarny;
        }

        public static Wektor Suma(params Wektor[] wektory)
        {
            byte wymiar = wektory[0].Wymiar;

            foreach (Wektor w in wektory)
            {
                if (w.Wymiar != wymiar)
                {
                    throw new ArgumentException("Wektory muszą mieć taki sam wymiar.");
                }
            }

            double[] wspolrzedneSumy = new double[wymiar];
            foreach (Wektor w in wektory)
            {
                for (byte i = 0; i < wymiar; i++)
                {
                    wspolrzedneSumy[i] += w[i];
                }
            }

            return new Wektor(wspolrzedneSumy);
        }

        public static Wektor operator +(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
            {
                throw new ArgumentException("Wektory muszą mieć taki sam wymiar.");
            }

            Wektor suma = new Wektor(V.Wymiar);

            for (byte i = 0; i < V.Wymiar; i++)
            {
                suma[i] = V[i] + W[i];
            }

            return suma;
        }

        public static Wektor operator -(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
            {
                throw new ArgumentException("Wektory muszą mieć taki sam wymiar.");
            }

            double[] wspołrzędneRóżnicy = new double[V.Wymiar];
            for (byte i = 0; i < V.Wymiar; i++)
            {
                wspołrzędneRóżnicy[i] = V[i] - W[i]; 
            }

            return new(wspołrzędneRóżnicy);
        }
    }
}