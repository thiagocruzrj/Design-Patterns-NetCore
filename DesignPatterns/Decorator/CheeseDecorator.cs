namespace DesignPatterns.Decorator
{
    public sealed class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(Pizza pizza) : base(pizza)
        {
            Description = "cheese";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.25;
        }

        public override string GetDescription()
        {
            return $"{base.CalculateCost()}, {Description}";
        }
    }
}
