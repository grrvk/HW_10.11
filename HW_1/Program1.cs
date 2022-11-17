using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AbstractFactory
    {

        abstract class Car
        {
            public abstract void Info();
        }


        class Ford : Car
        {
            public override void Info()
            {
                Console.WriteLine("Ford");
            }
        }


        class Toyota : Car
        {
            public override void Info()
            {
                Console.WriteLine("Toyota");
            }
        }

        class Mersedes : Car
        {
            public override void Info()
            {
                Console.WriteLine("Mersedes");
            }
        }

        abstract class Seat
        {
            public virtual void Descr()
            {

            }
        }


        abstract class Engine {
            public virtual void GetPower()
            {
            }
        }


        class FordEngine : Engine {
            public override void GetPower()
            {
                Console.WriteLine("Ford Engine 4.4");
            }
        }

        class ToyotaEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Toyota Engine 3.2");
            }
        }

        class MersedesEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Mersedes Engine --");
            }
        }

        class MersedesSeats : Seat
        {
            public override void Descr()
            {
                Console.WriteLine("Mersedes seats");
            }
        }

        class   FordSeats : Seat
        {
            public override void Descr()
            {
                Console.WriteLine("Ford seats");
            }
        }

        class ToyotaSeats : Seat
        {
            public override void Descr()
            {
                Console.WriteLine("Toyota seats");
            }
        }



        interface ICarFactory { 
            Car CreateCar();
            Engine CreateEngine();
            Seat Descr();
        }


        class FordFactory : ICarFactory
        {

            Car ICarFactory.CreateCar()
            {
                return new Ford();
            }
            Engine ICarFactory.CreateEngine()
            {
                return new FordEngine();
            }
            Seat ICarFactory.Descr()
            {
                return new FordSeats();
            }
        }



        class ToyotaFactory : ICarFactory
        {

            Car ICarFactory.CreateCar()
            {
                return new Toyota();
            }
            Engine ICarFactory.CreateEngine()
            {
                return new ToyotaEngine();
            }
            Seat ICarFactory.Descr()
            {
                return new ToyotaSeats();
            }
        }

        class MersedesFactoty : ICarFactory
        {
            Car ICarFactory.CreateCar()
            {
                return new Mersedes();
            }
            Engine ICarFactory.CreateEngine()
            {
                return new MersedesEngine();
            }
            Seat ICarFactory.Descr()
            {
                return new MersedesSeats();
            }
        }

        static void Main(string[] args)
        {
            ICarFactory carFactory = new ToyotaFactory();

            Car myCar = carFactory.CreateCar();
            myCar.Info();
            Engine myEngine = carFactory.CreateEngine();
            myEngine.GetPower();
            Seat mySeat = carFactory.Descr();
            mySeat.Descr();

            carFactory = new FordFactory();

            myCar = carFactory.CreateCar();
            myCar.Info();
            myEngine = carFactory.CreateEngine();
            myEngine.GetPower();
            mySeat = carFactory.Descr();
            mySeat.Descr();

            carFactory = new MersedesFactoty();

            myCar = carFactory.CreateCar();
            myCar.Info();
            myEngine = carFactory.CreateEngine();
            myEngine.GetPower();
            mySeat = carFactory.Descr();
            mySeat.Descr();

            Console.ReadKey();
        }
    }
}