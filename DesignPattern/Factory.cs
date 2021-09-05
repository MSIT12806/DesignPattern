using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Factory
    {
        /*
         # 簡易工廠：
         面對容易變動的程式碼，用類來包裝
         # 工廠模式：
         將相似的程式碼寫在一起，不同的則抽象化讓次類別實作。
         # 抽象工廠：
         將關聯的物件寫在一起，可用工廠模式分別實踐，最後只要指派不同實作抽象工廠的類，就可以產生截然不同的物件。
         */
    }
    public interface PizzaIngredientFactory
    {
        //這樣子一個類裡面的元素就被鎖定了
        public string Dough { get; }
        public string Sauce { get; }
        public string Cheese { get; }
        public List<string> Veggies { get; }
    }
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
    public interface Pizza
    {
        public string Flavor { get; }
        public string Sauce { get; }
        public string Dough { get; }
        List<string> Veggies { get; }
        public string Cheese { get; }

    }
}
