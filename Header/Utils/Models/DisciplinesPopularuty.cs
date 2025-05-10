namespace Header.Utils.Models;

public class DisciplinesPopularuty(string disciplines, double progressBar, string percentPopularity)
{
    public string Disciplines { get; set; } = disciplines;
    public double ProgressBar { get; set; } = progressBar;
    public string PercentPopularity { get; set; } = percentPopularity;
}