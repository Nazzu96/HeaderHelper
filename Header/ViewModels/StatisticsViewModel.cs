using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Header.Utils.Models;

namespace Header.ViewModels;

// Чтобы класс можно было использовать как ViewModel он должен наследоваться от ObservableObject
// а также иметь расширение partial (переводиться как "частичный")
// тк ObservableObject будет создавать в другом месте доп функции и поля (например при ObservableProperty)
// поэтому я советовал CommunityToolkit.MVVM тк большинство повторяющегося кода просто автоматизировано
public partial class StatisticsViewModel : ObservableObject
{
    public ObservableCollection<string> Disc { get; } = [];

    // в другой части проекта создалось свойство Test к которому ты уже будешь привязываться во View
    [ObservableProperty] private string _test = "test";
    
    public ObservableCollection<Student> Std { get; } =
    [
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
        new Student("Устенко Данил Алексеевич"),
    ];

}