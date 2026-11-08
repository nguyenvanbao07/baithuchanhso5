public class Manager:Employee
{
    public string Position;
    public Manager(string postion, string name, double salary):base(name,salary)
    {
        Position= postion;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
    Console.WriteLine("Chuc vu "+Position);
    }
}