using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Maui.Models
{
    internal class order
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public int Qty { get; set; }
        //public decimal Price { get; set; }
        public string Product_Name { get; set; }
        public decimal Total { get; set; }
        //public int User_Id { get; set; }
        //public string UserName { get; set; }
    }
}
