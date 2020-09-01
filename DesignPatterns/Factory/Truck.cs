namespace DesignPatterns.Factory
{
    public sealed class Truck : ITransport
    {
        public string Build()
        {
            return "Truck transport";
        }
    }
}