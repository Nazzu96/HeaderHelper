using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using Header.Utils;
using Header.Utils.Models;

namespace Header.Services;

public class FirstAdd : ObservableObject
{
    private ObservableCollection<Students> Std { get; set; } = Global.Std;
    private ObservableCollection<Disciplines> Disc { get; set; } = Global.Disc;
    private ObservableCollection<DisciplinesPopularuty> DiscPopul { get; set; }
}