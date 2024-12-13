using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_Maui.Models;
using Ecommerce_Maui.Services.Productservices;

namespace Ecommerce_Maui.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool isBusy;

        

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                isBusy = value;
                OnpropertyChanged();

            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

       public void OnpropertyChanged([CallerMemberName] string Property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Property));
        }
       
    }
}
