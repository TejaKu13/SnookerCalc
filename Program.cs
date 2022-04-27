using System;

namespace SnookerCalc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj ilość czerwonych bil na stole-od 0 do 15:");
            int tableReds=int.Parse(Console.ReadLine());
            Partia partia = new Partia(tableReds);
            partia.ObliczPunkty(tableReds);
        }
    }
}
