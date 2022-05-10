using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();

            Animal bird = new Bird();
            cat.eat();
            bird.makeSound();
        }
    }
    public abstract class Animal {
    public abstract void eat();

    public abstract void makeSound();
    }
    public class Cat : Animal
    {
        
    public override void eat()
    {
        Console.WriteLine("Mèo đang ăn cá");
    }

    
    public override void makeSound()
    {
            Console.WriteLine("meow");
    }

    public void run()
    {
            Console.WriteLine("Mèo có thể chạy");
    }
    }
    public class Bird : Animal
    {
    public override void eat()
    {
        Console.WriteLine("Con chim đang ăn sâu");
    }

    public override void makeSound()
    {
        Console.WriteLine("Con chim đang hót");
    }

    public void fly()
    {
        Console.WriteLine("Con chim có thể bay");
    }
}

}
