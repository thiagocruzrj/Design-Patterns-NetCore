namespace DesignPatterns.Decorator
{
    public class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(Pizza pizza) : base(pizza)
        {
            Description = "tomato";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 0.25;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {Description}";
        }
    }
}