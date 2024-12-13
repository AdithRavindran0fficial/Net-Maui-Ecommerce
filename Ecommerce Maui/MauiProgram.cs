using Ecommerce_Maui.Services.Productservices;
using Ecommerce_Maui.ViewModels;
using Microsoft.Extensions.Logging;

namespace Ecommerce_Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<IProductService, ProductServicecs>();
            builder.Services.AddSingleton<ProductViewModel>();
            

#if DEBUG
            builder.Services.AddHttpClient("ProductClient",
                HttpClient => {
                    HttpClient.BaseAddress = new Uri("'https://fakestoreapi.com/");


                });


            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
