using FirstTestProject.Entities;

namespace FirstTestProject.Contracts
{
    public interface IRangeRepository
    {
        Range GetRange(decimal grossSalary);

    }
}
