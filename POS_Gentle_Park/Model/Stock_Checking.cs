using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Stock_Checking
    {
        public int ID { get; set; }
        [DisplayName("BARCODE")]
        public string BARCODE { get; set; }
        [DisplayName("STYLE NAME")]
        public string STYLE_NAME { get; set; }
        [DisplayName("SUB STYLE NAME")]
        public string SUB_STYLE_NAME { get; set; }
        public string COLOR { get; set; }
        public string SIZE { get; set; }
        [DisplayName("SOFTWARE STOCK")]
        public int SOFTWARE_STOCK { get; set; }
        public decimal PRICE { get; set; }
        public decimal AMOUNT { get; set; }
    }
}
