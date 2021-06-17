using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Sales_Return_Master
    {
        public int ID { get; set; }
        [DisplayName(" RETURN INVOICE ")]
        public string RETURN_INVOICE { get; set; }
        [DisplayName(" SALES INVOICE ")]
        public string SALES_INVOICE { get; set; }
        [DisplayName("CUSTOMER NAME")]
        public string CUSTOMER_NAME { get; set; }
        public string ADDRESS { get; set; }
        [DisplayName("REF INVOICE ")]
        public string REF_INVOICE { get; set; }
        [DisplayName(" CUSTOMER ID ")]
        public int CUSTOMER_ID { get; set; }
        [DisplayName(" DISCOUNT RATE ")]
        public int DISCOUNT_RATE { get; set; }
        [DisplayName(" SALES PERSON ")]
        public string SALES_PERSON { get; set; }
        [DisplayName(" REF.INV.DATE ")]
        public DateTime REF_INV_DATE { get; set; }
        [DisplayName("CARD NUMBER ")]
        public string CARD_NUMBER { get; set; }
        [DisplayName(" CONTACT NO ")]
        public string CONTACT_NO { get; set; }
        public DateTime DATE { get; set; }
        public string REMARKS { get; set; }
        public int DISCOUNT { get; set; }
        public int VAT { get; set; }
        [DisplayName(" RETURN AMOUNT ")]
        public decimal RETURN_AMOUNT { get; set; }
        [DisplayName(" PAYABLE AMOUNT ")]
        public decimal PAYABLE_AMOUNT { get; set; }
        [DisplayName(" CASH AMOUNT ")]
        public decimal CASH_AMOUNT { get; set; }
        [DisplayName(" CREDIT AMOUNT ")]
        public decimal CREDIT_AMOUNT { get; set; }
        [DisplayName(" AMOUNT PAID ")]
        public decimal AMOUNT_PAID { get; set; }
        [DisplayName(" CHANGE AMOUNT ")]
        public decimal CHANGE_AMOUNT { get; set; }
        public List<Product_Details> Sales_Return_PreviousDetails { get; set; }
        public List<Product_Details> Sales_Return_InformationDetails { get; set; }
        public List<Product_Details> Sales_Return_NewSalesDetails { get; set; }
        public List<Sales_Return_Payment_Details> Sales_Return_PaymentDetails { get; set; }


    }
}
