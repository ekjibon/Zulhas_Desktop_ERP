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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            //panelMediaSubMenu.Visible = false;
            //panelPlaylistSubMenu.Visible = false;
            //panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReceiveProduct());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSalesInvoice());
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
             openChildForm(new frmSalesReturn());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBranchToCentralStore());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //btnMenuShow.FlatStyle = FlatStyle.Flat;
            //btnMenuShow.FlatAppearance.BorderSize = 0;
            //BtnMenuHide.FlatStyle = FlatStyle.Flat;
            //BtnMenuHide.FlatAppearance.BorderSize = 0;
        }

        private void btnMenuShow_Click(object sender, EventArgs e)
        {
           // btnMenuShow.Hide();
           // BtnMenuHide.Show();
            //panelSideMenu.Show();
           
        }

        private void BtnMenuHide_Click(object sender, EventArgs e)
        {
            //BtnMenuHide.Hide();
           // btnMenuShow.Show();
           //panelSideMenu.Hide();

           
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //btnmenushow.hide();
            //btnmenuhide.show();
            Side_Menu_panel.Hide();
            Side_Menu_panel.Show();
           
            if (Side_Menu_panel.Width == 220)
            {
                Side_Menu_panel.Width = 0;
            }
            else
            {
                Side_Menu_panel.Width = 220;
            }

        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReceiveProduct());
        }

        private void btnSalesInvoice_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSalesInvoice());
        }

        private void btnSalesReturn_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSalesReturn());
        }

        private void btnAdvancebooking_Click(object sender, EventArgs e)
        {
           openChildForm(new frmAdvanceBooking());
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMembershipCard());
        }
    }
}
