using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    class PRODUCTS
    {
        public int? product_id { get; set; }
        [DisplayName("PRODUCT CODE")]
        public long? product_code { get; set; }
        [DisplayName("PRODUCT DESCRIPTION")]
        public string product_name { get; set; }
        [DisplayName("QUANTITY")]
        public int? quantity { get; set; }
        [DisplayName("PRICE")]
        public decimal? price { get; set; }
    }
}
