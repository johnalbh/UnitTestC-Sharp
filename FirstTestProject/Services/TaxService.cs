using FirstTestProject.Contracts;

namespace FirstTestProject.Services
{
    public class TaxService
    {
        private readonly IRangeRepository _rangeRepository;

        public TaxService(IRangeRepository rangeRepository)
        {
            _rangeRepository = rangeRepository;
        }
        public decimal GetTax(decimal grossSalary)
        {
            var percentage = _rangeRepository.GetRange(grossSalary).Percentage;
            return grossSalary / 100 * percentage;
        }
    }
}
