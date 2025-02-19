using System.Text;

namespace T4EX
{
    public class Employee
    {
        private static int _employeesCounter = 0;
        public static int CounterEmployees { get { return _employeesCounter; } }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public float MonthSalary { get; set; } = 1800;
        public int Payments { get; set; } = 14;

        public Employee(string code, string firstName, string lastName, string birthDate,
                        string hireDate, float monthSalary, int payments)
        {
            Code = code;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = DateTime.ParseExact(hireDate, "dd/MM/yyyy", null);
            HireDate = DateTime.ParseExact(birthDate, "dd/MM/yyyy", null);
            MonthSalary = monthSalary;
            Payments = payments;
            _employeesCounter++;
        }
        public Employee(DateTime birthDate)
        {
            BirthDate = birthDate;
            _employeesCounter++;
        }

        public string doReverseName() { return new string(doFullName().Reverse().ToArray()); }
        public string doFullName() { return $"{FirstName} {LastName}"; }
        public double doAnnualSalary() { return MonthSalary * 12; }
        public int ExtractSeniorityFromHire()
        {
            TimeSpan timeDifference = DateTime.Today.Subtract(HireDate.Date);
            return (int)(timeDifference.TotalDays); //Retorna els dies que s'han treballat
        }
        public int ExtractAgeFromBirth()
        {
            TimeSpan ageDifference = DateTime.Today.Subtract(BirthDate.Date);
            return (int)(ageDifference.TotalDays / 365.25);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("------------------------------------------------------------------------------------------------" +
                "-----\r\n                           E M P L O Y E E / S A L E S E M P L O Y E E\r\n-------------------" +
                "----------------------------------------------------------------------------------\n");
            sb.Append($">Code: {Code}\n");
            sb.Append($">First name: {FirstName}\n");
            sb.Append($">Last name: {LastName}\n");
            sb.Append($">Full name: {doFullName()}\n");
            sb.Append($">Reverse name: {doReverseName()}\n");
            sb.Append($">Age: {ExtractAgeFromBirth()}\n");
            sb.Append($">Seniority: {ExtractSeniorityFromHire}\n");
            sb.Append($">Annual salary: {doAnnualSalary}\n");
            return sb.ToString();
        }
    }
}
