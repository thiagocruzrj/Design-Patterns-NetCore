namespace DesignPatterns.Factory
{
    public sealed class Bus : ITransport
    {
        public string Build()
        {
            return "Bus transport";
        }
    }
}