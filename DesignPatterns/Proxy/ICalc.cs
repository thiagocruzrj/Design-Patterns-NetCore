namespace DesignPatterns.Proxy
{
    public interface ICalc
    {
        double Calculate();
        string Message { get; set; }
    }
}