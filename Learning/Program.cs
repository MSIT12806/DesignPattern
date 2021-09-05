using DesignPatternCoffeeShop;
using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static class PizzaShop
        {
            public static void OrderPizza()
            {

            }
        }
        public static class CoffeeShop
        {
            /*
             static void Main(string[] args)
        {
            Beverage beverage = new HouseBlend();
            beverage = new Sugar(beverage);
            beverage = new Milk(beverage);
            CoffeeShop.OrderBeverage(beverage);
        }
             */
            public static void OrderBeverage(Beverage beverage)
            {
                Console.WriteLine($"您的飲料：{beverage.GetDescription()}");
                Console.WriteLine($"您的金額：{beverage.Cost()}");
            }
        }
    }
}
