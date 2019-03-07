namespace BRSYS
{
    partial class frmSalesAnalysis
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
            this.checkStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commenceRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectRepairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboyear = new System.Windows.Forms.ComboBox();
            this.cboyearlbl = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.January = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.February = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.March = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.April = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.June = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.July = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.August = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.September = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.October = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.November = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.December = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1356, 46);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(76, 38);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderStockToolStripMenuItem,
            this.registerStockToolStripMenuItem,
            this.checkStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.stockToolStripMenuItem.Text = "Parts";
            // 
            // orderStockToolStripMenuItem
            // 
            this.orderStockToolStripMenuItem.Name = "orderStockToolStripMenuItem";
            this.orderStockToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.orderStockToolStripMenuItem.Text = "Order Stock";
            // 
            // registerStockToolStripMenuItem
            // 
            this.registerStockToolStripMenuItem.Name = "registerStockToolStripMenuItem";
            this.registerStockToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.registerStockToolStripMenuItem.Text = "Register Stock";
            // 
            // checkStockToolStripMenuItem
            // 
            this.checkStockToolStripMenuItem.Name = "checkStockToolStripMenuItem";
            this.checkStockToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.checkStockToolStripMenuItem.Text = "Update Stock";
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commenceRepairToolStripMenuItem,
            this.collectRepairToolStripMenuItem,
            this.finishRepairToolStripMenuItem,
            this.collectRepairToolStripMenuItem1});
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(93, 38);
            this.repairToolStripMenuItem.Text = "Repair";
            // 
            // commenceRepairToolStripMenuItem
            // 
            this.commenceRepairToolStripMenuItem.Name = "commenceRepairToolStripMenuItem";
            this.commenceRepairToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.commenceRepairToolStripMenuItem.Text = "Log Repair";
            // 
            // collectRepairToolStripMenuItem
            // 
            this.collectRepairToolStripMenuItem.Name = "collectRepairToolStripMenuItem";
            this.collectRepairToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.collectRepairToolStripMenuItem.Text = "Commence Repair";
            // 
            // finishRepairToolStripMenuItem
            // 
            this.finishRepairToolStripMenuItem.Name = "finishRepairToolStripMenuItem";
            this.finishRepairToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.finishRepairToolStripMenuItem.Text = "Finish Repair";
            // 
            // collectRepairToolStripMenuItem1
            // 
            this.collectRepairToolStripMenuItem1.Name = "collectRepairToolStripMenuItem1";
            this.collectRepairToolStripMenuItem1.Size = new System.Drawing.Size(309, 38);
            this.collectRepairToolStripMenuItem1.Text = "Collect Repair";
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repairAnalysisToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(97, 38);
            this.analysisToolStripMenuItem.Text = "Report";
            // 
            // repairAnalysisToolStripMenuItem
            // 
            this.repairAnalysisToolStripMenuItem.Name = "repairAnalysisToolStripMenuItem";
            this.repairAnalysisToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.repairAnalysisToolStripMenuItem.Text = "Repair Analysis";
            // 
            // cboyear
            // 
            this.cboyear.FormattingEnabled = true;
            this.cboyear.Items.AddRange(new object[] {
            ""});
            this.cboyear.Location = new System.Drawing.Point(234, 104);
            this.cboyear.Margin = new System.Windows.Forms.Padding(4);
            this.cboyear.Name = "cboyear";
            this.cboyear.Size = new System.Drawing.Size(230, 33);
            this.cboyear.TabIndex = 27;
            this.cboyear.SelectedIndexChanged += new System.EventHandler(this.cboyear_SelectedIndexChanged);
            // 
            // cboyearlbl
            // 
            this.cboyearlbl.AutoSize = true;
            this.cboyearlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboyearlbl.Location = new System.Drawing.Point(26, 106);
            this.cboyearlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cboyearlbl.Name = "cboyearlbl";
            this.cboyearlbl.Size = new System.Drawing.Size(190, 37);
            this.cboyearlbl.TabIndex = 26;
            this.cboyearlbl.Text = "Select Year:";
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.January,
            this.February,
            this.March,
            this.April,
            this.May,
            this.June,
            this.July,
            this.August,
            this.September,
            this.October,
            this.November,
            this.December});
            this.grdData.Location = new System.Drawing.Point(33, 204);
            this.grdData.Margin = new System.Windows.Forms.Padding(4);
            this.grdData.Name = "grdData";
            this.grdData.RowTemplate.Height = 33;
            this.grdData.Size = new System.Drawing.Size(1262, 139);
            this.grdData.TabIndex = 33;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick_1);
            // 
            // January
            // 
            this.January.HeaderText = "January";
            this.January.Name = "January";
            // 
            // February
            // 
            this.February.HeaderText = "February";
            this.February.Name = "February";
            // 
            // March
            // 
            this.March.HeaderText = "March";
            this.March.Name = "March";
            // 
            // April
            // 
            this.April.HeaderText = "April";
            this.April.Name = "April";
            // 
            // May
            // 
            this.May.HeaderText = "May";
            this.May.Name = "May";
            // 
            // June
            // 
            this.June.HeaderText = "June";
            this.June.Name = "June";
            // 
            // July
            // 
            this.July.HeaderText = "July";
            this.July.Name = "July";
            // 
            // August
            // 
            this.August.HeaderText = "August";
            this.August.Name = "August";
            // 
            // September
            // 
            this.September.HeaderText = "September";
            this.September.Name = "September";
            // 
            // October
            // 
            this.October.HeaderText = "October";
            this.October.Name = "October";
            // 
            // November
            // 
            this.November.HeaderText = "November";
            this.November.Name = "November";
            // 
            // December
            // 
            this.December.HeaderText = "December";
            this.December.Name = "December";
            // 
            // frmSalesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 575);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.cboyear);
            this.Controls.Add(this.cboyearlbl);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSalesAnalysis";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.frmSalesAnalysis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem checkStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commenceRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectRepairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem repairAnalysisToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboyear;
        private System.Windows.Forms.Label cboyearlbl;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn January;
        private System.Windows.Forms.DataGridViewTextBoxColumn February;
        private System.Windows.Forms.DataGridViewTextBoxColumn March;
        private System.Windows.Forms.DataGridViewTextBoxColumn April;
        private System.Windows.Forms.DataGridViewTextBoxColumn May;
        private System.Windows.Forms.DataGridViewTextBoxColumn June;
        private System.Windows.Forms.DataGridViewTextBoxColumn July;
        private System.Windows.Forms.DataGridViewTextBoxColumn August;
        private System.Windows.Forms.DataGridViewTextBoxColumn September;
        private System.Windows.Forms.DataGridViewTextBoxColumn October;
        private System.Windows.Forms.DataGridViewTextBoxColumn November;
        private System.Windows.Forms.DataGridViewTextBoxColumn December;
    }
}