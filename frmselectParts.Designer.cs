namespace BRSYS
{
    partial class frmselectParts
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
            this.partsgrd = new System.Windows.Forms.DataGridView();
            this.Qtygb = new System.Windows.Forms.GroupBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.salePricetxt = new System.Windows.Forms.TextBox();
            this.SalePricelbl = new System.Windows.Forms.Label();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.quanlbl = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Parttxt = new System.Windows.Forms.TextBox();
            this.PartIdtxt = new System.Windows.Forms.TextBox();
            this.Qtylbl = new System.Windows.Forms.Label();
            this.PartIdlbl = new System.Windows.Forms.Label();
            this.scparttxt = new System.Windows.Forms.TextBox();
            this.SearchPartlbl = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.TotalCosttxt = new System.Windows.Forms.TextBox();
            this.TotalCostlbl = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnREM = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsgrd)).BeginInit();
            this.Qtygb.SuspendLayout();
            this.grpCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // partsgrd
            // 
            this.partsgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsgrd.Location = new System.Drawing.Point(26, 142);
            this.partsgrd.Name = "partsgrd";
            this.partsgrd.RowTemplate.Height = 33;
            this.partsgrd.Size = new System.Drawing.Size(818, 261);
            this.partsgrd.TabIndex = 1;
            this.partsgrd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsgrd_CellClick);
            this.partsgrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsgrd_CellContentClick);
            // 
            // Qtygb
            // 
            this.Qtygb.Controls.Add(this.clearbtn);
            this.Qtygb.Controls.Add(this.salePricetxt);
            this.Qtygb.Controls.Add(this.SalePricelbl);
            this.Qtygb.Controls.Add(this.quantitytxt);
            this.Qtygb.Controls.Add(this.quanlbl);
            this.Qtygb.Controls.Add(this.Addbtn);
            this.Qtygb.Controls.Add(this.Parttxt);
            this.Qtygb.Controls.Add(this.PartIdtxt);
            this.Qtygb.Controls.Add(this.Qtylbl);
            this.Qtygb.Controls.Add(this.PartIdlbl);
            this.Qtygb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Qtygb.Location = new System.Drawing.Point(26, 440);
            this.Qtygb.Name = "Qtygb";
            this.Qtygb.Size = new System.Drawing.Size(530, 508);
            this.Qtygb.TabIndex = 2;
            this.Qtygb.TabStop = false;
            this.Qtygb.Text = "Part Details:";
            this.Qtygb.Enter += new System.EventHandler(this.Qtygb_Enter);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(248, 422);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(123, 56);
            this.clearbtn.TabIndex = 8;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // salePricetxt
            // 
            this.salePricetxt.Location = new System.Drawing.Point(248, 330);
            this.salePricetxt.Name = "salePricetxt";
            this.salePricetxt.ReadOnly = true;
            this.salePricetxt.Size = new System.Drawing.Size(204, 38);
            this.salePricetxt.TabIndex = 6;
            // 
            // SalePricelbl
            // 
            this.SalePricelbl.AutoSize = true;
            this.SalePricelbl.Location = new System.Drawing.Point(60, 337);
            this.SalePricelbl.Name = "SalePricelbl";
            this.SalePricelbl.Size = new System.Drawing.Size(145, 31);
            this.SalePricelbl.TabIndex = 7;
            this.SalePricelbl.Text = "Sale Price:";
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(247, 249);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(204, 38);
            this.quantitytxt.TabIndex = 5;
            this.quantitytxt.Text = "0";
            this.quantitytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quanlbl
            // 
            this.quanlbl.AutoSize = true;
            this.quanlbl.Location = new System.Drawing.Point(59, 255);
            this.quanlbl.Name = "quanlbl";
            this.quanlbl.Size = new System.Drawing.Size(124, 31);
            this.quanlbl.TabIndex = 5;
            this.quanlbl.Text = "Quantity:";
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(66, 422);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(123, 56);
            this.Addbtn.TabIndex = 7;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Parttxt
            // 
            this.Parttxt.Location = new System.Drawing.Point(248, 168);
            this.Parttxt.Name = "Parttxt";
            this.Parttxt.ReadOnly = true;
            this.Parttxt.Size = new System.Drawing.Size(204, 38);
            this.Parttxt.TabIndex = 4;
            // 
            // PartIdtxt
            // 
            this.PartIdtxt.Location = new System.Drawing.Point(248, 86);
            this.PartIdtxt.Name = "PartIdtxt";
            this.PartIdtxt.ReadOnly = true;
            this.PartIdtxt.Size = new System.Drawing.Size(204, 38);
            this.PartIdtxt.TabIndex = 3;
            // 
            // Qtylbl
            // 
            this.Qtylbl.AutoSize = true;
            this.Qtylbl.Location = new System.Drawing.Point(60, 174);
            this.Qtylbl.Name = "Qtylbl";
            this.Qtylbl.Size = new System.Drawing.Size(72, 31);
            this.Qtylbl.TabIndex = 1;
            this.Qtylbl.Text = "Part:";
            // 
            // PartIdlbl
            // 
            this.PartIdlbl.AutoSize = true;
            this.PartIdlbl.Location = new System.Drawing.Point(60, 86);
            this.PartIdlbl.Name = "PartIdlbl";
            this.PartIdlbl.Size = new System.Drawing.Size(102, 31);
            this.PartIdlbl.TabIndex = 0;
            this.PartIdlbl.Text = "Part Id:";
            // 
            // scparttxt
            // 
            this.scparttxt.Location = new System.Drawing.Point(243, 51);
            this.scparttxt.Name = "scparttxt";
            this.scparttxt.Size = new System.Drawing.Size(204, 31);
            this.scparttxt.TabIndex = 1;
            // 
            // SearchPartlbl
            // 
            this.SearchPartlbl.AutoSize = true;
            this.SearchPartlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchPartlbl.Location = new System.Drawing.Point(20, 51);
            this.SearchPartlbl.Name = "SearchPartlbl";
            this.SearchPartlbl.Size = new System.Drawing.Size(151, 31);
            this.SearchPartlbl.TabIndex = 5;
            this.SearchPartlbl.Text = "Part Name:";
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Searchbtn.Location = new System.Drawing.Point(524, 26);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(123, 56);
            this.Searchbtn.TabIndex = 2;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.TotalCosttxt);
            this.grpCart.Controls.Add(this.TotalCostlbl);
            this.grpCart.Controls.Add(this.lstCart);
            this.grpCart.Controls.Add(this.btnREM);
            this.grpCart.Controls.Add(this.btnFinished);
            this.grpCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpCart.Location = new System.Drawing.Point(613, 440);
            this.grpCart.Name = "grpCart";
            this.grpCart.Size = new System.Drawing.Size(621, 508);
            this.grpCart.TabIndex = 10;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Part Details:";
            // 
            // TotalCosttxt
            // 
            this.TotalCosttxt.Location = new System.Drawing.Point(210, 330);
            this.TotalCosttxt.Name = "TotalCosttxt";
            this.TotalCosttxt.ReadOnly = true;
            this.TotalCosttxt.Size = new System.Drawing.Size(204, 38);
            this.TotalCosttxt.TabIndex = 10;
            this.TotalCosttxt.Text = "0";
            this.TotalCosttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalCostlbl
            // 
            this.TotalCostlbl.AutoSize = true;
            this.TotalCostlbl.Location = new System.Drawing.Point(22, 337);
            this.TotalCostlbl.Name = "TotalCostlbl";
            this.TotalCostlbl.Size = new System.Drawing.Size(152, 31);
            this.TotalCostlbl.TabIndex = 12;
            this.TotalCostlbl.Text = "Total Price:";
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 31;
            this.lstCart.Location = new System.Drawing.Point(28, 86);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(448, 221);
            this.lstCart.TabIndex = 10;
            this.lstCart.SelectedIndexChanged += new System.EventHandler(this.lstCart_SelectedIndexChanged);
            // 
            // btnREM
            // 
            this.btnREM.Location = new System.Drawing.Point(501, 265);
            this.btnREM.Name = "btnREM";
            this.btnREM.Size = new System.Drawing.Size(96, 42);
            this.btnREM.TabIndex = 9;
            this.btnREM.Text = "REM";
            this.btnREM.UseVisualStyleBackColor = true;
            this.btnREM.Click += new System.EventHandler(this.btnREM_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(66, 422);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(140, 56);
            this.btnFinished.TabIndex = 11;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // frmselectParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 999);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.scparttxt);
            this.Controls.Add(this.SearchPartlbl);
            this.Controls.Add(this.Qtygb);
            this.Controls.Add(this.partsgrd);
            this.Name = "frmselectParts";
            this.Text = "selectParts";
            this.Load += new System.EventHandler(this.selectParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsgrd)).EndInit();
            this.Qtygb.ResumeLayout(false);
            this.Qtygb.PerformLayout();
            this.grpCart.ResumeLayout(false);
            this.grpCart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView partsgrd;
        private System.Windows.Forms.GroupBox Qtygb;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox Parttxt;
        private System.Windows.Forms.TextBox PartIdtxt;
        private System.Windows.Forms.Label Qtylbl;
        private System.Windows.Forms.Label PartIdlbl;
        private System.Windows.Forms.TextBox scparttxt;
        private System.Windows.Forms.Label SearchPartlbl;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox salePricetxt;
        private System.Windows.Forms.Label SalePricelbl;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label quanlbl;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.TextBox TotalCosttxt;
        private System.Windows.Forms.Label TotalCostlbl;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnREM;
        private System.Windows.Forms.Button btnFinished;
    }
}