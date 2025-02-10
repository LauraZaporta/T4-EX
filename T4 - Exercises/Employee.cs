namespace T4EX
{
    public class Employee
    {
        protected static int _employeesGeneralCounter = 0;
        private static int _employeesCounter = 0;
        public static int Counter { get { return _employeesGeneralCounter; } }
        public static int CounterEmployees { get { return _employeesCounter; } }
        public int Age { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string ReverseName {  get; set; }
        public int Seniority { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public float MonthSalary { get; set; } = 1800;
        public float AnnualSalary { get; set; }
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
            AnnualSalary = MonthSalary * 12;
            Payments = payments;
            FullName = firstName + " " + lastName;
            ReverseName = new string(FullName.Reverse().ToArray());
            Age = ExtractAgeFromBirth(BirthDate);
            Seniority = ExtractSeniorityFromHire(HireDate);
            _employeesCounter++;
            _employeesGeneralCounter++;
        }
        public Employee(DateTime birthDate)
        {
            BirthDate = birthDate;
            Age = ExtractAgeFromBirth(BirthDate);
            _employeesCounter++;
        }

        public int ExtractAgeFromBirth(DateTime birthDate)
        {
            TimeSpan ageDifference = DateTime.Today.Subtract(birthDate.Date);
            return (int)(ageDifference.TotalDays / 365.25);
        }
        public int ExtractSeniorityFromHire(DateTime hireDate)
        {
            TimeSpan timeDifference = DateTime.Today.Subtract(hireDate.Date);
             return (int)(timeDifference.TotalDays); //Retorna els dies que s'han treballat
        }
        public override string ToString()
        {
            return $">Code: {Code}\n" +
                   $">First name: {FirstName}\n" +
                   $">Last name: {LastName}\n" +
                   $">Full name: {FullName}\n" +
                   $">Reverse name: {ReverseName}\n" +
                   $">Age: {Age}\n" +
                   $">Seniority: {Seniority}\n" +
                   $">Annual salary: {AnnualSalary}\n";
        }
    }
}
