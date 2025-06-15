using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Net;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Header.Utils;
using Header.Utils.Models;
using Newtonsoft.Json;

namespace Header.ViewModels;

public partial class GroupInfoFormViewModel : ObservableObject
{
    
    // TODO: Сделать возможным заполнение на первый семестр и второй
    [ObservableProperty] private TypeOfGrid _typeGrid = TypeOfGrid.Student;
    [ObservableProperty] private string _fullNameOrDiscipline;

    [ObservableProperty] private string _studentName;
    [ObservableProperty] private string _disciplineName = string.Empty;

    [ObservableProperty] private string _groupDirection = string.Empty;
    [ObservableProperty] private string _groupAge = string.Empty;
    [ObservableProperty] private string _groupNumber = string.Empty;

    public string GroupName;
    public ObservableCollection<Disciplines> Disc { get; set; } = Global.Disc;
    //public ObservableCollection<Students> Std { get; set; } = Global.Std;
    public ObservableCollection<Students> Students { get; } = new();
    
    [RelayCommand]
    private void Add()
    {
        if (string.IsNullOrWhiteSpace(_fullNameOrDiscipline))
        /*switch (TypeGrid)
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
        }*/
    }
    
    // private string WatermarkText()
    // {
    //     
    // }
}