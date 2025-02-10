using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaListApp.Views;

public partial class MainWindow : Window
{
    private string _todoItemTextFormat = "- {0}";

    private int _amountOfTodoItemsOnScreen = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddTodoItem(object? sender, RoutedEventArgs e)
    {
        _amountOfTodoItemsOnScreen++;
        TextBlock textBlock = new()
        {
            Text = string.Format(_todoItemTextFormat, TodoItemTextBox.Text),
        };
        Button button = new()
        {
            Content = "Done",
        };
        StackPanel stackPanel = new()
        {
            Children = { textBlock, button },
            Orientation = Orientation.Horizontal,
            Name = $"Stack{_amountOfTodoItemsOnScreen}"
        };
        button.Click += RemoveTodoItem;
        TodoList.Children.Add(stackPanel);
    }

    private void RemoveTodoItem(object? sender, RoutedEventArgs e)
    {
        StackPanel? stackPanel =
            (StackPanel?)TodoList.Children.FirstOrDefault(f => f.Name == ((Button?)sender)?.Parent?.Name);

        if (stackPanel is not null)
        {
            TodoList.Children.Remove(stackPanel);
        }
    }
}