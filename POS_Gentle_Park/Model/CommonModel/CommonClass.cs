using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class CommonClass
    {
        public string Barcode { get; set; }
        public string STYLE_NAME { get; set; }
        public string SUB_STYLE_NAME { get; set; }
        public string COLOR { get; set; }
        public string SIZE { get; set; }
        public int RETURN_QTY { get; set; }
        public decimal PRICE { get; set; }
        public decimal RETURN_AMT { get; set; }
        public int STOCK_QTY { get; set; }
        public string PYSICAL_STOCK { get; set; }
        public string SOFTWARE_STOCK { get; set; }
        public string SHORT_STOCK { get; set; }
        public decimal ADJUSTMENT_QTY { get; set; }
        public decimal AMOUNT { get; set; }
    }
}
