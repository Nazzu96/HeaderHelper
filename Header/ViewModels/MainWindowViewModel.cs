using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Header.Views;

namespace Header.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private string _groupName = "ИСП-IV-03";
    private string _lastChange = "last change: " + DateTime.Today.ToString("dd.MM.yyyy");
    
    [ObservableProperty] private bool _listRadioButtonSelected;
    [ObservableProperty] private bool _periodRadioButtonSelected;
    [ObservableProperty] private bool _semesterRadioButtonSelected;
    [ObservableProperty] private bool _statisticsRadioButtonSelected;
    [ObservableProperty] private bool _dataEditionRadioButtonSelected;
    [ObservableProperty] private bool _someoneRadioButtonSelected;

    private string CollName
    {
        get => _groupName;
        set
        {
            _groupName = value;
            OnPropertyChanged(nameof(CollName));
        }
    }

    private string LastChanged
    {
        get => _lastChange;
        set
        {
            _lastChange = value;
            OnPropertyChanged(nameof(LastChanged));
        }
    }

    [RelayCommand] private void RadioButtonActivities()
    {
        if (ListRadioButtonSelected)
        {
         // Переход на форму Знакомство;  
         AcquaintanceForm acquaintanceForm = new AcquaintanceForm();
         acquaintanceForm.Show();
         
        }

        else if (PeriodRadioButtonSelected)
        {
            // Переход на форму Статистика;  
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }

        else
        {
            Console.WriteLine("Ничего не выбрано. Выбери кнопку");
        }
    } // Переход между формами
    
    [RelayCommand] private async Task DownloadFile(Window window)
    {
        FilePickerSaveOptions saveOptions = new FilePickerSaveOptions()
        {
            SuggestedFileName = $"{_groupName}",
            DefaultExtension = "xltm",
            
        };
        var result = await window.StorageProvider.SaveFilePickerAsync(saveOptions);
        Console.WriteLine(result.Name);
        Console.WriteLine(result.Path);
    } // Скачивание файла
}