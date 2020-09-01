namespace DesignPatterns.Proxy
{
    public class Calc : ICalc
    {
        public string Message { get; set; }

        public double Calculate()
        {
            Message = "Calculated";
            return 32 * 9;
        }
    }
}