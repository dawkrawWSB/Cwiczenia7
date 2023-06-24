namespace Cwiczenia7
{
    internal class ZblizoneWiersze
    {
        public ZblizoneWiersze()
        {
            int[,] tablica = { { 1, 2, 3, 4, }, { 10, 11, 12, 13 }, { 20, 21, 22, 23, }, { 21, 22, 23, 24, } };
            ZnajdzPodobneWierszeWTablicy(tablica, out int numerWiersz1, out int numerWiersza2);
            Console.WriteLine($"Podobne wiersze to: {numerWiersz1} i {numerWiersza2} (liczac od zera)");
        }

        public void ZnajdzPodobneWierszeWTablicy(int[,] tablica, out int numerWiersza1, out int numerWiersza2) 
        {
            numerWiersza1 = numerWiersza2 = 0;
            double najmniejszaRoznica = double.MaxValue;

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = i+1; j < tablica.GetLength(0); j++)
                {
                    double roznica = RoznicaDwochWierszy(tablica, i, j);
                    PrzypiszJezeliMniejszaRoznica(ref numerWiersza1, ref numerWiersza2, ref najmniejszaRoznica, i, j, roznica);
                }
            }
        }

        private static void PrzypiszJezeliMniejszaRoznica(ref int numerWiersza1, ref int numerWiersza2, ref double najmniejszaRoznica, int i, int j, double roznica)
        {
            if (roznica < najmniejszaRoznica)
            {
                numerWiersza1 = i;
                numerWiersza2 = j;
                najmniejszaRoznica = roznica;
            }
        }

        public double RoznicaDwochWierszy(int[,] tablica, int wiersz1, int wiersz2) 
        {
            double roznica = default;
            for(int i = 0;i < tablica.GetLength(1); i++)
            {
                roznica += Math.Pow(tablica[wiersz1, i] - tablica[wiersz2, i], 2);
            }
            return roznica;
        }
    }
}
