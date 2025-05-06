using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Header.Utils;
using Header.Utils.Models;

namespace Header.ViewModels;

public class SheetViewModel : ObservableObject
{
    public ObservableCollection<Student> Std { get; set; } = Global.Std;
    public ObservableCollection<Disciplines> Disc { get; set; } = Global.Disc;
}