using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using static System.Net.Mime.MediaTypeNames;

namespace MauiTesting101.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private int count;

    [ObservableProperty]
    private string text = "Click me";

    [RelayCommand]
    public void CounterClicked()
    {
        Count++;

        if (Count == 1) Text = $"Clicked {Count} time";
        else Text = $"Clicked {Count} times";
    }
}
