using Ecommerce_Maui.Views;

namespace Ecommerce_Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Details), typeof(Details));
        }
    }
}
