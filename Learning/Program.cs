using DesignPatternCoffeeShop;
using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new HouseBlend();
            beverage = new Sugar(beverage);
            beverage = new Milk(beverage);
            OrderResult(beverage);
        }
        public static void OrderResult(Beverage beverage)
        {
            Console.WriteLine($"您的飲料：{beverage.GetDescription()}");
            Console.WriteLine($"您的金額：{beverage.Cost()}");
        }
    }
}
