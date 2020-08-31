namespace DesignPatterns.Composite
{
    public class Control : IControl
    {
        public int Id { get; set; }

        public string Reader()
        {
            return $"Control {Id}";
        }
    }
}