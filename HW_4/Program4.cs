using System;
namespace Decorator
{
    class MainApp
    {
        static void Main()
        {
            Tree tree = new Tree();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA(tree);
            ConcreteDecoratorB d2 = new ConcreteDecoratorB(tree);
            ConcreteDecoratorC d3 = new ConcreteDecoratorC(d1);

            Console.Read();
        }
    }
    abstract class Component 
    {
        
    }

    class Tree : Component
    {

    }
    abstract class Decorator : Component
    {
        protected Component component;
    }

    class ConcreteDecoratorA : Decorator
    {
        private string addedState;
        private List<string> ltwo = new List<string> { "круглими", "квадратними", "овальними" };
        public ConcreteDecoratorA(Component component) 
        {
            var random = new Random();
            int index = random.Next(ltwo.Count);
            Console.WriteLine("Decorator A");
            this.component = component;
            addedState = $"Прикрашено {ltwo[index]} ялинковими прикрасами";
            Console.WriteLine($"Ялинку прикшено {ltwo[index]} ялинковими прикрасами");
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        private string addedState;
        private List<string> list = new List<string> { "червоним", "жовтим", "зеленим", "синім" };
        private List<string> ltwo = new List<string> { "круглими", "квадратними", "овальними"};
        public ConcreteDecoratorB(Component component)
        {
            var random = new Random();
            int index = random.Next(ltwo.Count);
            Console.WriteLine("Decorator B");
            this.component = component;
            addedState = $"Прикрашено {ltwo[index]} ялинковими прикрасами";
            AddedBehavior();
            Console.WriteLine($"Ялинку прикшено {ltwo[index]} ялинковими прикрасами");
        }
        void AddedBehavior()
        {
            var random3 = new Random();
            int index = random3.Next(list.Count);
            Console.WriteLine($"Ялинка світиться {list[index]} кольором");
        }
    }

    class ConcreteDecoratorC : Decorator
    {

        private List<string> list = new List<string> { "червоним", "жовтим", "зеленим", "синім" };
        public ConcreteDecoratorC(Component component)
        {
            Console.WriteLine("Decorator C");
            this.component = component;
            AddedBehavior();
        }
        void AddedBehavior()
        {
            var random = new Random();
            int index = random.Next(list.Count);
            Console.WriteLine($"Ялинка світиться {list[index]} кольором" );
        }
    }
}


