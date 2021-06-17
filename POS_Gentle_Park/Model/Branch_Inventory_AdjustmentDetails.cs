using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Branch_Inventory_AdjustmentDetails
    {
        public int ID { get; set; }
        public string BARCODE { get; set; }
        [DisplayName("STYLE NAME")]
        public string STYLE_NAME { get; set; }
        [DisplayName("SUB STYLE NAME")]
        public string SUB_STYLE_NAME { get; set; }
        [DisplayName("COLOR")]
        public string COLOR { get; set; }
        public string SIZE { get; set; }
        [DisplayName("PHYSICAL STOCK")]
        public string PHYSICAL_STOCK { get; set; }
        [DisplayName("SOFTWARE STOCK")]
        public string SOFTWARE_STOCK { get; set; }
        [DisplayName("SHORT STOCK")]
        public string SHORT_STOCK { get; set; }
        [DisplayName("ADJUSTMENT QTY")]
        public int ADJUSTMENT_QTY { get; set; }
        public decimal PRICE { get; set; }
    }
}
