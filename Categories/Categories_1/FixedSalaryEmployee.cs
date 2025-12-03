using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Categories_1
{
    public class FixedSalaryEmployee : Employee   // Месячная оплата
    {
        public decimal MonthlySalary; // Доп.свойство - месячный оклад
        public override decimal CalculateSalary() // Расчет зарплаты
        {
            return MonthlySalary; // Возврат оклада
        }
    }
}
