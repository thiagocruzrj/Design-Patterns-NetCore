namespace DesignPatterns.Flyweight
{
    public sealed class Button : Control
    {
        public Button()
        {
            Tag = Tags.Button;
        }

        public override string Create(string text)
        {
            return $"<input type='button' value='{text}' /> => {text}";
        }
    }
}