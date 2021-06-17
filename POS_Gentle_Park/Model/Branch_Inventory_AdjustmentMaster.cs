using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Branch_Inventory_AdjustmentMaster
    {
        public int ID { get; set; }
        [DisplayName("INVENTORY ID")]
        public int INVENTORY_ID { get; set; }
        public string REMARKS { get; set; }
        public List<Branch_Inventory_AdjustmentDetails> BranchInventoryAdjtDetailsTransfer { get; set; }
    }
}
