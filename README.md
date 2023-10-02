# SOLID Principles


## Author: Bercu Iulian

----

## Objectives:

* Study and understand the SOLID Principles.

* Choose a domain, define its main classes/models/entities and choose the appropriate instantiation mechanisms.

* Create a sample project that respects SOLID Principles.


## Used Patterns: 

* Single Responsibility Principle (SRP)
* Open-Closed Principle (OCP)
* Interface Segregation Principle (ISP)
* Dependency Inversion Principle (DIP)


## Implementation

* The provided C# code demonstrates the SOLID principles effectively. It enforces the Single Responsibility Principle (SRP) by isolating file operations within the 'FileManager' class. Furthermore, it showcases the Open-Closed Principle (OCP) by allowing for easy extension of shape calculations and adheres to the Liskov Substitution Principle (LSP) by introducing a 'Square' class that can seamlessly substitute its base class, 'Rectangle'. This code serves as a comprehensive illustration of SOLID principles, enhancing code maintainability and flexibility.


* Snippets from my files.


```
// Single Responsibility Principle (SRP)
class FileManager
    {
        public void ReadFile(string filePath) {}
        public void WriteFile(string filePath, string content) {}
    }
```

```
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
```


## Conclusions / Screenshots / Results


In conclusion, the C# code presented in this task serves as a practical embodiment of the SOLID principles in software design. By adhering to these principles, it promotes code that is easier to maintain, extend, and modify. The code's structured implementation of SRP, OCP, ISP, and DIP showcases how these principles can work harmoniously to create more robust and adaptable software systems.


* The result of running the program

  ![image](https://github.com/BercuIulian/TMPS-Lab1/assets/113422203/c189cd39-4fa8-4e91-8dea-12ff9d89f556)
