using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Product_Search_Details
    {
        public int ID { get; set; }
        public string BARCODE { get; set; }
        public string SIZE { get; set; }
        public decimal PRICE { get; set; }
        public string LOCATION { get; set; }
        public int QUANTITY { get; set; }
    }
}
