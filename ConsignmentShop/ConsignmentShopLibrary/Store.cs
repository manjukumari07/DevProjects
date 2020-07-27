using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Product> Products { get; set; }

        public Store()
        {
            Vendors = new List<Vendor>();
            Products = new List<Product>();
        }

    }
}
