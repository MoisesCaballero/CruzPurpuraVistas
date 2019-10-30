using System;
using FarmaciaApp.Helpers;
using product.Domain;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace FarmaciaApp.Services
{
    public static class ProductoService
    {
        public static List<Product> GetProducts()
        {

            var products = ApiHelper.Get<ResponseProducts>("/product/get/all");
            return products.products;
        }
    }
}
