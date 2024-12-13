using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_Maui.Models;
using Ecommerce_Maui.Services.Productservices;

namespace Ecommerce_Maui.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        private readonly IProductService productService;
        public ObservableCollection<Product> Products { get; }
        public ProductViewModel(IProductService productService)
        {
            Products = new ObservableCollection<Product>();
            this.productService = productService;
            
        }
        public async Task initializing()
        {
            Products.Clear();
            IsBusy = true;
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
