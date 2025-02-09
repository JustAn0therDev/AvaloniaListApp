using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaListApp.Views;

public partial class MainWindow : Window
{
    private string _messageFormat = "Clicked me {0} times!";
    private int _clickCount = 0;
    
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void CalculateToCelsius(object? sender, RoutedEventArgs e)
    {
        ConvertFahrenheitToCelsius();
    }

    private void CalculateToFahrenheit(object? sender, RoutedEventArgs e)
    {
        ConvertCelsiusToFahrenheit();
    }

    private void ConvertCelsiusToFahrenheit()
    {
        if (double.TryParse(Celsius.Text, out double celsius))
        {
            var fahrenheit = celsius * 9 / 5 + 32;
            Fahrenheit.Text = fahrenheit.ToString("0.0");
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }
    }

    private void ConvertFahrenheitToCelsius()
    {
        if (double.TryParse(Fahrenheit.Text, out double fahrenheit))
        {
            var celsius = (fahrenheit - 32) * 5/9;
            Celsius.Text = celsius.ToString("0.0");
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }
    }
}