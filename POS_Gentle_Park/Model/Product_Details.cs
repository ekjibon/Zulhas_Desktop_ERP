using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Product_Details
    {
        public int ID { get; set; }
        public string BARCODE { get; set; }
        [DisplayName(" STYLE NAME ")]
        public string STYLE_NAME { get; set; }
        [DisplayName(" SUB STYLE NAME ")]
        public string SUB_STYLE_NAME { get; set; }

        public string COLOR { get; set; }
        public string SIZE { get; set; }
        [DisplayName(" SALES QTY ")]
        public int SALES_QTY { get; set; }
        public decimal PRICE { get; set; }
        [DisplayName(" GROSS AMOUNT ")]
        public decimal GROSS_AMOUNT { get; set; }
        [DisplayName(" DISCOUNT RATE ")]
        public int DISCOUNT_RATE { get; set; } //********
        [DisplayName(" DISCOUNT AMOUNT ")]
        public decimal DISCOUNT_AMOUNT { get; set; }
        [DisplayName(" VAT RATE ")]
        public int VAT_RATE { get; set; }
        [DisplayName(" VAT AMOUNT ")]
        public int VAT_AMOUNT { get; set; }
        [DisplayName(" NET AMOUNT ")]
        public decimal NET_AMOUNT { get; set; }
        public int STOCK { get; set; }

    }
}
