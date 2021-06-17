using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Sales_Master
    {
        [DisplayName("CUSTOMER ID ")]
        public int CUSTOMER_ID { get; set; }
        [DisplayName("INVOICE NO ")]
        public string INVOICE_NO { get; set; }
      
        public DateTime DATE { get; set; }
     
        public string ADDRESS { get; set; }
        [DisplayName("CONTACT NO ")]
        public string CONTACT_NO { get; set; }
        [DisplayName("AVAILABLE REDEEM POINT ")]
        public string AVAILABLE_REDEEM_POINT { get; set; }

        public string REMARKS { get; set; }
        [DisplayName("SALES PERSON NAME ")]
        public string SALES_PERSON_NAME { get; set; }
        [DisplayName("CARD NO ")]
        public string CARD_NO { get; set; }
        [DisplayName("CUSTOMER NAME ")]
        public string CUSTOMERr_NAME { get; set; }
        [DisplayName("GIFT VOUCHER NO ")]
        public string GIFT_VOUCHER_NO { get; set; }
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
        public List<Product_Details> SalesInvoiceProductDetails { get; set; }
        public List<Payment_Details> SalesInvoicePaymentDetails { get; set; }


    }
}
