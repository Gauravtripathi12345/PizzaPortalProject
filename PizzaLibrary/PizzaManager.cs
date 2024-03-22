using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class PizzaManager
    {
        public List<PizzaProperties> pizzaList;
        public PizzaManager()
        {
            pizzaList = new List<PizzaProperties>();
        }
        public List<PizzaProperties> ListOfPizza()
        {
            PizzaProperties pizza1 = new PizzaProperties() { Id = 1, Type = "Pepperoni Pizza", Price = 250.99f };
            PizzaProperties pizza2 = new PizzaProperties() { Id = 2, Type = "Margherita Pizza", Price = 200.50f };
            PizzaProperties pizza3 = new PizzaProperties()
            {
                Id = 3,
                Type = "Veggie Delight Pizza",
                Price = 325.66f
            };
            PizzaProperties pizza4 = new PizzaProperties()
            {
                Id = 4,
                Type = "Mushroom and Olive Pizza",
                Price = 440.99f
            };
            PizzaProperties pizza5 = new PizzaProperties()
            {
                Id = 5,
                Type = "Veggie Delight Pizza",
                Price = 325.66f
            };
            PizzaProperties pizza6 = new PizzaProperties()
            {
                Id = 6,
                Type = "Paneer Pizza",
                Price = 230.33f
            };
            PizzaProperties pizza7 = new PizzaProperties()
            {
                Id = 7,
                Type = "Cheese Pizza",
                Price = 375.00f
            };
            pizzaList.Add(pizza1);
            pizzaList.Add(pizza2);
            pizzaList.Add(pizza3);
            pizzaList.Add(pizza4);
            pizzaList.Add(pizza5);
            pizzaList.Add(pizza6);
            pizzaList.Add(pizza7);

            return pizzaList;
        }
    }
}
