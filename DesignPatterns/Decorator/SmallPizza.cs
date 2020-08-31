namespace DesignPatterns.Decorator
{
    public class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            Description = "Small pizza";
        }
        public override double CalculateCost()
        {
            return 20.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}