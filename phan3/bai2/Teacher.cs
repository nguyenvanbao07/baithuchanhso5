public class Teacher:Person
{
    public string Subject;
    public Teacher(string subject,string name, int age):base(name, age)
    {
        Subject= subject;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Mon day: "+Subject);
    }
}