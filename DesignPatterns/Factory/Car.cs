namespace DesignPatterns.Factory
{
    public sealed class Car : ITransport
    {
        public string Build()
        {
            return "Car transport";
        }
    }
}