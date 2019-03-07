namespace BRSYS
{
    partial class frmUpdateStock
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
            this.UpBack = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button2 = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.UpdatePart = new System.Windows.Forms.GroupBox();
            this.PartIdtxt = new System.Windows.Forms.TextBox();
            this.PartId = new System.Windows.Forms.Label();
            this.newParttxt = new System.Windows.Forms.TextBox();
            this.newNamelbl = new System.Windows.Forms.Label();
            this.newStatustxt = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.Label();
            this.newQtytxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newSaletxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newCosttxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdName = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.UpdatePart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdName)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpBack,
            this.stockToolStripMenuItem,
            this.repairToolStripMenuItem,
            this.analysisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1243, 42);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UpBack
            // 
            this.UpBack.Name = "UpBack";
            this.UpBack.Size = new System.Drawing.Size(76, 36);
            this.UpBack.Text = "Back";
            this.UpBack.Click += new System.EventHandler(this.UpBack_Click);
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
            this.orderStockToolStripMenuItem.Text = "Order Stock";
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(186, 697);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 67);
            this.button2.TabIndex = 32;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Updatebtn.Location = new System.Drawing.Point(21, 697);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(139, 67);
            this.Updatebtn.TabIndex = 31;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // UpdatePart
            // 
            this.UpdatePart.Controls.Add(this.PartIdtxt);
            this.UpdatePart.Controls.Add(this.PartId);
            this.UpdatePart.Controls.Add(this.newParttxt);
            this.UpdatePart.Controls.Add(this.newNamelbl);
            this.UpdatePart.Controls.Add(this.newStatustxt);
            this.UpdatePart.Controls.Add(this.txtStatus);
            this.UpdatePart.Controls.Add(this.newQtytxt);
            this.UpdatePart.Controls.Add(this.button2);
            this.UpdatePart.Controls.Add(this.label4);
            this.UpdatePart.Controls.Add(this.Updatebtn);
            this.UpdatePart.Controls.Add(this.newSaletxt);
            this.UpdatePart.Controls.Add(this.label3);
            this.UpdatePart.Controls.Add(this.newCosttxt);
            this.UpdatePart.Controls.Add(this.label2);
            this.UpdatePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.UpdatePart.Location = new System.Drawing.Point(40, 687);
            this.UpdatePart.Name = "UpdatePart";
            this.UpdatePart.Size = new System.Drawing.Size(1143, 795);
            this.UpdatePart.TabIndex = 33;
            this.UpdatePart.TabStop = false;
            this.UpdatePart.Text = "Update Part Details";
            this.UpdatePart.Visible = false;
            this.UpdatePart.Enter += new System.EventHandler(this.UpdatePart_Enter);
            // 
            // PartIdtxt
            // 
            this.PartIdtxt.Enabled = false;
            this.PartIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PartIdtxt.Location = new System.Drawing.Point(283, 87);
            this.PartIdtxt.Name = "PartIdtxt";
            this.PartIdtxt.ReadOnly = true;
            this.PartIdtxt.Size = new System.Drawing.Size(296, 38);
            this.PartIdtxt.TabIndex = 46;
            this.PartIdtxt.TextChanged += new System.EventHandler(this.PartIdtxt_TextChanged);
            // 
            // PartId
            // 
            this.PartId.AutoSize = true;
            this.PartId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PartId.Location = new System.Drawing.Point(19, 87);
            this.PartId.Name = "PartId";
            this.PartId.Size = new System.Drawing.Size(120, 37);
            this.PartId.TabIndex = 45;
            this.PartId.Text = "Part Id:";
            // 
            // newParttxt
            // 
            this.newParttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newParttxt.Location = new System.Drawing.Point(279, 206);
            this.newParttxt.Name = "newParttxt";
            this.newParttxt.Size = new System.Drawing.Size(296, 38);
            this.newParttxt.TabIndex = 44;
            this.newParttxt.TextChanged += new System.EventHandler(this.newParttxt_TextChanged);
            // 
            // newNamelbl
            // 
            this.newNamelbl.AutoSize = true;
            this.newNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newNamelbl.Location = new System.Drawing.Point(15, 206);
            this.newNamelbl.Name = "newNamelbl";
            this.newNamelbl.Size = new System.Drawing.Size(180, 37);
            this.newNamelbl.TabIndex = 43;
            this.newNamelbl.Text = "Part Name:";
            // 
            // newStatustxt
            // 
            this.newStatustxt.FormattingEnabled = true;
            this.newStatustxt.Items.AddRange(new object[] {
            "Available ",
            "Discontinued"});
            this.newStatustxt.Location = new System.Drawing.Point(278, 597);
            this.newStatustxt.Name = "newStatustxt";
            this.newStatustxt.Size = new System.Drawing.Size(204, 47);
            this.newStatustxt.TabIndex = 40;
            this.newStatustxt.SelectedIndexChanged += new System.EventHandler(this.UpdateStatus_SelectedIndexChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStatus.Location = new System.Drawing.Point(19, 594);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(117, 37);
            this.txtStatus.TabIndex = 39;
            this.txtStatus.Text = "Status:";
            // 
            // newQtytxt
            // 
            this.newQtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newQtytxt.Location = new System.Drawing.Point(283, 503);
            this.newQtytxt.Name = "newQtytxt";
            this.newQtytxt.Size = new System.Drawing.Size(115, 38);
            this.newQtytxt.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(19, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 37);
            this.label4.TabIndex = 37;
            this.label4.Text = "Quantity:";
            // 
            // newSaletxt
            // 
            this.newSaletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newSaletxt.Location = new System.Drawing.Point(283, 401);
            this.newSaletxt.Name = "newSaletxt";
            this.newSaletxt.Size = new System.Drawing.Size(199, 38);
            this.newSaletxt.TabIndex = 36;
            this.newSaletxt.TextChanged += new System.EventHandler(this.newSaletxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(19, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 37);
            this.label3.TabIndex = 35;
            this.label3.Text = "Sale Cost:";
            // 
            // newCosttxt
            // 
            this.newCosttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newCosttxt.Location = new System.Drawing.Point(283, 295);
            this.newCosttxt.Name = "newCosttxt";
            this.newCosttxt.Size = new System.Drawing.Size(199, 38);
            this.newCosttxt.TabIndex = 34;
            this.newCosttxt.TextChanged += new System.EventHandler(this.newCosttxt_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(19, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 37);
            this.label2.TabIndex = 33;
            this.label2.Text = "Part Cost:";
            // 
            // txtPart
            // 
            this.txtPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPart.Location = new System.Drawing.Point(319, 117);
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(296, 38);
            this.txtPart.TabIndex = 35;
            this.txtPart.TextChanged += new System.EventHandler(this.Part_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(55, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Part Name:";
            // 
            // grdName
            // 
            this.grdName.AllowUserToAddRows = false;
            this.grdName.AllowUserToDeleteRows = false;
            this.grdName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdName.Location = new System.Drawing.Point(40, 200);
            this.grdName.Name = "grdName";
            this.grdName.ReadOnly = true;
            this.grdName.RowTemplate.Height = 33;
            this.grdName.Size = new System.Drawing.Size(1143, 440);
            this.grdName.TabIndex = 36;
            this.grdName.Visible = false;
            this.grdName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdName_CellClick);
            this.grdName.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdName_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSearch.Location = new System.Drawing.Point(811, 117);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 47);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 1629);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grdName);
            this.Controls.Add(this.txtPart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdatePart);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UpdateStock";
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.UpdateStock_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.UpdatePart.ResumeLayout(false);
            this.UpdatePart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UpBack;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commenceRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commenceRepairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finishRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.ToolStripMenuItem salesAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairAnalysisToolStripMenuItem;
        private System.Windows.Forms.GroupBox UpdatePart;
        private System.Windows.Forms.TextBox newQtytxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newSaletxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newCosttxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox newStatustxt;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.TextBox newParttxt;
        private System.Windows.Forms.Label newNamelbl;
        private System.Windows.Forms.TextBox PartIdtxt;
        private System.Windows.Forms.Label PartId;
    }
}