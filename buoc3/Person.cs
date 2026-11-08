public class Person
{
    public string Name;
    public Person(string name)
    {
        Name = name;
    }
    public virtual void Introduce()
    {
        Console.WriteLine($"Hi, I am{Name}");
    }
}