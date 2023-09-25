using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{ 
    // Single Responsibility Principle (SRP)
    class FileManager
    {
        public void ReadFile(string filePath) { /* Read file logic */ }
        public void WriteFile(string filePath, string content) { /* Write file logic */ }
    }

    // Open-Closed Principle (OCP)
    interface IShape
    {
        double CalculateArea();
    }

    class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    // Interface Segregation Principle (ISP)
    interface IWorker
    {
        void Work();
    }

    interface IEater
    {
        void Eat();
    }

    class Worker : IWorker
    {
        public void Work() { Console.WriteLine("Worker is working."); }
    }

    class Robot : IWorker
    {
        public void Work() { Console.WriteLine("Robot is working."); }
    }

    class Human : IWorker, IEater
    {
        public void Work() { Console.WriteLine("Human is working."); }
        public void Eat() { Console.WriteLine("Human is eating."); }
    }

    // Dependency Inversion Principle (DIP)
    class WorkerManager
    {
        private readonly IWorker _worker;

        public WorkerManager(IWorker worker)
        {
            _worker = worker;
        }

        public void Manage()
        {
            _worker.Work();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // SRP Example
            FileManager fileManager = new FileManager();
            fileManager.ReadFile("example.txt");
            fileManager.WriteFile("example.txt", "Hello, SOLID!");

            // OCP Example
            IShape circle = new Circle { Radius = 5 };
            IShape rectangle = new Rectangle { Width = 4, Height = 6 };
            Console.WriteLine("Circle Area: " + circle.CalculateArea());
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());


            // ISP Example
            IWorker worker = new Worker();
            IWorker robot = new Robot();
            IWorker human = new Human();
            IEater humanEater = new Human();

            worker.Work();
            robot.Work();
            human.Work();
            humanEater.Eat();

            // DIP Example
            WorkerManager workerManager = new WorkerManager(worker);
            workerManager.Manage();
        }
    }

}
