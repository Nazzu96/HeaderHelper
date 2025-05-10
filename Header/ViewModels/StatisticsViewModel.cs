using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Header.Utils;
using Header.Utils.Models;

namespace Header.ViewModels;

// Чтобы класс можно было использовать как ViewModel он должен наследоваться от ObservableObject
// а также иметь расширение partial (переводиться как "частичный")
// тк ObservableObject будет создавать в другом месте доп функции и поля (например при ObservableProperty)
// поэтому я советовал CommunityToolkit.MVVM тк большинство повторяющегося кода просто автоматизировано
public class StatisticsViewModel : ObservableObject
{
    public ObservableCollection<Students> Std { get; set; } = Global.Std;
    public ObservableCollection<Disciplines> Disc { get; set; } = Global.Disc;
    public ObservableCollection<DisciplinesPopularuty> DiscPopul { get; set; }

    bool isFirstAddicting = false;

    public void Begin()
    {
        if (isFirstAddicting)
        {
            for (int i = 0; i < Disc.Count - 1; i++)
            {
                string disc = Disc[i].ToString();
                DiscPopul.Add(new DisciplinesPopularuty(disc, 0, "0"));
                isFirstAddicting = false;
            }
        }
    }
}