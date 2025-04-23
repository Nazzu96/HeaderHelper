using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Header.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";
    
    private string _groupName = "ИСП-IV-03";
    private string _lastChange = "last change: "+DateTime.Today.ToString("dd.MM.yyyy");
    
    private string GroupName
    {
        get => _groupName;
        set
        {
            _groupName = value;
            OnPropertyChanged(nameof(GroupName));
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

    private void DownloadButton_Click(object? sender, RoutedEventArgs e)
    {
        
    }
}