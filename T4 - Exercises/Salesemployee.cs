namespace T4EX
{
    public class SalesEmployee : Employee
    {
        private static int _salesEmployeesCounter = 0;
        public int SalesCounter { get { return _salesEmployeesCounter; } }
        public double Commission { get; set; }

        public SalesEmployee(string code, string firstName, string lastName, string birthDate,
                        string hireDate, float monthSalary, int payments, double commission) :
                        base (code, firstName, lastName, birthDate, hireDate, monthSalary, payments)
        {
            Commission = commission;
            _employeesGeneralCounter++;
            _salesEmployeesCounter++;
        }

        public override string ToString()
        {
            return $">Code: {Code}\n" +
                   $">First name: {FirstName}\n" +
                   $">Last name: {LastName}\n" +
                   $">Full name: {FullName}\n" +
                   $">Reverse name: {ReverseName}ºn" +
                   $">Age: {Age}\n" +
                   $">Seniority: {Seniority}\n" +
                   $">Annual salary: {AnnualSalary}\n" +
                   $">Commission: {Commission}\n";
        }
    }
}
