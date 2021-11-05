using System;
using System.Collections.Generic;
using System.Linq;

namespace _4建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();

            var vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.ShowItems();
            Console.WriteLine("Total Cost: " + vegMeal.GetCost());

            var nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("\n\nNon-Veg Meal");
            nonVegMeal.ShowItems();
            Console.WriteLine("Total Cost: " + nonVegMeal.GetCost());
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 创建一个表示食物条目的接口。
    /// </summary>
    public interface Item
    {
        string Name();

        Packing Packing();

        decimal Price();
    }
    /// <summary>
    /// 食物包装
    /// </summary>
    public interface Packing
    {
        string Pack();
    }
    /// <summary>
    /// 纸袋
    /// </summary>
    public class Wrapper : Packing
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }
    /// <summary>
    /// 瓶子
    /// </summary>
    public class Bottle : Packing
    {
        public string Pack()
        {
            return "Bottle";
        }
    }
    /// <summary>
    /// 汉堡包
    /// </summary>
    public abstract class Burger : Item
    {
        public abstract string Name();

        public Packing Packing()
        {
            return new Wrapper();
        }

        public abstract decimal Price();
    }
    /// <summary>
    /// 冷饮
    /// </summary>
    public abstract class ColdDrink : Item
    {
        public abstract string Name();
        /// <summary>
        /// 默认包装
        /// </summary>
        /// <returns></returns>
        public Packing Packing()
        {
            return new Bottle();
        }

        public abstract decimal Price();
    }

    /// <summary>
    /// Veg汉堡
    /// </summary>
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg Burger";
        }

        public override decimal Price()
        {
            return 25M;
        }
    }

    public class ChichenBurger : Burger
    {
        public override string Name()
        {
            return "Chicken Burger";
        }

        public override decimal Price()
        {
            return 10M;
        }
    }

    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return "Coke Cola";
        }

        public override decimal Price()
        {
            return 5M;
        }
    }

    public class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return "Pepsi Cola";
        }

        public override decimal Price()
        {
            return 5M;
        }
    }
    /// <summary>
    /// 创建一个 Meal 类，带有上面定义的 Item 对象。
    /// </summary>
    public class Meal
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public decimal GetCost()
        {
            var cost = items.Select(x => x.Price())
                            .Sum();
            return cost;
        }

        public void ShowItems()
        {
            foreach(var item in items)
            {

                Console.WriteLine("Item : " + item.Name());
                Console.WriteLine("Packing : " + item.Packing().Pack());
                Console.WriteLine("Price : " + item.Price());
            }
        }
    }
    /// <summary>
    /// 创建一个 MealBuilder 类，实际的 builder 类负责创建 Meal 对象。
    /// </summary>
    public class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
        }

        public Meal PrepareNonVegMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new ChichenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }
    }
}
