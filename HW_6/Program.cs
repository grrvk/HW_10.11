//Є ванільне та шоколадне морзиво і піца. Creator за типом створює певний обʼєкт. (Facroty Method)

using System;
namespace FactoryMethod
{

    public abstract class Creator
    {
        public abstract Product FactoryMethod(int type);
    }

    public class ConcreteCreator : Creator
    {
        public override Product FactoryMethod(int type)
        {
            switch (type)
            {
                case 1: return new VanillaIceCream();
                case 2: return new ChocolateIceCream();
                case 3: return new SpicyPizza();
                default: throw new ArgumentException("Invalid type.", "type");
            }
        }
    }

    public abstract class Product 
    {
        public abstract void Info();
    }

    public abstract class IceCream : Product
    {
        protected string cone;
        protected string flavour;
    }

    public class VanillaIceCream : IceCream
    {
        public VanillaIceCream()
        {
            cone = "waffle";
            flavour = "vanilla";
        }
        public override void Info()
        {
            Console.WriteLine("Ice cream with {0} cone and {1} flavour", cone, flavour);
        }
    }

    public class ChocolateIceCream : IceCream
    {
        string cone;
        string flavour;
        public ChocolateIceCream()
        {
            cone = "waffle";
            flavour = "chocolate";
        }
        public override void Info()
        {
            Console.WriteLine("Ice cream with {0} cone and {1} flavour", cone, flavour);
        }
    }

    public class SpicyPizza : Product
    {
        string dough;
        string sauce;
        string topping;
        public SpicyPizza()
        {
            dough = "pan baked";
            sauce = "hot";
            topping = "pepparoni+salami";
        }
        public override void Info()
        {
            Console.WriteLine("Spicy pizza with ingredients: {0} dough, {1} sauce and {2} topping", dough, sauce, topping);
        }
    }

    class MainApp
    {
        static void Main()
        { 
            Creator creator = new ConcreteCreator();
            Console.WriteLine("VanillaIceCream - 1\nChocolateIceCream - 2\nSpicyPizza - 3\nsmth else - stop");
            bool cycle = true;
            while (cycle)
            {
                Console.WriteLine("Оберіть продукт: ");
                string type = Console.ReadLine();
                if (type == "1")
                {
                    var product = creator.FactoryMethod(1);
                    Console.WriteLine("Created {0} ", product.GetType());
                    product.Info();
                }
                else if (type == "2")
                {
                    var product = creator.FactoryMethod(2);
                    Console.WriteLine("Created {0} ", product.GetType());
                    product.Info();
                }
                else if (type == "3")
                {
                    var product = creator.FactoryMethod(3);
                    Console.WriteLine("Created {0} ", product.GetType());
                    product.Info();
                }
                else
                {
                    cycle = false;
                }
            }
            Console.ReadKey();
        }
    }
}
