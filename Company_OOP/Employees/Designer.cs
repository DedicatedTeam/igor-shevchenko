namespace Company_OOP.Employees
{
    public class Designer : Employee
    {
        private double _effectivnessCoefficient;
        public double EffectivnessCoefficient
        {
            // Value of coeff can set only between 0 and 1
            set
            {
                if (value < 0 || value > 1)
                    return;

                _effectivnessCoefficient = value;
            }
            get { return _effectivnessCoefficient; }
        }
    }
}
