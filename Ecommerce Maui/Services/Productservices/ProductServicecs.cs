using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_Maui.Models;

namespace Ecommerce_Maui.Services.Productservices
{
    public class ProductServicecs : IProductService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public ProductServicecs(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        private HttpClient HttpClient => httpClientFactory.CreateClient("ProductClient");
        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await HttpClient.GetFromJsonAsync<Product>($"products/{id}");
            return product;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            try
            {
                var Products = await HttpClient.GetFromJsonAsync<IEnumerable<Product>>("products");
                if(Products is not null)
                {
                    return Products;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
