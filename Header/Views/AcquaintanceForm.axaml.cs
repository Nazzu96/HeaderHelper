using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Header.ViewModels;

namespace Header.Views;

public partial class AcquaintanceForm : Window
{
    public AcquaintanceForm()
    {
        InitializeComponent();
        DataContext = new AcquaintanceFormViewModel();
    }
}