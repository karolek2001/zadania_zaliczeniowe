namespace zadanie_02
{
    class Prostokąt
    {
        private double bokA, bokB;
        public Prostokąt(double bokA, double bokB)
        {
            this.BokA = bokA;
            this.BokB = bokB;
        }

        public double BokA
        {
            get
            {
                return bokA;
            }
            set
            {
                if (double.IsNaN(value) || double.IsInfinity(value) || value < 0)
                {
                    throw new ArgumentException("Bok A nie jest skończoną nieujemną liczbą: " + value);
                }
                bokA = value;    
            }
        }

        public double BokB
        {
            get
            {
                return bokB;
            }
            set
            {
                if (double.IsNaN(value) || double.IsInfinity(value) || value < 0)
                {
                    throw new ArgumentException("Bok B nie jest skończoną nieujemną liczbą: " + value);
                }
                bokB = value;  
            }
        }

        public static readonly Dictionary<char, double>
            wysokośćArkusza0 = new()
            {
                ['A'] = 1189,
                ['B'] = 1414,
                ['C'] = 1297
            };

        public static Prostokąt ArkuszPapieru(string Xi)
        {
            if (Xi.Length < 2 || string.IsNullOrEmpty(Xi))
            {
                throw new ArgumentException("Nieprawidłowy format arkusza papieru.");
            }


            char X = Convert.ToChar(Xi.Substring(0,1));
            byte i = byte.Parse(Xi.Substring(1));

            if (!wysokośćArkusza0.ContainsKey(X))
            {
                throw new ArgumentException("Nieprawidłowy klucz formatu arkusza papieru.");
            }

            double wysokość = wysokośćArkusza0[X];
            double pierwiastekZDwóch = Math.Sqrt(2);

            double bokA = wysokość / Math.Pow(pierwiastekZDwóch, i);
            double bokB = bokA / pierwiastekZDwóch;
            
            return new Prostokąt(bokA, bokB);
        }
    }
}