namespace Header.Utils.Models;

public sealed class Student(int id, string name)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
}