namespace Header.Utils.Models;

public sealed class Disciplines(int id, string discipline)
{
    public int Id { get; set; } = id;
    public string Discipline { get; set; } = discipline;
}