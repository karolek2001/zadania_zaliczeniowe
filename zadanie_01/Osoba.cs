namespace zadanie_01
{
    internal class Osoba
    {
        private string imię;
        public string Nazwisko;
        public DateTime? DataUrodzenia = null;
        public DateTime? DataŚmierci = null;


        public Osoba(string imięNazwisko)
        {
            ImięNazwisko = imięNazwisko;
        }

        public string Imię
        {
            get => imię;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Imię nie może być puste!");
                }
                imię = value;
            }
        }

        public string ImięNazwisko
        {
            get
            {
                if (Nazwisko == null)
                    return imię;
                else
                    return $"{imię} {Nazwisko}";
            }
            set
            {
                string[] rozbicie = value.Split(' ');
                imię = rozbicie[0];
                if (rozbicie.Length > 1)
                    Nazwisko = rozbicie[^1];
                else
                    Nazwisko = null;
            }
        }

        public TimeSpan? Wiek
        {
            get
            {
                if (DataUrodzenia == null)
                {
                    return null;
                }

                var endDate = DataŚmierci ?? DateTime.Now;
                return endDate - DataUrodzenia;
            }
        }
    }
}