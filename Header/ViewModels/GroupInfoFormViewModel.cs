using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Header.Utils.Models;
using OfficeOpenXml.ConditionalFormatting.Contracts;

namespace Header.ViewModels;

public partial class GroupInfoFormViewModel : ObservableObject
{
    // TODO: Сделать возможным заполнение на первый семестр и второй
    [ObservableProperty] private TypeOfGrid _typeGrid = TypeOfGrid.Student;
    [ObservableProperty] private string _fullNameOrDiscipline = string.Empty;
    
    [ObservableProperty] private string _studentName = string.Empty;
    [ObservableProperty] private string _disciplineName = string.Empty;

    [ObservableProperty] private string _groupDirection = string.Empty;
    [ObservableProperty] private string _groupAge = string.Empty;
    [ObservableProperty] private string _groupNumber = string.Empty;
    
    public string GroupName;

    public ObservableCollection<Disciplines> Disc { get; set; } =
    [
        new Disciplines(1, "Физическая культура"),
        new Disciplines(2, "Информационные системы и программирование"),
        new Disciplines(3, "Стандартизация, сертификация и техническая документация"),
        new Disciplines(4, "Теория вероятности и математическая статистика"),
        new Disciplines(5, "Основы безопасности жизнедеятельности"),
        new Disciplines(6, "Экономика отрасли"),
    ];

    public ObservableCollection<Student> Std { get; set; } =
    [
        new Student(1, "Шихкеримов Руслан Гаджикурбанович"),
        new Student(2, "Герейханов Намик Алимадетович"),
        new Student(3, "Устенко Данил Алексеевич"),
        new Student(4, "Устенко Данил Алексеевич"),
        new Student(5, "Устенко Данил Алексеевич"),
        new Student(6, "Устенко Данил Алексеевич"),
        new Student(7, "Устенко Данил Алексеевич"),
        new Student(8, "Устенко Данил Алексеевич"),
        new Student(9, "Устенко Данил Алексеевич"),
        new Student(10, "Устенко Данил Алексеевич")
    ];

    [RelayCommand]
    private void AddButton()
    {
        switch (TypeGrid)
        {
            case TypeOfGrid.Student:
            {
                //FullNameOrDiscipline;
                
                break;
            }

            case TypeOfGrid.Discipline:
            {
                //FullNameOrDiscipline;
                break;
            }
        }
    }
    
    // private string WatermarkText()
    // {
    //     
    // }

}