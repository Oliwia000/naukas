namespace naukas
{
    public partial class MainPage : ContentPage
    {
        // Lista pytań
        List<Pytanie> Pytania = new List<Pytanie>
        {
           new Pytanie { pytanie = "Ptak", odpowiedz = "bird"},
           new Pytanie { pytanie = "szczęśliwy", odpowiedz = "happy"},
           new Pytanie { pytanie = "zmęczony", odpowiedz = "tired "},
           new Pytanie { pytanie = "Broda", odpowiedz = "beard"},
           new Pytanie { pytanie = "Samolot", odpowiedz = "plane"},
           new Pytanie { pytanie = "Samochód", odpowiedz = "car"},
           new Pytanie { pytanie = "Śmieszny", odpowiedz = "funny"},
           new Pytanie { pytanie = "Czemu", odpowiedz = "why"},
           new Pytanie { pytanie = "Wybuch", odpowiedz = "explosion"},
           new Pytanie { pytanie = "Dom", odpowiedz = "house"},
           new Pytanie { pytanie = "Jedzenie", odpowiedz = "food"},
           new Pytanie { pytanie = "Kot", odpowiedz = "cat"},
           new Pytanie { pytanie = "Koń", odpowiedz = "horse"},
           new Pytanie { pytanie = "Jedzenie", odpowiedz = "food"},
           new Pytanie { pytanie = "Pociąg", odpowiedz = "train"},
           new Pytanie { pytanie = "Drzewo", odpowiedz = "tree"},
           new Pytanie { pytanie = "Gwiazda", odpowiedz = "star"},
           new Pytanie { pytanie = "Papuga", odpowiedz = "parrot"},
           new Pytanie { pytanie = "Księżyc", odpowiedz = "moon"},
           new Pytanie { pytanie = "Koc", odpowiedz = "blanket"},
           new Pytanie { pytanie = "Mózg", odpowiedz = "brain"},
           new Pytanie { pytanie = "Zły", odpowiedz = "bad"},
           new Pytanie { pytanie = "Róg", odpowiedz = "corner"},
           new Pytanie { pytanie = "Hamulec", odpowiedz = "brake"},
           new Pytanie { pytanie = "Galaretka", odpowiedz = "jelly"},
           new Pytanie { pytanie = "Spiżarnia", odpowiedz = "pantry"},
           new Pytanie { pytanie = "Potomek", odpowiedz = "descendant"},
           new Pytanie { pytanie = "Wielkanoc", odpowiedz = "Easter"},


        };

        int zycia = 3; // Ilość żyć
        int tlumacz = 0; // Ilość przetłumaczonych słów
        Pytanie aktualnePytanie;

        public MainPage()
        {
            InitializeComponent();
            NastepnePytanie(); // Zainicjowanie pierwszego pytania
        }

        // Funkcja losująca następne pytanie
        void NastepnePytanie()
        {
            Random random = new Random();
            int indeks = random.Next(Pytania.Count); // Losowanie indeksu pytania

            aktualnePytanie = Pytania[indeks]; // Pobranie pytania
            pytanie.Text = aktualnePytanie.pytanie; // Ustawienie tekstu pytania
        }

        // Sprawdzanie odpowiedzi po kliknięciu przycisku
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Answer.Text.ToLower().Trim() == aktualnePytanie.odpowiedz.ToLower()) // Sprawdzenie poprawności odpowiedzi
            {
                tlumacz++; // Zwiększenie licznika poprawnych odpowiedzi
                tlum.Text = $"Przetłumaczone: {tlumacz}";

                Answer.Text = ""; // Wyczyszczenie pola odpowiedzi

                DisplayAlert("Dobrze!", "Poprawna odpowiedź!", "OK");

                NastepnePytanie(); 
            }
            else
            {
                zycia--; // Zmniejszenie liczby żyć
                live.Text = $"Życia: {zycia}";

                if (zycia <= 0) // Sprawdzenie, czy życie się skończyło
                {
                    DisplayAlert("Konic", "Niestyty przegrałeś/aś. Przetłumacz poprawnie jak najwięcej słów.", "OK");

                    // Resetowanie stanu gry
                    tlumacz = 0;
                    zycia = 3;

                    live.Text = $"Życia: {zycia}";
                    tlum.Text = $"Przetłumaczone: {tlumacz}";
                    Answer.Text = "";
                }
                else
                {
                    DisplayAlert("Niedobrze!", $"to nie jest poprawna odpowiedź.Poprawna odpowiedz to {aktualnePytanie.odpowiedz}. Pozostało Ci : {zycia} życia!", "OK");
                }
            }
        }
    }

    // Klasa Pytanie
    public class Pytanie
    {
        public string pytanie { get; set; }
        public string odpowiedz { get; set; }
    }
}
