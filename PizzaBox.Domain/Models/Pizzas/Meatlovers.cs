using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Pizzas
{
    public class Meatlovers : APizza
    {
        public override void AddCrust(Crust crust)
        {
            Crust = new Crust() { name = "Original", price = 0.00 };
        }
        public override void AddSize(Size size)
        {
            Size = new Size() { name = "Large", price = 15.00 };
        }
        public override void AddToppings(params Topping[] toppings)
        {
            Toppings = new List<Topping>()
            {
                new Topping() {name = "Mozzerella", price = 0.00},
                new Topping() {name = "Marinara", price = 0.00 },
                new Topping() {name = "Ham", price = 1.00},
                new Topping() { name = "Pepperoni", price = 1.00 },
                new Topping() {name = "Sausage", price = 0.50}
            };
        }
    }
}