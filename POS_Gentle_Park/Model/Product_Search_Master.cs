using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public  class Product_Search_Master
    {
        public int ID { get; set; }
        public string BARCODE { get; set; }
        [DisplayName("STYLE NAME")]
        public string STYLE_NAME { get; set; }
        [DisplayName("SUB STYLE NAME")]
        public string SUB_STYLE_NAME { get; set; }
        public List<Product_Search_Details> ProductSearchTransferDetails { get; set; }
    }
}
