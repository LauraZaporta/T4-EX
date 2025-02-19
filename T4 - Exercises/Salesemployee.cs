using System.Text;

namespace T4EX
{
    public class SalesEmployee : Employee
    {
        private static int _salesEmployeesCounter = 0;
        public static int SalesCounter { get { return _salesEmployeesCounter; } }
        public double Commission { get; set; }

        public SalesEmployee(string code, string firstName, string lastName, string birthDate,
                        string hireDate, float monthSalary, int payments, double commission) :
                        base (code, firstName, lastName, birthDate, hireDate, monthSalary, payments)
        {
            Commission = commission;
            _salesEmployeesCounter++;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($">Comission: {Commission}");
            return sb.ToString();
        }
    }
}
