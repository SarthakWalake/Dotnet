class Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Animal Sound");
    }
}

class Dog : Animal
{
    public void Speak()
    {
        Console.WriteLine("Dog");
    }
}

class MainClass
{
    public delegate Animal MyDelegate(Dog d);

    public static Dog M(Animal a)
    {
        Dog d = (Dog)a;
        return d;
    }

    static void Main()
    {
        MyDelegate del = new MyDelegate(M);
        Animal m = del(new Dog());
        Dog d = (Dog)m;
        d.Speak();
    }
}