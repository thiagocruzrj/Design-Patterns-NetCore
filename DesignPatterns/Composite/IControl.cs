namespace DesignPatterns.Composite
{
    public interface IControl
    {
        int Id { get; set; }
        string Reader();
    }
}