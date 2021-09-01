using System;

namespace DesignPatternCoffeeShop
{
    /*
     裝飾者模式──
    想像一個狀況，咖啡店賣著幾款咖啡，每種咖啡可以加料，並依照這些組合生成不同的價格...
    程式面需要保有一些彈性，比方說，新的飲料，可能不能加某些配料；配料可以雙倍...
     */
    public class Decorator
    {
    }
    /// <summary>
    /// 店內所有飲料都請繼承此抽象類別
    /// </summary>
    public abstract class Beverage
    {
        public abstract string GetDescription();
        public abstract int Cost();
    }
    #region 店內四種飲料款
    public class HouseBlend : Beverage
    {
        public override int Cost()
        {
            return 120;
        }

        public override string GetDescription()
        {
            return "精品咖啡";
        }
    }
    public class DarkRoast : Beverage
    {
        public override int Cost()
        {
            return 100;
        }

        public override string GetDescription()
        {
            return "深焙咖啡";
        }
    }
    public class Decaf : Beverage
    {
        public override int Cost()
        {
            throw new NotImplementedException();
        }

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }
    }
    public class Espresso : Beverage
    {
        public override int Cost()
        {
            return 160;
        }

        public override string GetDescription()
        {
            return "濃縮咖啡";
        }
    }

    #endregion

    /// <summary>
    /// 飲料的裝飾物件抽象類，要先繼承飲料類
    /// </summary>
    public abstract class BeverageDecorator : Beverage
    {
        protected Beverage _beverage;
    }

    public class Milk : BeverageDecorator
    {
        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override int Cost()
        {
            return _beverage.Cost() + 30;
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + " add milk";
        }
    }
    public class Sugar : BeverageDecorator
    {
        public Sugar(Beverage beverage)
        {
            if (beverage.GetDescription() == "精品咖啡")
            {
                throw new Exception("精品咖啡不能加糖");
            }
            _beverage = beverage;
        }

        public override int Cost()
        {
            return _beverage.Cost() + 10;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + " add sugar";
        }
    }
}
