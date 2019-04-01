namespace Company_OOP.CompanyDAL.EmployeeModels
{
    public class Designer : Employee
    {
        private decimal _effectivnessCoefficient;
        public decimal EffectivnessCoefficient
        {
            // Value of coeff can set only between 0 and 1
            set
            {
                if (value <= 0 || value > 1)
                    return;

                _effectivnessCoefficient = value;
            }
            get { return _effectivnessCoefficient; }
        }
    }
}
