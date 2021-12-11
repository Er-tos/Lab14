using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание кошки");
            Cat cat = new Cat();
            Console.WriteLine("Назовите Вашу кошку");
            cat.Name = Console.ReadLine();
            Console.WriteLine("Вашу кошку зовут: {0}.", cat.Name);
            Console.Write("Она говорит: ");
            cat.Say();
            Console.WriteLine();
            Console.WriteLine("Создание собаки");
            Dog dog = new Dog();
            Console.WriteLine("Назовите Вашу собаку");
            dog.Name = Console.ReadLine();
            Console.WriteLine("Вашу собаку зовут: {0}.", dog.Name);
            Console.Write("Она говорит: ");
            dog.Say();
            Console.ReadKey();
        }
        abstract class Animal
        {
            public abstract string Name { get; set; }
            public abstract void Say();
            public void ShowInfo()
            {
                Console.WriteLine(Name);
                Say();
            }
        }
        class Cat : Animal
        {
            string name;
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Say()
            {
                Console.WriteLine("Мяу!");
            }
        }
        class Dog : Animal
        {
            string name;
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Say()
            {
                Console.WriteLine("Гав!");
            }
        }
    }
}
