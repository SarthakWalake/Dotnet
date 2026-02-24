namespace Polymorpshism_Abstract
{
    abstract class Animal
        {
        public abstract void Speak();
        }

    class Dog : Animal 
    {
        public override void Speak()
        {
            Console.WriteLine("Bow");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Mew");
        }
    }

    class Rat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Chew");
        }
    }

    class MainClass
    {
        static void Main()
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Dog();
            animals[1] = new Cat();
            animals[2] = new Rat();

            for(int i =0;i<3;i++)
            {
                animals[i].Speak();
            }
        }
    }
}