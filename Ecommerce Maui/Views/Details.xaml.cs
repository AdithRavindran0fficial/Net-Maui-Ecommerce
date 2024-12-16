using Ecommerce_Maui.ViewModels;

namespace Ecommerce_Maui.Views;

public partial class Details : ContentPage
{
	public Details(DetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext =  viewModel;
	}
}