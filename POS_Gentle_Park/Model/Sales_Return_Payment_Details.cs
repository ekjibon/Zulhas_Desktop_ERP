using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Sales_Return_Payment_Details
    {
        public int ID { get; set; }
        public List<Payment_Details> SalesReturnPaymentDetails { get; set; }
    }
}
