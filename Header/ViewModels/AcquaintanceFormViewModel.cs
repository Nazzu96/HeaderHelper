using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.Input;

namespace Header.ViewModels;

public class AcquaintanceFormViewModel
{
    public ObservableCollection<Disciplines> Disc { get; set; }
    public ObservableCollection<Students> Std { get; set; }

    public AcquaintanceFormViewModel()
    {
        var disciplines = new List<Disciplines>()
        {
            new Disciplines("Физическая культура"),
            new Disciplines("Информационные системы и программирование"),
            new Disciplines("Стандартизация, сертификация и техническая документация"),
            new Disciplines("Теория вероятности и математическая статистика"),
            new Disciplines("Основы безопасности жизнедеятельности"),
            new Disciplines("Экономика отрасли"),
        };
        var students = new List<Students>()
        {
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
            new Students("Устенко Данил Алексеевич"),
        };
        Disc = new ObservableCollection<Disciplines>(disciplines);
        Std = new ObservableCollection<Students>(students);
    }
}