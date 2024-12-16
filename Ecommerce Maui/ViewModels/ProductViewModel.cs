using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Ecommerce_Maui.Models;
using Ecommerce_Maui.Services.Productservices;
using Ecommerce_Maui.Views;


namespace Ecommerce_Maui.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        private readonly IProductService productService;

        public ICommand GotoDetailsCommand { get; }
        public ObservableCollection<Products> Products { get; }
        public ProductViewModel(IProductService productService)
        {
            Products = new ObservableCollection<Products>();
            this.productService = productService;
            GotoDetailsCommand = new Command<Products>(async (product) =>
            {
                await Shell.Current.GoToAsync(nameof(Details), true, new Dictionary<string, object>
                {
                    ["selected"] = product
                });
            });
            IsBusy = true;
            
        }
        public async Task initializing()
        {
            Products.Clear();
            try
            {
                var items = await productService.GetProductsAsync();
                foreach (var item in items)
                {
                    Products.Add(item);
                }

            }
            
            finally { IsBusy = false; }
        }
    }
}
