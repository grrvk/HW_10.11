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

        public ConcreteDecoratorA(Component component) 
        {
            Console.WriteLine("Decorator A");
            this.component = component;
            addedState = "Прикрашено ялинковими прикрасами";
            Console.WriteLine("Ялинку прикшено ялинковими прикрасами");
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        private string addedState;

        public ConcreteDecoratorB(Component component)
        {
            Console.WriteLine("Decorator B");
            this.component = component;
            addedState = "Прикрашено ялинковими прикрасами";
            AddedBehavior();
            Console.WriteLine("Ялинку прикшено ялинковими прикрасами");
        }
        void AddedBehavior()
        {
            Console.WriteLine("Ялинка світиться");
        }
    }

    class ConcreteDecoratorC : Decorator
    {

        public ConcreteDecoratorC(Component component)
        {
            Console.WriteLine("Decorator C");
            this.component = component;
            AddedBehavior();
        }
        void AddedBehavior()
        {
            Console.WriteLine("Ялинка світиться");
        }
    }
}


