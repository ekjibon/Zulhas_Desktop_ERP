using Oracle.ManagedDataAccess.Client;
using POS_Gentle_Park.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Gentle_Park
{
    public partial class frmSalesInvoice : Form
    {
        static string OracleConString = "Data Source = (DESCRIPTION =  (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.11.250)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = ORCL) ) );User Id = RETAILERP;password = RETAILERP;";
        static OracleConnection OracleCon = new OracleConnection(OracleConString);
        public frmSalesInvoice()
        {
            InitializeComponent();
        }

        private void btnGridLoad_Click(object sender, EventArgs e)
        {
            List<PRODUCTS> prod = new List<PRODUCTS>();
            grdProducts.DataSource = prod;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSalesInvoice_Load(object sender, EventArgs e)
        {
            DataTable dtData = new DataTable();
            // add columns  
            dtData.Columns.Add("PRODUC CODE", typeof(int));
            dtData.Columns.Add("PRODUCT DESCRIPTION", typeof(string));
            dtData.Columns.Add("QUANTITY", typeof(decimal));
            dtData.Columns.Add("DISCOUNT", typeof(int));
            dtData.Columns.Add("PRICE", typeof(decimal));

            dtData.Rows.Add(1, "", 0, 0, 0);
            //List<PRODUCTS> prod = new List<PRODUCTS>();
            //var dataTable = new DataTable();

            grdProducts.DataSource = dtData;
            //grdProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //grdProducts.Rows.Add(5);
            //grdProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //grdProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            try
            {
                if (OracleCon.State == ConnectionState.Closed)
                {
                    OracleCon.Open();
                }

                string sql = "select id, customer_name, company_id, customer_id, card_no, discount, branch_name, contact_no, designation,designation_id,contact_person,address,status_active from lib_membership_card_no  where entry_form = 612";
                OracleCommand OracleCmd = new OracleCommand(sql, OracleCon);
                OracleCmd.CommandType = CommandType.Text;

                OracleDataReader dr = OracleCmd.ExecuteReader();


                List<USER_VM> users = new List<USER_VM>();
                while (dr.Read())
                {
                    USER_VM user = new USER_VM();
                    user.USER_ID = Convert.ToInt32(dr["id"]);
                    user.USER_NAME = dr["customer_name"].ToString();
                    users.Add(user);
                }

                cmbUser.DataSource = users.ToList();
                cmbUser.DisplayMember = "USER_NAME";
                cmbUser.ValueMember = "USER_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured!");
            }
            finally
            {
                OracleCon.Close();
            }
        }

        private void txtCustomerCardNumber_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtCustomerCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                CUSTOMER_VM customer = getCustomerDetails(txtCustomerCardNumber.Text);
                if (customer != null)
                {
                    txtCustomerName.Text = customer.CUSTOMER_NAME;
                    txtAddress.Text = customer.ADDRESS;
                    txtCustomerId.Text = customer.CUSTOMER_ID.ToString();
                    txtCustomerContactNo.Text = customer.CONTACT_NO.ToString();
                    txtCustomarDiscount.Text = customer.DISCOUNT.ToString(); 
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }

        private CUSTOMER_VM getCustomerDetails(string customer_id)
        {
            CUSTOMER_VM customer = new CUSTOMER_VM();
            try
            {
                if (OracleCon.State == ConnectionState.Closed)
                {
                    OracleCon.Open();
                }

                string sql = "select id, customer_name, company_id, customer_id, card_no, discount, branch_name, contact_no, designation,designation_id,contact_person,address,status_active from lib_membership_card_no  where entry_form = 612 and card_no = "+customer_id+"";
                OracleCommand OracleCmd = new OracleCommand(sql, OracleCon);
                OracleCmd.CommandType = CommandType.Text;

                OracleDataReader dr = OracleCmd.ExecuteReader();

                while (dr.Read())
                {

                    customer.CUSTOMER_NAME = dr["CUSTOMER_NAME"].ToString();
                    customer.CONTACT_NO = Convert.ToInt64(dr["CONTACT_NO"].ToString());
                    customer.CUSTOMER_NAME = dr["CUSTOMER_NAME"].ToString();
                    customer.ADDRESS = dr["ADDRESS"].ToString();
                    customer.CUSTOMER_ID = Convert.ToInt32(dr["CUSTOMER_ID"].ToString());
                    customer.DISCOUNT = Convert.ToInt32(dr["DISCOUNT"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured!");
                throw;
            }
            finally
            {
                OracleCon.Close();
            }

            return customer;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            List<PRODUCTS> prod = new List<PRODUCTS>();
            DataTable dtData = new DataTable();
            // add columns  
            dtData.Columns.Add("PRODUC CODE", typeof(int));
            dtData.Columns.Add("PRODUCT DESCRIPTION", typeof(string));
            dtData.Columns.Add("QUANTITY", typeof(decimal));
            dtData.Columns.Add("DISCOUNT", typeof(int));
            dtData.Columns.Add("PRICE", typeof(decimal));

            dtData.Rows.Add(1, "New 2", 0, 0, 0);
            //this.grdProducts.Rows.Insert(1, "New 1", 0, 0, 0);
            

            grdProducts.DataSource = dtData;
        }
    }
}
