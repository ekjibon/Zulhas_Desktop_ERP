namespace POS_Gentle_Park
{
    partial class frmStockChecking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockChecking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblReceiveProduct = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnGridLoad = new System.Windows.Forms.Button();
            this.grdStockChecking = new System.Windows.Forms.DataGridView();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockChecking)).BeginInit();
            this.pnlFill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReceiveProduct
            // 
            this.lblReceiveProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReceiveProduct.AutoSize = true;
            this.lblReceiveProduct.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblReceiveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lblReceiveProduct.Location = new System.Drawing.Point(329, 5);
            this.lblReceiveProduct.Name = "lblReceiveProduct";
            this.lblReceiveProduct.Size = new System.Drawing.Size(150, 25);
            this.lblReceiveProduct.TabIndex = 0;
            this.lblReceiveProduct.Text = "Stock Checking";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Image = global::POS_Gentle_Park.Properties.Resources.Crossbtn17;
            this.button5.Location = new System.Drawing.Point(1, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 31);
            this.button5.TabIndex = 7;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 34);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 483);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 44);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPlaylist);
            this.panel4.Controls.Add(this.btnGridLoad);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(505, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 44);
            this.panel4.TabIndex = 0;
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
            // grdStockChecking
            // 
            this.grdStockChecking.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.grdStockChecking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStockChecking.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdStockChecking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStockChecking.Location = new System.Drawing.Point(0, 0);
            this.grdStockChecking.Name = "grdStockChecking";
            this.grdStockChecking.Size = new System.Drawing.Size(825, 206);
            this.grdStockChecking.TabIndex = 0;
            this.grdStockChecking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTransactionPending_CellContentClick);
            this.grdStockChecking.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTransactionPending_CellLeave);
            this.grdStockChecking.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdTransactionPending_CellValidating);
            this.grdStockChecking.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTransactionPending_CellValueChanged);
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlFill.Controls.Add(this.panel2);
            this.pnlFill.Controls.Add(this.panel7);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 34);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(825, 449);
            this.pnlFill.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdStockChecking);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 206);
            this.panel2.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtSearch);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(825, 90);
            this.panel7.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(121, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(229, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // frmStockChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(825, 527);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblReceiveProduct);
            this.Controls.Add(this.panel1);
            this.Name = "frmStockChecking";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmReceiveProduct_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStockChecking)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceiveProduct;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnGridLoad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView grdStockChecking;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}