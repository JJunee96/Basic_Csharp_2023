using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_5_
{
    interface IAnimal
    {
        void Eat();
        void Sleep();
        void Sound();
    }

    class Animal
    {
        public string Name { get; set; }
        public byte Age { get; set; }
    }

    class Dog : Animal, IAnimal
    {
        public void Eat()
        {
            Console.WriteLine($"{Name}가 밥을 먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name}가 잠에듭니다");
        }
        public void Sound()
        {
            Console.WriteLine($"{Name}가 짖습니다 왈왈");
        }
    }
    class Cat : Animal, IAnimal
    {
        public void Eat()
        {
            Console.WriteLine($"{Name}가 밥을 먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name}가 잠에듭니다");
        }
        public void Sound()
        {
            Console.WriteLine($"{Name}가 짖습니다 냐오옹");
        }
    }
    class Horse : Animal, IAnimal
    {
        public void Eat()
        {
            Console.WriteLine($"{Name}이 밥을 먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name}이 잠에듭니다");
        }
        public void Sound()
        {
            Console.WriteLine($"{Name}이 웁니다 이히힝");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Cat c = new Cat();
            Horse h = new Horse();

            d.Name = "갱얼쥐";
            d.Age = 5;
            d.Eat();
            d.Sleep();
            d.Sound();

            c.Name = "고영희";
            c.Age = 3;
            c.Eat();
            c.Sleep();
            c.Sound();

            h.Name = "망나니";
            h.Age = 7;
            h.Eat();
            h.Sleep();
            h.Sound();
        }
    }
}
