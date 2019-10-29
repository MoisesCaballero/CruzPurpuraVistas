using System;
using System.Collections.Generic;
using System.Text;

namespace product.Domain
{
    class Product
    {

        public string _id { get; set; }


        public string id { get; set; }

        public string nombre { get; set; }

        public string farmacia { get; set; }

        public int cantidad { get; set; }

        public string descripcion { get; set; }

        public double precio { get; set; }
    }
}
