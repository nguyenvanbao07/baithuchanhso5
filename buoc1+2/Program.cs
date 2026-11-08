class Program
{
    static void Main()
    {
        Console.WriteLine("-B1-");   
        Dog d = new Dog();
        d.Eat();
        d.Bark();

        Console.WriteLine("-B2-");
        Cat c= new Cat();
        c.Eat();
        c.Meow();  
    }
}