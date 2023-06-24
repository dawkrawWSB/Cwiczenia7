namespace Cwiczenia7
{
    internal class FormatowanieCzasu
    {
        public FormatowanieCzasu()
        {
            Console.WriteLine(FormatujCzas(Pomocnik.DostanLiczbe<int>("Ilosc czasu w sekundach:", int.MaxValue, 1)));
        }

        public string FormatujCzas(int sekundy)
        {
            int godziny = sekundy / 3600;
            int minuty = (sekundy - (godziny * 3600)) / 60;
            int sekundyPozostale = sekundy - ((godziny * 3600) + (minuty * 60));
            return $"{godziny:00}:{minuty:00}:{sekundyPozostale:00}";
        }
    }
}
