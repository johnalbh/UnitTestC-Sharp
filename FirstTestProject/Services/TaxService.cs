namespace FirstTestProject.Services
{
    public class TaxService
    {
        public decimal GetTax(decimal grossSalary)
        {
            if (grossSalary < 10000)
            {
                return 1000;
            }

            return 2000;
        }
    }
}
