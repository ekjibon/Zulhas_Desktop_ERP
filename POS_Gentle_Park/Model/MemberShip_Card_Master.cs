using POS_Gentle_Park.Model.ModelForDropdown;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class MemberShip_Card_Master
    {
        public int? ID { get; set; }
        [DisplayName("COMPANY NAME")]
        public string COMPANY_NAME { get; set; }
        [DisplayName("CUSTOMER ID")]
        public int CUSTOMER_ID { get; set; }
        [DisplayName("CUSTOMER NAME")]
        public string CUSTOMER_NAME { get; set; }
        [DisplayName("CONTACT NUMBER")]
        public string CONTACT_NO { get; set; }
        [DisplayName("CARD TYPE")]
        public string CARD_TYPE { get; set; }
        [DisplayName("EXPIRE DATE")]
        public DateTime? EXPIRE_DATE { get; set; }
        [DisplayName("ISSUE DATE")]
        public DateTime? ISSUE_DATE { get; set; }
        [DisplayName("CARD NO")]
        public string CARD_NO { get; set; }
        [DisplayName("DATE OF BIRTH")]
        public Nullable<DateTime> DOB { get; set; }
        public string ADDRESS { get; set; }
        [DisplayName("CUSTOMER DESIGNATION")]
        public string DESIGNATION { get; set; }
        public List<COMPANY> MEMBERSHIP_COMPANY { get; set; }
        public List<CARD_TYPE> MEMBERSHIP_CARD_TYPE { get; set; }
    }
}
