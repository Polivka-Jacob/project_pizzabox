using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Order : AModel
    {
        public Customer Customer { get; set; }
        public AStore Store { get; set; }
        public APizza Pizza { get; set; }
        //public double TotalCost { get { return Pizza.Crust.price + Pizza.Size.price + Pizza.Topping.Sum(this => this.price)} }
    }
}