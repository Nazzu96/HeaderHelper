namespace Header.Utils.Models;

public sealed class Students(int id, string name, bool fullAttendance, int summaryMissing, string missedDay)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;

    public bool FullAttendance { get; set; } = fullAttendance;

    public int SummaryMissing { get; set; } = summaryMissing;

    public string MissedDay { get; set; } = missedDay;
}