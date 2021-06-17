using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    class POS_TRANSACTION_RECEIVE_VM
    {
        [DisplayName(" ")]
        public bool Check { get; set; }
        public int? ID { get; set; }
        [DisplayName("CHALLAN NO")]
        public string CHALLAN_NO { get; set; }
        [DisplayName("STYLE NAME")]
        public string STYLE_NAME { get; set; }
        [DisplayName("SUB STYLE NAME")]
        public string SUB_STYLE_NAME { get; set; }
        [DisplayName("COLOR")]
        public string COLOR_NAME { get; set; }
        [DisplayName("SIZE")]
        public string ITEM_SIZE { get; set; }        
        [DisplayName("QUANTITY")]
        public int? CONS_QUANTITY { get; set; }
        [DisplayName("PREVIOUS RECEIVED QNTY")]
        public decimal? PREV_REC_QUANTITY { get; set; }
        [DisplayName("CURRENT RECEIVED QNTITY ")]
        public decimal? CURR_REC_QUANTITY { get; set; }
        [DisplayName("SALES RATE")]
        public decimal? SALES_RATE { get; set; }
        [DisplayName("SALES AMOUNT")]
        public decimal? SALES_AMOUNT { get; set; }
        public int? PROD_ID { get; set; }
        public int? STORE_ID { get; set; }
        public int? BRANCH_ID { get; set; }
        public int? STYLE_ID { get; set; }
        public int? SUB_STYLE_ID { get; set; }
        

    }
}
