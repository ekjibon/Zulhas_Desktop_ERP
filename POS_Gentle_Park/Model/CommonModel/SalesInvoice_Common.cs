using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class SalesInvoice_Common
    {
        [DisplayName("RECEIVE ID ")]
        public int RECEIVE_ID { get; set; }
        [DisplayName("RETURN ID ")]
        public int RETURN_ID { get; set; }
        [DisplayName("INVENTORY ID ")]
        public int INVENTORY_ID { get; set; }
        [DisplayName("CUSTOMER ID ")]
        public int CUSTOMER_ID { get; set; }
        [DisplayName("INVOICE NO ")]
        public string INVOICE_NO { get; set; }
        [DisplayName("CONTACT NO ")]
        public string CONTACT_NO { get; set; }
        [DisplayName("CARD NO ")]
        public string CARD_NO { get; set; }
        [DisplayName("GIFT VOUCHER NO ")]
        public string GIFT_VOUCHER_NO { get; set; }

        public int REASON { get; set; }
        public DateTime DATE { get; set; }

        public string ADDRESS { get; set; }
        
        [DisplayName("AVAILABLE REDEEM POINT ")]
        public string AVAILABLE_REDEEM_POINT { get; set; }

        public string REMARKS { get; set; }
        [DisplayName("SALES PERSON NAME ")]
        public string SALES_PERSON_NAME { get; set; }
     
        [DisplayName("CUSTOMER NAME ")]
        public string CUSTOMER_NAME { get; set; }
       
        [DisplayName("GIFT VOUCHER AMOUNT ")]
        public decimal GIFT_VOUCHER_AMOUNT { get; set; }

        public int DISCOUNT { get; set; }
        [DisplayName("POINT REEDEM AMOUNT ")]
        public decimal POINT_REEDEM_AMT { get; set; }
        public int VAT { get; set; }
        [DisplayName("NET AMOUNT PAYABLE ")]
        public decimal NET_AMOUNT_PAYABLE { get; set; }
        [DisplayName("REDEEM AMOUNT AVAILABLE ")]
        public int REDEEM_AMOUNT_AVAIL { get; set; }
        [DisplayName("CASH AMOUNT ")]
        public decimal CASH_AMOUNT { get; set; }
        [DisplayName("CREDIT AMOUNT ")]
        public decimal CREDIT_AMOUNT { get; set; }
        [DisplayName("AMOUNT PAID ")]
        public decimal AMOUNT_PAID { get; set; }
        [DisplayName("CHANGE AMOUNT ")]
        public decimal CHANGE_AMOUNT { get; set; }
        [DisplayName("SUB TOTAL ")]
        public decimal SUB_TOTAL { get; set; }
        public decimal NOTE{ get; set; }


        public string RETURN_INVOICE { get; set; }
        [DisplayName(" SALES INVOICE ")]
        public string SALES_INVOICE { get; set; }
       
       
        [DisplayName("REF INVOICE ")]
        public string REF_INVOICE { get; set; }
        
        [DisplayName(" DISCOUNT RATE ")]
        public int DISCOUNT_RATE { get; set; }
        [DisplayName(" SALES PERSON ")]
        public string SALES_PERSON { get; set; }
        [DisplayName(" REF.INV.DATE ")]
        public DateTime REF_INV_DATE { get; set; }
        
        public decimal RETURN_AMOUNT { get; set; }
        [DisplayName(" PAYABLE AMOUNT ")]
        public decimal PAYABLE_AMOUNT { get; set; }
      
    }
}
