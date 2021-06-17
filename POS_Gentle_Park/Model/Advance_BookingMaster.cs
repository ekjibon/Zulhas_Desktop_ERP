using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Advance_BookingMaster
    {
        public List<Sales_Master> AdvanceBooking { get; set; }
        public List<Product_Details> AdvanceBookignDetails { get; set; }
        public List<Sales_Return_Payment_Details> AdvanceBookingPaymentDetails { get; set; }
    }
}
