namespace Company_OOP.Reports
{
    public class SalaryReport : ISalaryReport
    {
        private string _firstName;
        public string FirstName { get; set; }

        private string _secondName;
        public string SecondName { get; set; }

        private decimal _fullSalary;
        public decimal FullSalary { get; set; }

        public SalaryReport(string firstName, string secondName, decimal fullSalary)
        {
            FirstName = firstName;
            SecondName = secondName;
            FullSalary = fullSalary;
        }
    }
}
