using Oracle.ManagedDataAccess.Client;
using POS_Gentle_Park.Model;
using POS_Gentle_Park.Model.ModelForDropdown;
using POS_Gentle_Park.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace POS_Gentle_Park
{
    public partial class frmMembershipCard : Form
    {
        //static string OracleConString = "Data Source = (DESCRIPTION =  (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.11.250)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = ORCL) ) );User Id = RETAILERP;password = RETAILERP;";
        static string OracleConString = "Data Source = (DESCRIPTION =  (ADDRESS = (PROTOCOL = TCP)(HOST = 59.152.60.147)(PORT = 15252)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = ORCL) ) );User Id = RETAILERP;password = RETAILERP;";
        static OracleConnection OracleCon = new OracleConnection(OracleConString);
        public frmMembershipCard()
        {
            InitializeComponent();
           
        }
        private void frmMembershipCard_Load(object sender, EventArgs e)
        {
            ERPDbContext dbContext = new ERPDbContext();

            var a  = dbContext.MemberShip_Card_Master.FirstOrDefault();
            var p = a;

            if (OracleCon.State == ConnectionState.Closed)
            {
               // OracleCon.Open();
            }
            List<COMPANY> ComList = new List<COMPANY>();
            ComList.Add(new COMPANY() { COMPANY_ID = 01, COPANY_NAME = "AD" });
            ComList.Add(new COMPANY() { COMPANY_ID = 02, COPANY_NAME = "BB" });
            ComList.Add(new COMPANY() { COMPANY_ID = 03, COPANY_NAME = "CC" });
            combCompanyName.DataSource = ComList;
            combCompanyName.ValueMember = "COMPANY_ID";
            combCompanyName.DisplayMember = "COPANY_NAME";

            List<CARD_TYPE> TypeList = new List<CARD_TYPE>();
            TypeList.Add(new CARD_TYPE() { CARD_TYPE_ID = 01, CARD_TYPE_NAME = "TypeOne" });
            TypeList.Add(new CARD_TYPE() { CARD_TYPE_ID = 02, CARD_TYPE_NAME = "TypeTwo" });
            TypeList.Add(new CARD_TYPE() { CARD_TYPE_ID = 03, CARD_TYPE_NAME = "TypeThree" });
            combobCardType.DataSource = TypeList;
            combobCardType.ValueMember   = "CARD_TYPE_ID";
            combobCardType.DisplayMember ="CARD_TYPE_NAME";
            LoadGridandFormControl();

            //DataGridViewDesign.
            //dgrDesign();
            //OracleCon.Close();
        }
        private void combCompanyName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

        }
        

        //public void dgrDesign(DataGridView dataGridView)
        //{
        //    grdList.EnableHeadersVisualStyles = false;
        //    grdList.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
        //    grdList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    grdList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        //    grdList.DefaultCellStyle.BackColor = Color.DarkGray;
        //}

        private void LoadGridandFormControl()
        {
            OracleCon.Open();
   
                string sql = "Select ID, CUSTOMER_ID,CUSTOMER_NAME,COMPANY_ID, CONTACT_NO,CARD_TYPE,EXPIRE_DATE,ISSUE_DATE,CARD_NO,DOB,ADDRESS,DESIGNATION from  LIB_MEMBERSHIP_CARD_NO";
                OracleCommand OracleCmd = new OracleCommand(sql, OracleCon);
                OracleCmd.CommandType = CommandType.Text;

                OracleDataReader dr = OracleCmd.ExecuteReader();
                List<MemberShip_Card_Master> dataList = new List<MemberShip_Card_Master>();
                while (dr.Read())
                {
                    MemberShip_Card_Master Data = new MemberShip_Card_Master();
                    Data.ID = Convert.ToInt32(dr["ID"].ToString());
                    Data.CUSTOMER_ID = dr["CUSTOMER_ID"] is DBNull ? 0 : Convert.ToInt32(dr["CUSTOMER_ID"]);
                    Data.CUSTOMER_NAME = dr["CUSTOMER_NAME"].ToString();
                    Data.COMPANY_NAME = dr["COMPANY_ID"].ToString();
                    Data.CONTACT_NO = dr["CONTACT_NO"].ToString();
                    Data.CARD_TYPE = dr["CARD_TYPE"].ToString();
                    Data.ISSUE_DATE = dr["ISSUE_DATE"] is DBNull ? (DateTime?)null : Convert.ToDateTime(dr["ISSUE_DATE"]);
                    Data.EXPIRE_DATE = dr["EXPIRE_DATE"] is DBNull ? (DateTime?)null : Convert.ToDateTime(dr["EXPIRE_DATE"]);
                    Data.DOB = dr["DOB"] is DBNull ? (DateTime?)null : Convert.ToDateTime(dr["DOB"]);
                    Data.CARD_NO = dr["CARD_NO"].ToString();
                    Data.ADDRESS = dr["ADDRESS"].ToString();
                    Data.DESIGNATION = dr["DESIGNATION"].ToString();
                    dataList.Add(Data);

                }

                grdList.DataSource = dataList;
                OracleCon.Close();

           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MemberShip_Card_Master Data = new MemberShip_Card_Master();
            Data.CUSTOMER_ID = Convert.ToInt32(txtCust_ID.Text);
            Data.CUSTOMER_NAME = txtCust_Name.Text;
            Data.COMPANY_NAME = combCompanyName.Text;
            Data.CONTACT_NO = txtContactNumber.Text;
            Data.CARD_TYPE = combobCardType.Text;
            Data.EXPIRE_DATE = Convert.ToDateTime(dtExpireDate.Text);
            Data.ISSUE_DATE = Convert.ToDateTime(dtIssueDate.Text);
            Data.CARD_NO = txtCardNo.Text;
            Data.DOB = Convert.ToDateTime(dtDOB.Text);
            Data.ADDRESS = txtAddress.Text;
            Data.DESIGNATION = txtCust_Designation.Text;
            SaveData();


        }
        public void SaveData()
        {
            OracleCon.Open();
            string sql = "SELECT NVL(MAX(P.ID), 0) AS MAX_VAL FROM LIB_MEMBERSHIP_CARD_NO P";
            OracleCommand oracle_cmd = new OracleCommand(sql, OracleCon);
            oracle_cmd.CommandType = CommandType.Text;
            var max_val = oracle_cmd.ExecuteScalar();
            Int64 id = Convert.ToInt64(max_val);
            DataSet ds = new DataSet();
            id++;
             
            
            string query = "Insert into LIB_MEMBERSHIP_CARD_NO ( ID,COMPANY_ID, CUSTOMER_ID ,CUSTOMER_NAME,CONTACT_NO,CARD_TYPE,EXPIRE_DATE,ISSUE_DATE,CARD_NO,DOB,ADDRESS,DESIGNATION) values (" + id+ "," + combCompanyName.SelectedValue + ",'" + txtCust_ID.Text + "','" + txtCust_Name.Text + "','" + txtContactNumber.Text + "'," + combobCardType.SelectedValue + ",'" + dtExpireDate.Text + "','" + dtIssueDate.Text + "','" + txtCardNo.Text + "','" + dtDOB.Text + "','" + txtAddress.Text + "','" + txtCust_Designation.Text + "')";
            OracleDataAdapter sda = new OracleDataAdapter(query, OracleCon);
            sda.SelectCommand.ExecuteNonQuery();

            MessageBox.Show(" Inserted Successfully.");
            LoadGridandFormControl();
            OracleCon.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OracleCon.Open();
           
            string  sql1 = "update LIB_MEMBERSHIP_CARD_NO set COMPANY_ID = "+ combCompanyName .SelectedValue+ ", CUSTOMER_ID = '" + txtCust_ID.Text + "', CUSTOMER_NAME=  '" + txtCust_Name.Text + "', CONTACT_NO= '" + txtContactNumber.Text + "', CARD_TYPE=  " + combobCardType.SelectedValue + ",  EXPIRE_DATE= '" + dtExpireDate.Text + "',  ISSUE_DATE= '" + dtIssueDate.Text + "',CARD_NO= '" + txtCardNo.Text + "', DOB = '" + dtDOB.Text + "' , ADDRESS = '" + txtAddress.Text + "',DESIGNATION = '" + txtCust_Designation.Text + "' where ID  =  '"+txtID.Text+"'" ;
            OracleDataAdapter sda = new OracleDataAdapter(sql1, OracleCon);
            sda.SelectCommand.ExecuteNonQuery();
            LoadGridandFormControl();
            OracleCon.Close();

        }

        private void grdList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtID.Text               = grdList.SelectedRows[0].Cells[0].Value.ToString();
     
            txtCust_ID.Text          = grdList.SelectedRows[0].Cells[2].Value.ToString();
            combCompanyName.Text     = grdList.SelectedRows[0].Cells[1].Value.ToString(); 
            txtCust_Name.Text        = grdList.SelectedRows[0].Cells[3].Value.ToString();
            txtContactNumber.Text   = grdList.SelectedRows[0].Cells[4].Value.ToString();
            combobCardType.Text     = grdList.SelectedRows[0].Cells[5].Value.ToString();
            dtExpireDate.Text       = grdList.SelectedRows[0].Cells[6].Value.ToString();
            dtIssueDate.Text        = grdList.SelectedRows[0].Cells[7].Value.ToString();


            //DateTime dt = DateTime.ParseExact(grdList.CurrentCell.Value.ToString(), "dd-mm-yyyy", CultureInfo.InvariantCulture);
            //dtExpireDate.Value = dt;
            //DateTime dat = DateTime.ParseExact(grdList.CurrentCell.Value.ToString(), "dd-mm-yyyy", CultureInfo.InvariantCulture);
            //dtIssueDate.Value = dat;
            //DateTime datt = DateTime.ParseExact(grdList.CurrentCell.Value.ToString(), "dd-mm-yyyy", CultureInfo.InvariantCulture);
            //dtDOB.Value = datt;


            txtCardNo.Text             = grdList.SelectedRows[0].Cells[8].Value.ToString();
            dtDOB.Text                 = grdList.SelectedRows[0].Cells[9].Value.ToString();
            txtAddress.Text            = grdList.SelectedRows[0].Cells[10].Value.ToString();
            txtCust_Designation.Text   = grdList.SelectedRows[0].Cells[11].Value.ToString();
            btnSaveUpdate.Text = "Update";

        }

        private void grdList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //txtCust_ID.Text = grdList.SelectedRows[0].Cells[0].Value.ToString();
            //combCompanyName.Text = grdList.SelectedRows[0].Cells[1].Value.ToString();
            //txtCust_Name.Text = grdList.SelectedRows[0].Cells[2].Value.ToString();
            //txtContactNumber.Text = grdList.SelectedRows[0].Cells[3].Value.ToString();
            //combobCardType.Text = grdList.SelectedRows[0].Cells[4].Value.ToString();


            ////dtExpireDate.Text       = grdList.SelectedRows[0].Cells[5].Value.ToString();
            //// dtIssueDate.Text        = grdList.SelectedRows[0].Cells[6].Value.ToString();
            ////dtDOB.Text              = grdList.SelectedRows[0].Cells[8].Value.ToString();

            //txtCardNo.Text = grdList.SelectedRows[0].Cells[7].Value.ToString();

            //txtAddress.Text = grdList.SelectedRows[0].Cells[9].Value.ToString();
            //txtCust_Designation.Text = grdList.SelectedRows[0].Cells[10].Value.ToString();


            //DateTime dt = DateTime.ParseExact(grdList.CurrentCell.Value.ToString(), "dd-mm-yyyy", CultureInfo.InvariantCulture);
            //dtExpireDate.Value = dt;
            //DateTime dat = DateTime.ParseExact(grdList.CurrentCell.Value.ToString(), "dd-mm-yyyy", CultureInfo.InvariantCulture);
            //dtIssueDate.Value = dat;
            //DateTime datt = DateTime.ParseExact(grdList.CurrentCell.Value.ToString(), "dd-mm-yyyy", CultureInfo.InvariantCulture);
            //dtDOB.Value = datt;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //txtCust_ID.Text = "";
            //combCompanyName.Text = "";
            //txtCust_Name.Text = "";
            //txtContactNumber.Text = "";
            //combobCardType.Text = "";
            //dtExpireDate.Text = "";
            //dtIssueDate.Text = "";
            //txtCardNo.Text = "";
            //dtDOB.Text = "";
            //txtAddress.Text = "";
            //txtCust_Designation.Text = "";
            Clear();

        }

        MemberShip_Card_Master Data = new MemberShip_Card_Master();
        public void Clear()
        {
            txtID.Text = "";
            txtCust_ID.Text = "";
            combCompanyName.Text = "";
            txtCust_Name.Text = "";
            txtContactNumber.Text = "";
            combobCardType.Text = "";
            dtExpireDate.Text = "";
            dtIssueDate.Text = "";
            txtCardNo.Text = "";
            dtDOB.Text = "";
            txtAddress.Text = "";
            txtCust_Designation.Text = "";
            btnSaveUpdate.Text = "Save";
            Data.ID = 0;

        }
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                MemberShip_Card_Master Data = new MemberShip_Card_Master();
                Data.ID = (txtID.Text != "") ? Convert.ToInt32(txtID.Text) : 0;
                Data.CUSTOMER_ID = Convert.ToInt32(txtCust_ID.Text);
                Data.CUSTOMER_NAME = txtCust_Name.Text;
                Data.COMPANY_NAME = combCompanyName.Text;
                Data.CONTACT_NO = txtContactNumber.Text;
                Data.CARD_TYPE = combobCardType.Text;
                Data.EXPIRE_DATE = Convert.ToDateTime(dtExpireDate.Text);
                Data.ISSUE_DATE = Convert.ToDateTime(dtIssueDate.Text);
                Data.CARD_NO = txtCardNo.Text;
                Data.DOB = Convert.ToDateTime(dtDOB.Text);
                Data.ADDRESS = txtAddress.Text;
                Data.DESIGNATION = txtCust_Designation.Text;

                if (Data.ID == 0)
                {
                    OracleCon.Open();
                    string sql = "SELECT NVL(MAX(P.ID), 0) AS MAX_VAL FROM LIB_MEMBERSHIP_CARD_NO P";
                    OracleCommand oracle_cmd = new OracleCommand(sql, OracleCon);
                    oracle_cmd.CommandType = CommandType.Text;
                    var max_val = oracle_cmd.ExecuteScalar();
                    Int64 id = Convert.ToInt64(max_val);
                    DataSet ds = new DataSet();
                    id++;
                    //string query = "Insert into LIB_MEMBERSHIP_CARD_NO ( ID,COMPANY_ID, CUSTOMER_NAME,CONTACT_NO,CARD_TYPE,EXPIRE_DATE,ISSUE_DATE,CARD_NO,DOB,ADDRESS) values(({0},{1},{2},{3},{4},{5},{6},{7},'{8}','{9}'"), id,'" + txtCust_Name.Text + "','" + txtContactNumber.Text + "','" + combobCardType.Text + "''" + dtExpireDate.Text + "','" + dtIssueDate.Text + "','" + txtCardNo.Text + "','" + dtDOB.Text + "','" + txtAddress.Text + "','" + txtCust_Designation.Text + "')";
                    string query = "Insert into LIB_MEMBERSHIP_CARD_NO ( ID,COMPANY_ID, CUSTOMER_ID ,CUSTOMER_NAME,CONTACT_NO,CARD_TYPE,EXPIRE_DATE,ISSUE_DATE,CARD_NO,DOB,ADDRESS,DESIGNATION) values (" + id + "," + combCompanyName.SelectedValue + ",'" + txtCust_ID.Text + "','" + txtCust_Name.Text + "','" + txtContactNumber.Text + "'," + combobCardType.SelectedValue + ",'" + dtExpireDate.Text + "','" + dtIssueDate.Text + "','" + txtCardNo.Text + "','" + dtDOB.Text + "','" + txtAddress.Text + "','" + txtCust_Designation.Text + "')";
                    OracleDataAdapter sda = new OracleDataAdapter(query, OracleCon);
                    sda.SelectCommand.ExecuteNonQuery();
                    OracleCon.Close();
                    MessageBox.Show(" Inserted Successfully.");
                    LoadGridandFormControl();

                }
                else 
                {
                    string sql1 = "update LIB_MEMBERSHIP_CARD_NO set COMPANY_ID = " + combCompanyName.SelectedValue + ", CUSTOMER_ID = '" + txtCust_ID.Text + "', CUSTOMER_NAME=  '" + txtCust_Name.Text + "', CONTACT_NO= '" + txtContactNumber.Text + "', CARD_TYPE=  " + combobCardType.SelectedValue + ",  EXPIRE_DATE= '" + dtExpireDate.Text + "',  ISSUE_DATE= '" + dtIssueDate.Text + "',CARD_NO= '" + txtCardNo.Text + "', DOB = '" + dtDOB.Text + "' , ADDRESS = '" + txtAddress.Text + "',DESIGNATION = '" + txtCust_Designation.Text + "' where ID  =  '" + txtID.Text + "'";

                    OracleDataAdapter sda = new OracleDataAdapter(sql1, OracleCon);
                    OracleCon.Open();
                    sda.SelectCommand.ExecuteNonQuery();
                    OracleCon.Close();
                    LoadGridandFormControl();
                }
                
                
            }
            catch(Exception ex)
            {
                // LoadGridandFormControl();
                MessageBox.Show(ex.ToString()); ;
            }
             
            OracleCon.Close();


        }
    }
}
