namespace DesignPatterns.Proxy
{
    public class CalcProxy : ICalc
    {
        private User _user;
        private Calc _calc;

        public CalcProxy(User user)
        {
            _user = user;
            _calc = new Calc();
        }

        public string Message { get; set; }

        public double Calculate()
        {
            var age = 18;

            if(_user.Age < age)
            {
                Message = $"Must be greater than {age}";
                return 0;
            }

            return _calc.Calculate();
        }
    }
}