public class Employee
{
    public string Name;
    public double Salary;
    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Hoten: "+Name);
        Console.WriteLine("Luong "+Salary);
    }
}