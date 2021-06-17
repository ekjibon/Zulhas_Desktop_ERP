using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Branch_CentralStore_TransferMaster
    {
        public int ID { get; set; }
        [DisplayName(" RETURN ID ")]
        public int RETURN_ID { get; set; }
        public DateTime DATE { get; set; }
        public string REASON { get; set; }
        public string NOTE { get; set; }
        public List<Branch_Central_StoreDetails> BranchCentralStoreDetails { get; set; }
    }
}
