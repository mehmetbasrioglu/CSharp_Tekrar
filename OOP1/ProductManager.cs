using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    // Product Manager(Service) ürün operasyonları 
    class ProductManager
    {
        //encapsulation 
        public void Add(Product product)
        {
            Console.WriteLine(product.Id + " Eklendi");
        }
    }
}
