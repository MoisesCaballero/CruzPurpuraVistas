using System;
using System.Collections.Generic;
using System.Text;

namespace product.Domain
{
    class ResponseProducts
    {
        public Boolean ok { get; set; }


        public List<Product> products { get; set; }
    }
}
