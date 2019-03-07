namespace BRSYS
{
    partial class frmReplenish
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commenceRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commenceRepairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.finishRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdReplenish = new System.Windows.Forms.GroupBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Replenishbtn = new System.Windows.Forms.Button();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.Quantitylbl = new System.Windows.Forms.Label();
            this.PartIdtxt = new System.Windows.Forms.TextBox();
            this.PartIdlbl = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grdReplenish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.repairToolStripMenuItem,
            this.analysisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1140, 42);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderStockToolStripMenuItem,
            this.registerStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.stockToolStripMenuItem.Text = "Parts";
            // 
            // orderStockToolStripMenuItem
            // 
            this.orderStockToolStripMenuItem.Name = "orderStockToolStripMenuItem";
            this.orderStockToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.orderStockToolStripMenuItem.Text = "Update Stock";
            // 
            // registerStockToolStripMenuItem
            // 
            this.registerStockToolStripMenuItem.Name = "registerStockToolStripMenuItem";
            this.registerStockToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.registerStockToolStripMenuItem.Text = "Register Stock";
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commenceRepairToolStripMenuItem,
            this.commenceRepairToolStripMenuItem1,
            this.finishRepairToolStripMenuItem,
            this.collectRepairToolStripMenuItem});
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
            this.repairToolStripMenuItem.Text = "Repair";
            // 
            // commenceRepairToolStripMenuItem
            // 
            this.commenceRepairToolStripMenuItem.Name = "commenceRepairToolStripMenuItem";
            this.commenceRepairToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.commenceRepairToolStripMenuItem.Text = "Log Repair";
            // 
            // commenceRepairToolStripMenuItem1
            // 
            this.commenceRepairToolStripMenuItem1.Name = "commenceRepairToolStripMenuItem1";
            this.commenceRepairToolStripMenuItem1.Size = new System.Drawing.Size(309, 38);
            this.commenceRepairToolStripMenuItem1.Text = "Commence Repair";
            // 
            // finishRepairToolStripMenuItem
            // 
            this.finishRepairToolStripMenuItem.Name = "finishRepairToolStripMenuItem";
            this.finishRepairToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.finishRepairToolStripMenuItem.Text = "Finish Repair";
            // 
            // collectRepairToolStripMenuItem
            // 
            this.collectRepairToolStripMenuItem.Name = "collectRepairToolStripMenuItem";
            this.collectRepairToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.collectRepairToolStripMenuItem.Text = "Collect Repair";
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesAnalysisToolStripMenuItem,
            this.repairAnalysisToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.analysisToolStripMenuItem.Text = "Report";
            // 
            // salesAnalysisToolStripMenuItem
            // 
            this.salesAnalysisToolStripMenuItem.Name = "salesAnalysisToolStripMenuItem";
            this.salesAnalysisToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.salesAnalysisToolStripMenuItem.Text = "Sales Analysis";
            // 
            // repairAnalysisToolStripMenuItem
            // 
            this.repairAnalysisToolStripMenuItem.Name = "repairAnalysisToolStripMenuItem";
            this.repairAnalysisToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.repairAnalysisToolStripMenuItem.Text = "Repair Analysis";
            // 
            // grdReplenish
            // 
            this.grdReplenish.Controls.Add(this.Cancelbtn);
            this.grdReplenish.Controls.Add(this.Replenishbtn);
            this.grdReplenish.Controls.Add(this.quantitytxt);
            this.grdReplenish.Controls.Add(this.Quantitylbl);
            this.grdReplenish.Controls.Add(this.PartIdtxt);
            this.grdReplenish.Controls.Add(this.PartIdlbl);
            this.grdReplenish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.grdReplenish.Location = new System.Drawing.Point(21, 458);
            this.grdReplenish.Name = "grdReplenish";
            this.grdReplenish.Size = new System.Drawing.Size(1009, 381);
            this.grdReplenish.TabIndex = 39;
            this.grdReplenish.TabStop = false;
            this.grdReplenish.Text = "Replenish Stock:";
            this.grdReplenish.Visible = false;
            this.grdReplenish.Enter += new System.EventHandler(this.grdReplenish_Enter);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cancelbtn.Location = new System.Drawing.Point(178, 283);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(138, 67);
            this.Cancelbtn.TabIndex = 42;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Replenishbtn
            // 
            this.Replenishbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Replenishbtn.Location = new System.Drawing.Point(13, 283);
            this.Replenishbtn.Name = "Replenishbtn";
            this.Replenishbtn.Size = new System.Drawing.Size(138, 67);
            this.Replenishbtn.TabIndex = 41;
            this.Replenishbtn.Text = "Add";
            this.Replenishbtn.UseVisualStyleBackColor = true;
            this.Replenishbtn.Click += new System.EventHandler(this.Replenishbtn_Click);
            // 
            // quantitytxt
            // 
            this.quantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quantitytxt.Location = new System.Drawing.Point(279, 193);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(115, 38);
            this.quantitytxt.TabIndex = 40;
            this.quantitytxt.TextChanged += new System.EventHandler(this.quantitytxt_TextChanged);
            // 
            // Quantitylbl
            // 
            this.Quantitylbl.AutoSize = true;
            this.Quantitylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Quantitylbl.Location = new System.Drawing.Point(6, 194);
            this.Quantitylbl.Name = "Quantitylbl";
            this.Quantitylbl.Size = new System.Drawing.Size(145, 37);
            this.Quantitylbl.TabIndex = 39;
            this.Quantitylbl.Text = "Quantity:";
            this.Quantitylbl.Click += new System.EventHandler(this.Quantitylbl_Click);
            // 
            // PartIdtxt
            // 
            this.PartIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PartIdtxt.Location = new System.Drawing.Point(279, 86);
            this.PartIdtxt.Name = "PartIdtxt";
            this.PartIdtxt.ReadOnly = true;
            this.PartIdtxt.Size = new System.Drawing.Size(296, 38);
            this.PartIdtxt.TabIndex = 38;
            this.PartIdtxt.TextChanged += new System.EventHandler(this.PartNametxt_TextChanged);
            // 
            // PartIdlbl
            // 
            this.PartIdlbl.AutoSize = true;
            this.PartIdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PartIdlbl.Location = new System.Drawing.Point(6, 87);
            this.PartIdlbl.Name = "PartIdlbl";
            this.PartIdlbl.Size = new System.Drawing.Size(120, 37);
            this.PartIdlbl.TabIndex = 37;
            this.PartIdlbl.Text = "Part Id:";
            this.PartIdlbl.Click += new System.EventHandler(this.PartNamelbl_Click);
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(21, 167);
            this.grdData.Name = "grdData";
            this.grdData.RowTemplate.Height = 33;
            this.grdData.Size = new System.Drawing.Size(1020, 210);
            this.grdData.TabIndex = 40;
            this.grdData.Visible = false;
            this.grdData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellClick);
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTxt.Location = new System.Drawing.Point(311, 82);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(296, 38);
            this.nameTxt.TabIndex = 42;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.namelbl.Location = new System.Drawing.Point(38, 83);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(180, 37);
            this.namelbl.TabIndex = 41;
            this.namelbl.Text = "Part Name:";
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Searchbtn.Location = new System.Drawing.Point(731, 74);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(138, 46);
            this.Searchbtn.TabIndex = 43;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // frmReplenish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 889);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.grdReplenish);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmReplenish";
            this.Text = "Replenish";
            this.Load += new System.EventHandler(this.Replenish_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grdReplenish.ResumeLayout(false);
            this.grdReplenish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commenceRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commenceRepairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finishRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairAnalysisToolStripMenuItem;
        private System.Windows.Forms.GroupBox grdReplenish;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label Quantitylbl;
        private System.Windows.Forms.TextBox PartIdtxt;
        private System.Windows.Forms.Label PartIdlbl;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Replenishbtn;
    }
}