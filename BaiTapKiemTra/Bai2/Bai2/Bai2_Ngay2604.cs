using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    abstract class Animal
    {
        public abstract void eat();
        public abstract void makeSound();
    }
    class Bird : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating ");
        }

        public void fly()
        {
            Console.WriteLine("Flying");
        }

        public override void makeSound()
        {
            Console.WriteLine("Sounding");

        }
    }
    class Cat : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating Cat");

        }
        public void run()
        {
            Console.WriteLine("Running");
        }

        public override void makeSound()
        {
            Console.WriteLine("Sounding Cat");
        }
    }
    class Bai2
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            cat.eat();
            cat.makeSound();
            Animal bird = new Bird();
            bird.eat();
            bird.makeSound();
            Console.ReadKey();
        }
    }
}
