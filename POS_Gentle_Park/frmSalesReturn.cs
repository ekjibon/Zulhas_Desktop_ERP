using Oracle.ManagedDataAccess.Client;
using POS_Gentle_Park.Model;
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

namespace POS_Gentle_Park
{
    public partial class frmSalesReturn : Form
    {
        //static string OracleConString = "Data Source = (DESCRIPTION =  (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.11.250)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = ORCL) ) );User Id = RETAILERP;password = RETAILERP;";
        static string OracleConString = "Data Source = (DESCRIPTION =  (ADDRESS = (PROTOCOL = TCP)(HOST = 59.152.60.147)(PORT = 15252)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = ORCL) ) );User Id = RETAILERP;password = RETAILERP;";
        static OracleConnection OracleCon = new OracleConnection(OracleConString);
        public frmSalesReturn()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceiveProduct_Load(object sender, EventArgs e)
        {
            if (OracleCon.State == ConnectionState.Closed)
            {
                OracleCon.Open();
            }
            LoadGridandFormControl();
            OracleCon.Close();
        }

        private void LoadGridandFormControl()
        {
           // txtReceiveId.Text = "RCV-" + DateTime.Now.ToString("yyyymmddhhmmss");
            //txtChallanNo.Text = "";
            //txtParticulars.Text = "";
            string sql = "select ID, STYLE_NAME, SUB_STYLE_NAME, ERP_TRASFER_STOCK, POS_STORE_RECEIVE_QTY, SALES_PRICE, PROD_ID, COLOR_NAME, SIZE_NAME, STOCK_VALUE, STORE_ID, BRANCH_ID, POS_RECEIVE_STATUS, CHALLAN_NO from pos_store_stock_qty where POS_RECEIVE_STATUS != 2 and BRANCH_ID = " + session_variable.BRANCH_ID + "";
            OracleCommand OracleCmd = new OracleCommand(sql, OracleCon);
            OracleCmd.CommandType = CommandType.Text;

            OracleDataReader dr = OracleCmd.ExecuteReader();

            try
            {
                List<POS_TRANSACTION_RECEIVE_VM> datas = new List<POS_TRANSACTION_RECEIVE_VM>();
                //POS_TRANSACTION_RECEIVE_VM data = new POS_TRANSACTION_RECEIVE_VM();
                while (dr.Read())
                {
                    POS_TRANSACTION_RECEIVE_VM data = new POS_TRANSACTION_RECEIVE_VM();
                    //if (dr["POS_RECEIVE_STOCK"] == DBNull.Value) //which is working properly
                    //{
                    //    data.REC_QUANTITY = 0;
                    //}


                    data.Check = false;
                    data.ID = Convert.ToInt32(dr["ID"]);
                    data.COLOR_NAME = dr["COLOR_NAME"].ToString();
                    data.STYLE_NAME = dr["STYLE_NAME"].ToString();
                    data.PROD_ID = Convert.ToInt32(dr["PROD_ID"]);
                    data.STORE_ID = Convert.ToInt32(dr["STORE_ID"]);
                    data.BRANCH_ID = Convert.ToInt32(dr["BRANCH_ID"]);
                    data.ITEM_SIZE = dr["SIZE_NAME"].ToString();
                    data.SUB_STYLE_NAME = dr["SUB_STYLE_NAME"].ToString();
                    data.CONS_QUANTITY = Convert.ToInt32(dr["ERP_TRASFER_STOCK"]);
                    data.SALES_RATE = Convert.ToDecimal(dr["SALES_PRICE"]);
                    data.SALES_AMOUNT = 0; //Convert.ToDecimal(dr["STOCK_VALUE"]);
                    data.CHALLAN_NO = dr["CHALLAN_NO"].ToString();
                    data.PREV_REC_QUANTITY = Convert.ToInt32(dr["POS_STORE_RECEIVE_QTY"] is DBNull ? 0 : Convert.ToInt32(dr["POS_STORE_RECEIVE_QTY"]));
                    data.CURR_REC_QUANTITY = 0;
                    datas.Add(data);
                }

                grdPR.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                //grdTransactionPending.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                grdPR.DataSource = null;

                if (datas.Count > 0)
                {
                    
                    grdPR.DataSource = datas;

                    for (int i = 0; i < grdPR.Columns.Count; i++)
                    {
                        //if (i != 0)
                            //grdTransactionPending.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }


                    grdPR.Columns["Check"].Width = 20;
                    grdPR.Columns["CHALLAN_NO"].Width = 100;
                    grdPR.Columns["STYLE_NAME"].Width = 120;
                    grdPR.Columns["SUB_STYLE_NAME"].Width = 120;
                    grdPR.Columns["COLOR_NAME"].Width = 90;
                    grdPR.Columns["ITEM_SIZE"].Width = 70;
                    grdPR.Columns["CONS_QUANTITY"].Width = 95;
                    grdPR.Columns["PREV_REC_QUANTITY"].Width = 100;
                    grdPR.Columns["CURR_REC_QUANTITY"].Width = 100;
                    grdPR.Columns["SALES_RATE"].Width = 120;
                    grdPR.Columns["SALES_AMOUNT"].Width = 120;
                    //grdTransactionPending.Columns["SUB_STYLE_NAME"].Width = 120;
                    //grdTransactionPending.Columns["SUB_STYLE_NAME"].Width = 120;

                    grdPR.Columns["ID"].Visible = false;
                    grdPR.Columns["SUB_STYLE_ID"].Visible = false;
                    grdPR.Columns["STYLE_ID"].Visible = false;
                    grdPR.Columns["PROD_ID"].Visible = false;
                    grdPR.Columns["STORE_ID"].Visible = false;
                    grdPR.Columns["BRANCH_ID"].Visible = false;
                    grdPR.Columns["PREV_REC_QUANTITY"].ReadOnly = true;
                    grdPR.Columns["STYLE_NAME"].ReadOnly = true;
                    grdPR.Columns["SUB_STYLE_NAME"].ReadOnly = true;
                    
                    grdPR.Columns["CONS_QUANTITY"].ReadOnly = true;
                    grdPR.Columns["CONS_QUANTITY"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    grdPR.Columns["SALES_RATE"].ReadOnly = true;
                    grdPR.Columns["SALES_RATE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    grdPR.Columns["SALES_AMOUNT"].ReadOnly = true;
                    grdPR.Columns["SALES_AMOUNT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    grdPR.Columns["PREV_REC_QUANTITY"].ReadOnly = true;
                    grdPR.Columns["PREV_REC_QUANTITY"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //grdTransactionPending.Columns["CURR_REC_QUANTITY"].ReadOnly = true;
                    grdPR.Columns["CURR_REC_QUANTITY"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //grdTransactionPending.BorderStyle = BorderStyle.None;
                    ////grdTransactionPending.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                    //grdTransactionPending.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
                    //grdTransactionPending.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                    //grdTransactionPending.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                    //grdTransactionPending.BackgroundColor = Color.White;

                    //grdTransactionPending.EnableHeadersVisualStyles = false;
                    //grdTransactionPending.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    //grdTransactionPending.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                    //grdTransactionPending.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                    //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    //chk.HeaderText = " ";
                    //chk.Name = "Checkbox";
                    //grdTransactionPending.Columns.Add(chk);

                    //grdTransactionPending.Columns["Checkbox"].DefaultCellStyle.NullValue = false;

                }



            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dr.Close();
                OracleCon.Close();
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            
            List<POS_TRANSACTION_RECEIVE_VM> datas = new List<POS_TRANSACTION_RECEIVE_VM>();
            //if(txtChallanNo.Text.Trim() == "")
            //{
            //    MessageBox.Show("Challan no is empty!");
            //    return;
            //}
            foreach (DataGridViewRow row in grdPR.Rows)
            {
                POS_TRANSACTION_RECEIVE_VM data = new POS_TRANSACTION_RECEIVE_VM();
                if ((bool)row.Cells["Check"].Value == true)
                {
                    data.ID = (int)row.Cells["ID"].Value;
                    data.BRANCH_ID = session_variable.BRANCH_ID;
                    data.CHALLAN_NO = row.Cells["CHALLAN_NO"].Value.ToString();
                    //data.SUB_STYLE_ID = (int)row.Cells["SUB_STYLE_ID"].Value;
                    data.STYLE_NAME = row.Cells["STYLE_NAME"].Value.ToString();
                    data.SUB_STYLE_NAME = row.Cells["SUB_STYLE_NAME"].Value.ToString();
                    data.CONS_QUANTITY = (int)row.Cells["CONS_QUANTITY"].Value;
                    data.SALES_RATE = (decimal)row.Cells["SALES_RATE"].Value;
                    data.SALES_AMOUNT = (decimal)row.Cells["SALES_AMOUNT"].Value;
                    data.PROD_ID = (int)row.Cells["PROD_ID"].Value;
                    data.STORE_ID = (int)row.Cells["STORE_ID"].Value;
                    data.PREV_REC_QUANTITY = (decimal)row.Cells["PREV_REC_QUANTITY"].Value;
                    data.BRANCH_ID = (int)row.Cells["BRANCH_ID"].Value;
                    data.CURR_REC_QUANTITY = (decimal)row.Cells["CURR_REC_QUANTITY"].Value;
                    if(data.CURR_REC_QUANTITY <= 0)
                    {
                        MessageBox.Show("Please enter some value in Current Receive Quantity field!");
                        return;
                    }
                    if ((data.PREV_REC_QUANTITY + data.CURR_REC_QUANTITY) > data.CONS_QUANTITY)
                    {
                        MessageBox.Show("Receive quantity should not be higher than the quantity");
                        return;
                    }

                    datas.Add(data);
                }
            }

            if (OracleCon.State == ConnectionState.Closed)
            {
                OracleCon.Open();
            }
            string sql = "SELECT NVL(MAX(P.ID), 0) AS MAX_VAL FROM POS_TRANSACTION_RECEIVE P";
            OracleCommand oracle_cmd = new OracleCommand(sql, OracleCon);
            oracle_cmd.CommandType = CommandType.Text;
            var max_val = oracle_cmd.ExecuteScalar();
            Int64 id = Convert.ToInt64(max_val);

            DataSet ds = new DataSet();


            if (datas.Count > 0)
            {
                foreach (var insert in datas)
                {
                    //new entry in POS_TRANSACTION_RECEIVE table
                    if (insert.CURR_REC_QUANTITY <= insert.CONS_QUANTITY && insert.CURR_REC_QUANTITY > 0)
                    {
                        id++;
                        //sql = String.Format("insert into POS_TRANSACTION_RECEIVE (ID, CONS_QUANTITY,POS_RECEIVE_QNTY, SALES_RATE, SALES_AMOUNT, PROD_ID, STORE_ID,POS_DATE, POS_RECEIVE_ID, POS_CHALLAN_NO, POS_PARTICULAERS, STORE_TO_BRANCH_ID, STORE_STOCK_DETAILS_ID) values ({0},{1},{2},{3},{4},{5},{6},TO_DATE('{7}'),'{8}','{9}','{10}', {11},{12})", id,  insert.CONS_QUANTITY,  insert.CURR_REC_QUANTITY, insert.SALES_RATE, (insert.CURR_REC_QUANTITY * insert.SALES_RATE), insert.PROD_ID, insert.STORE_ID, dtRecDate.Value.ToString("dd-MMM-yyyy"), txtReceiveId.Text, insert.CHALLAN_NO, txtParticulars.Text, insert.BRANCH_ID,insert.ID);
                        //sql = "insert into POS_TRANSACTION_RECEIVE (ID,STYLE_ID, SUB_STYLE_ID, CONS_QUANTITY, SALES_RATE, SALES_AMOUNT, PROD_ID, STORE_ID) values (" + id+","+insert.STYLE_ID+","+insert.SUB_STYLE_ID+","+insert.CONS_QUANTITY+","+insert.SALES_RATE+","+insert.SALES_AMOUNT+","+insert.PROD_ID+","+insert.PROD_ID+")";
                        oracle_cmd = new OracleCommand(sql, OracleCon);
                        oracle_cmd.CommandType = CommandType.Text;
                        OracleDataAdapter adapter = new OracleDataAdapter(oracle_cmd);
                        adapter.Fill(ds);

                        if(insert.CONS_QUANTITY == (insert.CURR_REC_QUANTITY + insert.PREV_REC_QUANTITY))
                        {
                            ////quantity needed to be changed in master stock and global stock
                            sql = String.Format("update pos_store_stock_qty set POS_RECEIVE_STATUS = 2, POS_STORE_RECEIVE_QTY = {0} where ID = {1} ",(insert.PREV_REC_QUANTITY + insert.CURR_REC_QUANTITY), insert.ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;

                            adapter = new OracleDataAdapter(oracle_cmd);
                            ds = new DataSet();
                            adapter.Fill(ds);

                            sql = String.Format("Select POS_TRANSFER_QTY from INV_GARMENTS_STORE_WISE_QTY where PROD_ID={0} and STORE_ID={1} ", insert.PROD_ID, insert.STORE_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;
                            decimal? PREV_POS_TRANSFER_QTY = oracle_cmd.ExecuteScalar().ToDecimal();

                            sql = String.Format("update INV_GARMENTS_STORE_WISE_QTY set POS_RECEIVE_STATUS = 2, POS_TRANSFER_QTY = {0} where PROD_ID={1} and STORE_ID={2} ", (insert.CURR_REC_QUANTITY + PREV_POS_TRANSFER_QTY), insert.PROD_ID, insert.STORE_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;

                            adapter = new OracleDataAdapter(oracle_cmd);
                            ds = new DataSet();
                            adapter.Fill(ds);

                            sql = String.Format("Select NVL(POS_TRANSFER_QTY,0)  POS_TRANSFER_QTY from PRODUCT_DETAILS_MASTER where ID={0} ", insert.PROD_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;
                            PREV_POS_TRANSFER_QTY = oracle_cmd.ExecuteScalar().ToDecimal();

                            sql = String.Format("update PRODUCT_DETAILS_MASTER set POS_RECEIVE_STATUS = 2, POS_TRANSFER_QTY = {0} where ID={1}", (insert.CURR_REC_QUANTITY + PREV_POS_TRANSFER_QTY), insert.PROD_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;

                            adapter = new OracleDataAdapter(oracle_cmd);
                            ds = new DataSet();
                            adapter.Fill(ds);
                        }
                        else
                        {

                            //quantity needed to be changed in master stock and global stock
                            sql = String.Format("update pos_store_stock_qty set POS_RECEIVE_STATUS = 1, POS_STORE_RECEIVE_QTY = {0} where ID = {1} ", (insert.PREV_REC_QUANTITY + insert.CURR_REC_QUANTITY), insert.ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;

                            adapter = new OracleDataAdapter(oracle_cmd);
                            ds = new DataSet();
                            adapter.Fill(ds);

                            sql = String.Format("Select NVL(POS_TRANSFER_QTY,0)  POS_TRANSFER_QTY from INV_GARMENTS_STORE_WISE_QTY where PROD_ID={0} and STORE_ID={1} ", insert.PROD_ID, insert.STORE_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;
                            decimal? PREV_POS_TRANSFER_QTY = oracle_cmd.ExecuteScalar().ToDecimal();
                            
                            sql = String.Format("update INV_GARMENTS_STORE_WISE_QTY set POS_RECEIVE_STATUS = 1, POS_TRANSFER_QTY = {0} where PROD_ID={1} and STORE_ID={2} ", (insert.CURR_REC_QUANTITY + PREV_POS_TRANSFER_QTY), insert.PROD_ID, insert.STORE_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;

                            adapter = new OracleDataAdapter(oracle_cmd);
                            ds = new DataSet();
                            adapter.Fill(ds);

                            sql = String.Format("Select NVL(POS_TRANSFER_QTY,0)  POS_TRANSFER_QTY from PRODUCT_DETAILS_MASTER where ID={0} ", insert.PROD_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;
                            PREV_POS_TRANSFER_QTY = oracle_cmd.ExecuteScalar().ToDecimal();

                            sql = String.Format("update PRODUCT_DETAILS_MASTER set POS_RECEIVE_STATUS = 1, POS_TRANSFER_QTY = {0} where ID={1}", (insert.CURR_REC_QUANTITY + PREV_POS_TRANSFER_QTY), insert.PROD_ID, insert.STORE_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;

                            adapter = new OracleDataAdapter(oracle_cmd);
                            ds = new DataSet();
                            adapter.Fill(ds);
                        }
                    }
                    else
                    {
                        /*id++;
                        sql = String.Format("insert into POS_TRANSACTION_RECEIVE (ID, CONS_QUANTITY,POS_RECEIVE_QNTY, SALES_RATE, SALES_AMOUNT, PROD_ID, STORE_ID,POS_DATE, POS_RECEIVE_ID, POS_CHALLAN_NO, POS_PARTICULAERS, STORE_TO_BRANCH_ID) values ({0},{1},{2},{3},{4},{5},{6},TO_DATE('{7}'),'{8}','{9}','{10}', {11})", id, insert.CONS_QUANTITY, insert.CURR_REC_QUANTITY, insert.SALES_RATE, insert.SALES_AMOUNT, insert.PROD_ID, insert.STORE_ID, dtRecDate.Value.ToString("dd-MMM-yyyy"), txtReceiveId.Text, txtChallanNo.Text, txtParticulars.Text, insert.BRANCH_ID);
                        //sql = "insert into POS_TRANSACTION_RECEIVE (ID,STYLE_ID, SUB_STYLE_ID, CONS_QUANTITY, SALES_RATE, SALES_AMOUNT, PROD_ID, STORE_ID) values (" + id+","+insert.STYLE_ID+","+insert.SUB_STYLE_ID+","+insert.CONS_QUANTITY+","+insert.SALES_RATE+","+insert.SALES_AMOUNT+","+insert.PROD_ID+","+insert.PROD_ID+")";
                        oracle_cmd = new OracleCommand(sql, OracleCon);
                        oracle_cmd.CommandType = CommandType.Text;
                        OracleDataAdapter adapter = new OracleDataAdapter(oracle_cmd);
                        adapter.Fill(ds);

                        if (insert.CONS_QUANTITY == insert.PREV_REC_QUANTITY)
                        {
                            ////quantity needed to be changed in master stock and global stock
                            sql = String.Format("update pos_store_stock_qty set POS_RECEIVE_STATUS = 2, POS_STORE_RECEIVE_QTY = {0} where PROD_ID={1} and STORE_ID={2} and BRANCH_ID = {3}", insert.CURR_REC_QUANTITY, insert.PROD_ID, insert.STORE_ID, insert.BRANCH_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;

                            adapter = new OracleDataAdapter(oracle_cmd);
                            ds = new DataSet();
                            adapter.Fill(ds);

                            sql = String.Format("update INV_GARMENTS_STORE_WISE_QTY set POS_RECEIVE_STATUS = 2, POS_TRANSFER_QTY = {0} where PROD_ID={1} and STORE_ID={2}", insert.CURR_REC_QUANTITY, insert.PROD_ID, insert.STORE_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;

                            adapter = new OracleDataAdapter(oracle_cmd);
                            ds = new DataSet();
                            adapter.Fill(ds);

                            sql = String.Format("update PRODUCT_DETAILS_MASTER set POS_RECEIVE_STATUS = 2, POS_TRANSFER_QTY = {0} where PROD_ID={1} and STORE_ID={2}", insert.CURR_REC_QUANTITY, insert.PROD_ID, insert.STORE_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;

                            adapter = new OracleDataAdapter(oracle_cmd);
                            ds = new DataSet();
                            adapter.Fill(ds);
                        }
                        else
                        {

                            //quantity needed to be changed in master stock and global stock
                            sql = String.Format("update pos_store_stock_qty set POS_RECEIVE_STATUS = 1, POS_STORE_RECEIVE_QTY = {0} where PROD_ID={1} and STORE_ID={2} and BRANCH_ID = {3}", insert.CURR_REC_QUANTITY, insert.PROD_ID, insert.STORE_ID, insert.BRANCH_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;

                            adapter = new OracleDataAdapter(oracle_cmd);
                            ds = new DataSet();
                            adapter.Fill(ds);

                            sql = String.Format("update INV_GARMENTS_STORE_WISE_QTY set POS_RECEIVE_STATUS = 1, POS_TRANSFER_QTY = {0} where PROD_ID={1} and STORE_ID={2}", insert.CURR_REC_QUANTITY, insert.PROD_ID, insert.STORE_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;

                            adapter = new OracleDataAdapter(oracle_cmd);
                            ds = new DataSet();
                            adapter.Fill(ds);

                            sql = String.Format("update PRODUCT_DETAILS_MASTER set POS_RECEIVE_STATUS = 1, POS_TRANSFER_QTY = {0} where ID={1}", insert.CURR_REC_QUANTITY, insert.PROD_ID, insert.STORE_ID);
                            oracle_cmd = new OracleCommand(sql, OracleCon);
                            oracle_cmd.CommandType = CommandType.Text;

                            adapter = new OracleDataAdapter(oracle_cmd);
                            ds = new DataSet();
                            adapter.Fill(ds);
                        }*/
                    }
                    
                }

                //foreach (var update in datas)
                //{
                    
                //}

                LoadGridandFormControl();
                OracleCon.Close();
                
                MessageBox.Show("Received Successfully");
            }
            else
            {
                MessageBox.Show("Please select at least one item!");
            }
        }

        private void grdTransactionPending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grdPR.CommitEdit(DataGridViewDataErrorContexts.Commit);
            grdPR.RefreshEdit();
            grdPR.EndEdit();
        }

        private void btnGridLoad_Click(object sender, EventArgs e)
        {
            OracleCon.Open();
            LoadGridandFormControl();
            OracleCon.Close();
        }

        private void grdTransactionPending_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("");
        }

        private void grdTransactionPending_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 9)
            {
                int? quantity = grdPR.Rows[e.RowIndex].Cells["CONS_QUANTITY"].Value.ToInt();
                int curr_quantity = grdPR.Rows[e.RowIndex].Cells["CURR_REC_QUANTITY"].Value.ToInt();
                if(curr_quantity > quantity)
                {
                    MessageBox.Show("Not enogh stock!");
                    return;
                }
                decimal unit_price = grdPR.Rows[e.RowIndex].Cells["SALES_RATE"].Value.ToInt();
                grdPR.Rows[e.RowIndex].Cells["SALES_AMOUNT"].Value = (curr_quantity * unit_price).ToDecimal();
            }
        }

        private void grdTransactionPending_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        //    grdTransactionPending.Rows[e.RowIndex].ErrorText = "";
        //    int newInteger;

        //    if (!int.TryParse(e.FormattedValue.ToString(),
        //out newInteger) || newInteger < 0)
        //    {
        //        e.Cancel = true;
        //        grdTransactionPending.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
        //    }
        }

        private void txtCust_Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
