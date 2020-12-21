using System;
using FirstTestProject.Repository;
using FirstTestProject.Services;

namespace FirstTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salario bruto anual: ");
            var grossStr = Console.ReadLine();
            if (!Decimal.TryParse(grossStr, out decimal gross))
            {
                Console.WriteLine("No es un valor vádñio. Pulsa enter para salir");
                Console.ReadLine();
                return;;
            }

            var taxService = new TaxService(new RangeRepository());
            Console.WriteLine($"Vas a pagar {taxService.GetTax(gross)}.");
            Console.Read();
        }
    }
}
