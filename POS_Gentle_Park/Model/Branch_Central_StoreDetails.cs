using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Branch_Central_StoreDetails
    {
        public int ID { get; set; }
        public string Barcode { get; set; }
        [DisplayName(" STYLE NAME ")]
        public string STYLE_NAME { get; set; }
        [DisplayName(" SUB_STYLE_NAME ")]
        public string SUB_STYLE_NAME { get; set; }
        
        public string COLOR { get; set; }
        public string SIZE { get; set; }
        [DisplayName(" RETURN QTY ")]
        public int RETURN_QTY { get; set; }
        public decimal PRICE { get; set; }
        [DisplayName(" RETURN AMOUNT ")]
        public decimal RETURN_AMT { get; set; }
        [DisplayName(" STOCK QTY ")]
        public int STOCK_QTY { get; set; }
    }
}
