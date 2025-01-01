/*
using System;

namespace InheritanceDemo
{
    // Single Inheritance
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    // Multilevel Inheritance
    class Grandparent
    {
        public void ShowGrandparent()
        {
            Console.WriteLine("This is the grandparent method.");
        }
    }

    class Parent : Grandparent
    {
        public void ShowParent()
        {
            Console.WriteLine("This is the parent method.");
        }
    }

    class Child : Parent
    {
        public void ShowChild()
        {
            Console.WriteLine("This is the child method.");
        }
    }

    // Hierarchical Inheritance
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    class Bike : Vehicle
    {
        public void Ride()
        {
            Console.WriteLine("Bike is riding.");
        }
    }

    // Multiple Inheritance (via Interfaces)
    interface Interface1
    {
        void Method1();
    }

    interface Interface2
    {
        void Method2();
    }

    class MyClass : Interface1, Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Method1 from Interface1.");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 from Interface2.");
        }
    }

    // Hybrid Inheritance (using Parent and Interface)
    interface IA
    {
        void MethodA();
    }

    class HybridParent
    {
        public void ParentMethod()
        {
            Console.WriteLine("This is the parent method.");
        }
    }

    class HybridChild : HybridParent, IA
    {
        public void MethodA()
        {
            Console.WriteLine("This is the method from Interface IA.");
        }
    }

    // Main Program
    class Program
    {
        static void Main()
        {
            // Single Inheritance
            Console.WriteLine("Single Inheritance:");
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Bark();
            Console.WriteLine();

            // Multilevel Inheritance
            Console.WriteLine("Multilevel Inheritance:");
            Child myChild = new Child();
            myChild.ShowGrandparent();
            myChild.ShowParent();
            myChild.ShowChild();
            Console.WriteLine();

            // Hierarchical Inheritance
            Console.WriteLine("Hierarchical Inheritance:");
            Car myCar = new Car();
            myCar.Start();
            myCar.Drive();

            Bike myBike = new Bike();
            myBike.Start();
            myBike.Ride();
            Console.WriteLine();

            // Multiple Inheritance (via Interfaces)
            Console.WriteLine("Multiple Inheritance (using Interfaces):");
            MyClass myClass = new MyClass();
            myClass.Method1();
            myClass.Method2();
            Console.WriteLine();

            // Hybrid Inheritance
            Console.WriteLine("Hybrid Inheritance:");
            HybridChild hybridChild = new HybridChild();
            hybridChild.ParentMethod();
            hybridChild.MethodA();
        }
    }
}
*/