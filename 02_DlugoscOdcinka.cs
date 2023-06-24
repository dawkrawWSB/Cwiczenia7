namespace Cwiczenia7
{
    internal class DlugoscOdcinka
    {
        public DlugoscOdcinka()
        {
            double x1 = Pomocnik.DostanLiczbe<double>("x1:", double.MaxValue, double.MinValue);
            double y1 = Pomocnik.DostanLiczbe<double>("y1:", double.MaxValue, double.MinValue);
            double x2 = Pomocnik.DostanLiczbe<double>("x2:", double.MaxValue, double.MinValue);
            double y2 = Pomocnik.DostanLiczbe<double>("y2:", double.MaxValue, double.MinValue);
            Console.WriteLine($"Dlugosc to {ObliczDlugoscOdcinka(x1, y1, x2, y2)}");
        }

        public double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
        {
            double dlugosciX = Math.Pow(x2 - x1, 2);
            double dlugosciY = Math.Pow(y2 - y1, 2);
            return Math.Sqrt(dlugosciX + dlugosciY);
        }
    }
}
