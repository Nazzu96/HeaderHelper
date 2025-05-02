using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Header.Utils.Models;
using OfficeOpenXml.ConditionalFormatting.Contracts;

namespace Header.ViewModels;

public partial class AcquaintanceFormViewModel : ObservableObject
{
    [ObservableProperty] private TypeOfGrid _typeGrid = TypeOfGrid.Student;
    [ObservableProperty] private string _fullNameOrDiscipline = string.Empty;
    
    public ObservableCollection<Disciplines> Disc { get; set; } =
    [
        new Disciplines("Физическая культура"),
        new Disciplines("Информационные системы и программирование"),
        new Disciplines("Стандартизация, сертификация и техническая документация"),
        new Disciplines("Теория вероятности и математическая статистика"),
        new Disciplines("Основы безопасности жизнедеятельности"),
        new Disciplines("Экономика отрасли"),
    ];

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

    [RelayCommand]
    private void AddButton()
    {
        switch (TypeGrid)
        {
            case TypeOfGrid.Student:
            {
                FullNameOrDiscipline;
                break;
            }

            case TypeOfGrid.Discipline:
            {
                FullNameOrDiscipline;
                break;
            }
        }
    }
    
    private string WatermarkText()
    {
        
    }

}