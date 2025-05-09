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

public partial class MainWindowViewModel : ObservableObject
{
    private string _groupName = "ИСП-IV-03";
    private string _lastChange = "last change: " + DateTime.Today.ToString("dd.MM.yyyy");
    
    [ObservableProperty] private bool _sheetRadioButtonSelected;
    [ObservableProperty] private bool _periodRadioButtonSelected;
    [ObservableProperty] private bool _groupInfoRadioButtonSelected;
    [ObservableProperty] private bool _statisticsRadioButtonSelected;

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
        if (SheetRadioButtonSelected)
        {
         // Переход на форму Ведомость
         SheetForm sheetForm = new SheetForm();
         sheetForm.Show();
        }

        else if (PeriodRadioButtonSelected)
        {
            // Переход на форму Рубежный контроль
            PeriodForm periodForm = new PeriodForm();
            periodForm.Show();
        }
        
        else if (GroupInfoRadioButtonSelected)
        {
            // Переход на форму Данные группы
            GroupInfoForm groupInfoForm = new GroupInfoForm();
            groupInfoForm.Show();
        }

        else if (StatisticsRadioButtonSelected)
        {
            // Переход на форму Статистика
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