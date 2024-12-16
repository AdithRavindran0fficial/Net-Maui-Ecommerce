using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_Maui.Models;

namespace Ecommerce_Maui.ViewModels
{
    [QueryProperty(nameof(Product),"selected")]
    public class DetailsViewModel : BaseViewModel
    {

        private Products product;
        public Products Product
        {
            get => product;
            set
            {
                product = value;
                OnpropertyChanged();
            }
        }
        public DetailsViewModel()
        {
               
        }
    }
}
