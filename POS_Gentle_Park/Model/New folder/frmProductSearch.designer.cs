namespace POS_Gentle_Park
{
    partial class frmProductSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductSearch));
            this.lblReceiveProduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtReturnID = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblReturnID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.grdBranchToCentralStore = new System.Windows.Forms.DataGridView();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnGridLoad = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBranchToCentralStore)).BeginInit();
            this.pnlFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReceiveProduct
            // 
            this.lblReceiveProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReceiveProduct.AutoSize = true;
            this.lblReceiveProduct.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblReceiveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lblReceiveProduct.Location = new System.Drawing.Point(382, 5);
            this.lblReceiveProduct.Name = "lblReceiveProduct";
            this.lblReceiveProduct.Size = new System.Drawing.Size(147, 25);
            this.lblReceiveProduct.TabIndex = 0;
            this.lblReceiveProduct.Text = "Product Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 34);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 311);
            this.panel2.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.dtDate);
            this.panel5.Controls.Add(this.txtNote);
            this.panel5.Controls.Add(this.txtReason);
            this.panel5.Controls.Add(this.txtReturnID);
            this.panel5.Controls.Add(this.lblNote);
            this.panel5.Controls.Add(this.lblReason);
            this.panel5.Controls.Add(this.lblReturnID);
            this.panel5.Controls.Add(this.lblDate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(468, 311);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product searching for the selected product code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(134, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product Search Form";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(204, 123);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(257, 20);
            this.dtDate.TabIndex = 1;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(204, 193);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(257, 20);
            this.txtNote.TabIndex = 4;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(204, 170);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(257, 20);
            this.txtReason.TabIndex = 3;
            // 
            // txtReturnID
            // 
            this.txtReturnID.Location = new System.Drawing.Point(204, 146);
            this.txtReturnID.Name = "txtReturnID";
            this.txtReturnID.Size = new System.Drawing.Size(257, 20);
            this.txtReturnID.TabIndex = 2;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNote.Location = new System.Drawing.Point(23, 193);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(143, 20);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Sub Style Name";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReason.Location = new System.Drawing.Point(23, 170);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(105, 20);
            this.lblReason.TabIndex = 2;
            this.lblReason.Text = "Style Name";
            // 
            // lblReturnID
            // 
            this.lblReturnID.AutoSize = true;
            this.lblReturnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReturnID.Location = new System.Drawing.Point(23, 147);
            this.lblReturnID.Name = "lblReturnID";
            this.lblReturnID.Size = new System.Drawing.Size(175, 20);
            this.lblReturnID.TabIndex = 1;
            this.lblReturnID.Text = "Barcode/Product ID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(23, 123);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(931, 44);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPlaylist);
            this.panel4.Controls.Add(this.btnGridLoad);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(611, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 44);
            this.panel4.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.grdBranchToCentralStore);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(931, 104);
            this.panel7.TabIndex = 1;
            // 
            // grdBranchToCentralStore
            // 
            this.grdBranchToCentralStore.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.grdBranchToCentralStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBranchToCentralStore.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdBranchToCentralStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBranchToCentralStore.Location = new System.Drawing.Point(0, 0);
            this.grdBranchToCentralStore.Name = "grdBranchToCentralStore";
            this.grdBranchToCentralStore.Size = new System.Drawing.Size(931, 104);
            this.grdBranchToCentralStore.TabIndex = 0;
            this.grdBranchToCentralStore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTransactionPending_CellContentClick);
            this.grdBranchToCentralStore.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTransactionPending_CellLeave);
            this.grdBranchToCentralStore.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdTransactionPending_CellValidating);
            this.grdBranchToCentralStore.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTransactionPending_CellValueChanged);
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlFill.Controls.Add(this.panel7);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 345);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(931, 104);
            this.pnlFill.TabIndex = 11;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.Gray;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.Location = new System.Drawing.Point(191, 7);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(126, 31);
            this.btnPlaylist.TabIndex = 4;
            this.btnPlaylist.Text = "  RECEIVE";
            this.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylist.UseVisualStyleBackColor = false;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnGridLoad
            // 
            this.btnGridLoad.BackColor = System.Drawing.Color.Gray;
            this.btnGridLoad.FlatAppearance.BorderSize = 0;
            this.btnGridLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnGridLoad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGridLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGridLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGridLoad.ForeColor = System.Drawing.Color.White;
            this.btnGridLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnGridLoad.Image")));
            this.btnGridLoad.Location = new System.Drawing.Point(59, 7);
            this.btnGridLoad.Name = "btnGridLoad";
            this.btnGridLoad.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGridLoad.Size = new System.Drawing.Size(126, 31);
            this.btnGridLoad.TabIndex = 5;
            this.btnGridLoad.Text = "  LOAD";
            this.btnGridLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGridLoad.UseVisualStyleBackColor = false;
            this.btnGridLoad.Click += new System.EventHandler(this.btnGridLoad_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Image = global::POS_Gentle_Park.Properties.Resources.Crossbtn14;
            this.button5.Location = new System.Drawing.Point(1, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 31);
            this.button5.TabIndex = 7;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(931, 493);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblReceiveProduct);
            this.Controls.Add(this.panel1);
            this.Name = "frmProductSearch";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmReceiveProduct_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBranchToCentralStore)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceiveProduct;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnGridLoad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtReturnID;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblReturnID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView grdBranchToCentralStore;
        private System.Windows.Forms.Panel pnlFill;
    }
}