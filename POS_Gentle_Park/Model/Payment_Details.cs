using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Payment_Details
    {
        public int ID { get; set; }
        [DisplayName(" CARD NO ")]
        public int CARD_NO { get; set; }
        [DisplayName(" CARD TYPE ")]
        public string CARD_TYPE { get; set; }
        [DisplayName(" ISSUE FORM ")]
        public string ISSUE_FORM { get; set; }
        public decimal AMOUNT { get; set; }
    }
}
