﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_Maui.Models;

namespace Ecommerce_Maui.Services.Productservices
{
    public interface IProductService
    {
        Task<IEnumerable<Products>> GetProductsAsync();

        Task<Products> GetProductByIdAsync(int id);

        
    }
}
