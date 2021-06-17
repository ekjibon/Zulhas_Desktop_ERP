using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    class CUSTOMER_VM
    {
        public int? ID { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public int? COMPANY_ID { get; set; }
        public int? CUSTOMER_ID { get; set; }
        public int? CARD_NO { get; set; }
        public int? DISCOUNT { get; set; }
        public string BRANCH_NAME { get; set; }
        public string ADDRESS { get; set; }
        public long? CONTACT_NO { get; set; }
    }
}
