namespace BRSYS
{
    partial class frmFinish
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
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Surtxt = new System.Windows.Forms.TextBox();
            this.Surlbl = new System.Windows.Forms.Label();
            this.RepairIdtxt = new System.Windows.Forms.TextBox();
            this.RepairIdlbl = new System.Windows.Forms.Label();
            this.Statustxt = new System.Windows.Forms.TextBox();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.Surnametxt = new System.Windows.Forms.TextBox();
            this.Surnamelbl = new System.Windows.Forms.Label();
            this.Finishbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.infogb = new System.Windows.Forms.GroupBox();
            this.repairAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commenceRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairsdgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infogb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairsdgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Searchbtn.Location = new System.Drawing.Point(571, 78);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(123, 42);
            this.Searchbtn.TabIndex = 39;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Surtxt
            // 
            this.Surtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Surtxt.Location = new System.Drawing.Point(278, 90);
            this.Surtxt.Margin = new System.Windows.Forms.Padding(5);
            this.Surtxt.Name = "Surtxt";
            this.Surtxt.Size = new System.Drawing.Size(234, 44);
            this.Surtxt.TabIndex = 37;
            // 
            // Surlbl
            // 
            this.Surlbl.AutoSize = true;
            this.Surlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Surlbl.Location = new System.Drawing.Point(35, 97);
            this.Surlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Surlbl.Name = "Surlbl";
            this.Surlbl.Size = new System.Drawing.Size(156, 37);
            this.Surlbl.TabIndex = 36;
            this.Surlbl.Text = "Surname:";
            // 
            // RepairIdtxt
            // 
            this.RepairIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RepairIdtxt.Location = new System.Drawing.Point(354, 58);
            this.RepairIdtxt.Margin = new System.Windows.Forms.Padding(5);
            this.RepairIdtxt.Name = "RepairIdtxt";
            this.RepairIdtxt.ReadOnly = true;
            this.RepairIdtxt.Size = new System.Drawing.Size(234, 44);
            this.RepairIdtxt.TabIndex = 33;
            // 
            // RepairIdlbl
            // 
            this.RepairIdlbl.AutoSize = true;
            this.RepairIdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RepairIdlbl.Location = new System.Drawing.Point(11, 65);
            this.RepairIdlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RepairIdlbl.Name = "RepairIdlbl";
            this.RepairIdlbl.Size = new System.Drawing.Size(154, 37);
            this.RepairIdlbl.TabIndex = 32;
            this.RepairIdlbl.Text = "Repair Id:";
            // 
            // Statustxt
            // 
            this.Statustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Statustxt.Location = new System.Drawing.Point(354, 217);
            this.Statustxt.Margin = new System.Windows.Forms.Padding(5);
            this.Statustxt.Name = "Statustxt";
            this.Statustxt.ReadOnly = true;
            this.Statustxt.Size = new System.Drawing.Size(234, 44);
            this.Statustxt.TabIndex = 31;
            // 
            // Statuslbl
            // 
            this.Statuslbl.AutoSize = true;
            this.Statuslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Statuslbl.Location = new System.Drawing.Point(11, 224);
            this.Statuslbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Statuslbl.Name = "Statuslbl";
            this.Statuslbl.Size = new System.Drawing.Size(117, 37);
            this.Statuslbl.TabIndex = 30;
            this.Statuslbl.Text = "Status:";
            // 
            // Surnametxt
            // 
            this.Surnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Surnametxt.Location = new System.Drawing.Point(354, 135);
            this.Surnametxt.Margin = new System.Windows.Forms.Padding(5);
            this.Surnametxt.Name = "Surnametxt";
            this.Surnametxt.ReadOnly = true;
            this.Surnametxt.Size = new System.Drawing.Size(234, 44);
            this.Surnametxt.TabIndex = 29;
            // 
            // Surnamelbl
            // 
            this.Surnamelbl.AutoSize = true;
            this.Surnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Surnamelbl.Location = new System.Drawing.Point(11, 142);
            this.Surnamelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Surnamelbl.Name = "Surnamelbl";
            this.Surnamelbl.Size = new System.Drawing.Size(156, 37);
            this.Surnamelbl.TabIndex = 28;
            this.Surnamelbl.Text = "Surname:";
            // 
            // Finishbtn
            // 
            this.Finishbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Finishbtn.Location = new System.Drawing.Point(656, 65);
            this.Finishbtn.Name = "Finishbtn";
            this.Finishbtn.Size = new System.Drawing.Size(165, 85);
            this.Finishbtn.TabIndex = 26;
            this.Finishbtn.Text = "Finish";
            this.Finishbtn.UseVisualStyleBackColor = true;
            this.Finishbtn.Click += new System.EventHandler(this.Finishbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelbtn.Location = new System.Drawing.Point(656, 185);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(165, 85);
            this.cancelbtn.TabIndex = 27;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // infogb
            // 
            this.infogb.Controls.Add(this.RepairIdtxt);
            this.infogb.Controls.Add(this.RepairIdlbl);
            this.infogb.Controls.Add(this.Statustxt);
            this.infogb.Controls.Add(this.Statuslbl);
            this.infogb.Controls.Add(this.Surnametxt);
            this.infogb.Controls.Add(this.Surnamelbl);
            this.infogb.Controls.Add(this.Finishbtn);
            this.infogb.Controls.Add(this.cancelbtn);
            this.infogb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.infogb.Location = new System.Drawing.Point(42, 561);
            this.infogb.Name = "infogb";
            this.infogb.Size = new System.Drawing.Size(884, 286);
            this.infogb.TabIndex = 35;
            this.infogb.TabStop = false;
            this.infogb.Text = "Repair Info:";
            // 
            // repairAnalysisToolStripMenuItem
            // 
            this.repairAnalysisToolStripMenuItem.Name = "repairAnalysisToolStripMenuItem";
            this.repairAnalysisToolStripMenuItem.Size = new System.Drawing.Size(273, 38);
            this.repairAnalysisToolStripMenuItem.Text = "Repair Analysis";
            // 
            // salesAnalysisToolStripMenuItem
            // 
            this.salesAnalysisToolStripMenuItem.Name = "salesAnalysisToolStripMenuItem";
            this.salesAnalysisToolStripMenuItem.Size = new System.Drawing.Size(273, 38);
            this.salesAnalysisToolStripMenuItem.Text = "Sales Analysis";
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
            // collectRepairToolStripMenuItem
            // 
            this.collectRepairToolStripMenuItem.Name = "collectRepairToolStripMenuItem";
            this.collectRepairToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.collectRepairToolStripMenuItem.Text = "Collect Repair";
            // 
            // finishRepairToolStripMenuItem
            // 
            this.finishRepairToolStripMenuItem.Name = "finishRepairToolStripMenuItem";
            this.finishRepairToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.finishRepairToolStripMenuItem.Text = "Finish Repair";
            // 
            // commenceRepairToolStripMenuItem
            // 
            this.commenceRepairToolStripMenuItem.Name = "commenceRepairToolStripMenuItem";
            this.commenceRepairToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.commenceRepairToolStripMenuItem.Text = "Log Repair";
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commenceRepairToolStripMenuItem,
            this.finishRepairToolStripMenuItem,
            this.collectRepairToolStripMenuItem});
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
            this.repairToolStripMenuItem.Text = "Repair";
            // 
            // checkStockToolStripMenuItem
            // 
            this.checkStockToolStripMenuItem.Name = "checkStockToolStripMenuItem";
            this.checkStockToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.checkStockToolStripMenuItem.Text = "Update Stock";
            // 
            // registerStockToolStripMenuItem
            // 
            this.registerStockToolStripMenuItem.Name = "registerStockToolStripMenuItem";
            this.registerStockToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.registerStockToolStripMenuItem.Text = "Register Stock";
            // 
            // orderStockToolStripMenuItem
            // 
            this.orderStockToolStripMenuItem.Name = "orderStockToolStripMenuItem";
            this.orderStockToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.orderStockToolStripMenuItem.Text = "Order Stock";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderStockToolStripMenuItem,
            this.registerStockToolStripMenuItem,
            this.checkStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.stockToolStripMenuItem.Text = "Parts";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // repairsdgv
            // 
            this.repairsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repairsdgv.Location = new System.Drawing.Point(42, 195);
            this.repairsdgv.Name = "repairsdgv";
            this.repairsdgv.RowTemplate.Height = 33;
            this.repairsdgv.Size = new System.Drawing.Size(884, 281);
            this.repairsdgv.TabIndex = 38;
            this.repairsdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.repairsdgv_CellClick);
            this.repairsdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.repairsdgv_CellContentClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(967, 42);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 877);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Surtxt);
            this.Controls.Add(this.Surlbl);
            this.Controls.Add(this.infogb);
            this.Controls.Add(this.repairsdgv);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmFinish";
            this.Text = "Finish";
            this.infogb.ResumeLayout(false);
            this.infogb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairsdgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox Surtxt;
        private System.Windows.Forms.Label Surlbl;
        private System.Windows.Forms.TextBox RepairIdtxt;
        private System.Windows.Forms.Label RepairIdlbl;
        private System.Windows.Forms.TextBox Statustxt;
        private System.Windows.Forms.Label Statuslbl;
        private System.Windows.Forms.TextBox Surnametxt;
        private System.Windows.Forms.Label Surnamelbl;
        private System.Windows.Forms.Button Finishbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.GroupBox infogb;
        private System.Windows.Forms.ToolStripMenuItem repairAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commenceRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView repairsdgv;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}