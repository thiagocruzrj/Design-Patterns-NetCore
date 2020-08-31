﻿namespace DesignPatterns.Decorator
{
    public abstract class PizzaDecorator : Pizza
    {
        private Pizza _pizza;

        protected PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }
    }
}