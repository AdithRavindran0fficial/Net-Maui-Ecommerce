﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Maui.Models
{
    internal class Cart
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Img { get; set; }
        public decimal Total { get; set; }
    }
}
