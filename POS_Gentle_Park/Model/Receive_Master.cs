using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Receive_Master
    {
        [DisplayName("RECEIVE ID ")]
        public int RECEIVE_ID { get; set; }
        
        [DisplayName("DATE ")]
        public DateTime DATE { get; set; }
        public string NOTE { get; set; }
        public List<Receive_Details> Receive_Product_Details { get; set; }
    }
}
