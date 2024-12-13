using Ecommerce_Maui.ViewModels;

namespace Ecommerce_Maui.Views;

public partial class Product : ContentPage
{
	ProductViewModel _viewModel;
	public Product(ProductViewModel viewModel)
	{

		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await _viewModel.initializing();
    }
}