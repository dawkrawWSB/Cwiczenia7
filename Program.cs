using Cwiczenia7;
using System.Numerics;

List<Type> zadania = new List<Type> { typeof(FormatowanieCzasu), typeof(DlugoscOdcinka), typeof(ZblizoneWiersze) };

Type? zadanieWybrane = null;
do
{
    Console.WriteLine("Wybierz zadanie wpisujac numer i klikajac enter:");
    foreach (Type zadanie in zadania)
    {
        Console.WriteLine($"{zadania.IndexOf(zadanie)} - {zadanie.Name}");
    }
    string? input = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int result))
    {
        zadanieWybrane = zadania.ElementAtOrDefault(result);
    }
} while (zadanieWybrane == null);

Activator.CreateInstance(zadanieWybrane);

namespace Cwiczenia7
{
    internal class Pomocnik
    {
        public static T DostanLiczbe<T>(string tekst, T limitGorny, T limitDolny) where T : INumber<T>, IMinMaxValue<T>
        {
            T result;
            int liczbaProb = 0;
            string? input;
            do
            {
                Console.WriteLine(tekst);
                input = Console.ReadLine();
                liczbaProb++;
            } while ((!T.TryParse(input, null, out result) || (result >= limitGorny || result <= limitDolny)));
            return result;
        }
    }
}

