public class Student:Person
{
    public string StudentId;
    public Student(string name, string id):base(name)
    {
        StudentId= id;
    }
    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"My student id is {StudentId}");
    }
}