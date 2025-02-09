using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaListApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private int _count;
    [ObservableProperty]
    private string _fahrenheitLabel = "Fahrenheit";

    [RelayCommand]
    private void SetFahenheitLabel()
    {
        FahrenheitLabel = $"Fahrenheit {++_count}";
    }
}