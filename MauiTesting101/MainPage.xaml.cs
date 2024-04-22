using MauiTesting101.ViewModels;

namespace MauiTesting101
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

    }

}
