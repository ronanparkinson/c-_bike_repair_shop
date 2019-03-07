namespace BRSYS
{
    partial class frmPartReg
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
            this.Reg_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commenceRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPartId = new System.Windows.Forms.TextBox();
            this.ID_Lab = new System.Windows.Forms.Label();
            this.txtPart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reg_Button
            // 
            this.Reg_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Reg_Button.Location = new System.Drawing.Point(50, 655);
            this.Reg_Button.Name = "Reg_Button";
            this.Reg_Button.Size = new System.Drawing.Size(138, 67);
            this.Reg_Button.TabIndex = 12;
            this.Reg_Button.Text = "Register";
            this.Reg_Button.UseVisualStyleBackColor = true;
            this.Reg_Button.Click += new System.EventHandler(this.Reg_Part);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(215, 655);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 67);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Cancel_part);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.stockToolStripMenuItem,
            this.repairToolStripMenuItem,
            this.analysisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1051, 42);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(76, 36);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderStockToolStripMenuItem,
            this.checkStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.stockToolStripMenuItem.Text = "Parts";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // orderStockToolStripMenuItem
            // 
            this.orderStockToolStripMenuItem.Name = "orderStockToolStripMenuItem";
            this.orderStockToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.orderStockToolStripMenuItem.Text = "Order Stock";
            // 
            // checkStockToolStripMenuItem
            // 
            this.checkStockToolStripMenuItem.Name = "checkStockToolStripMenuItem";
            this.checkStockToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.checkStockToolStripMenuItem.Text = "Update Stock";
            this.checkStockToolStripMenuItem.Click += new System.EventHandler(this.checkStockToolStripMenuItem_Click);
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logRepairToolStripMenuItem,
            this.commenceRepairToolStripMenuItem,
            this.finishRepairToolStripMenuItem,
            this.collectRepairToolStripMenuItem});
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
            this.repairToolStripMenuItem.Text = "Repair";
            // 
            // logRepairToolStripMenuItem
            // 
            this.logRepairToolStripMenuItem.Name = "logRepairToolStripMenuItem";
            this.logRepairToolStripMenuItem.Size = new System.Drawing.Size(310, 38);
            this.logRepairToolStripMenuItem.Text = "Log Repair";
            // 
            // commenceRepairToolStripMenuItem
            // 
            this.commenceRepairToolStripMenuItem.Name = "commenceRepairToolStripMenuItem";
            this.commenceRepairToolStripMenuItem.Size = new System.Drawing.Size(310, 38);
            this.commenceRepairToolStripMenuItem.Text = "Commence Repair";
            // 
            // finishRepairToolStripMenuItem
            // 
            this.finishRepairToolStripMenuItem.Name = "finishRepairToolStripMenuItem";
            this.finishRepairToolStripMenuItem.Size = new System.Drawing.Size(310, 38);
            this.finishRepairToolStripMenuItem.Text = "Finish Repair";
            // 
            // collectRepairToolStripMenuItem
            // 
            this.collectRepairToolStripMenuItem.Name = "collectRepairToolStripMenuItem";
            this.collectRepairToolStripMenuItem.Size = new System.Drawing.Size(310, 38);
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
            this.salesAnalysisToolStripMenuItem.Size = new System.Drawing.Size(273, 38);
            this.salesAnalysisToolStripMenuItem.Text = "Sales Analysis";
            // 
            // repairAnalysisToolStripMenuItem
            // 
            this.repairAnalysisToolStripMenuItem.Name = "repairAnalysisToolStripMenuItem";
            this.repairAnalysisToolStripMenuItem.Size = new System.Drawing.Size(273, 38);
            this.repairAnalysisToolStripMenuItem.Text = "Repair Analysis";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPartId);
            this.groupBox1.Controls.Add(this.ID_Lab);
            this.groupBox1.Controls.Add(this.txtPart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox1.Location = new System.Drawing.Point(50, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 534);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part Details:";
            // 
            // txtPartId
            // 
            this.txtPartId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPartId.Location = new System.Drawing.Point(285, 78);
            this.txtPartId.Name = "txtPartId";
            this.txtPartId.ReadOnly = true;
            this.txtPartId.Size = new System.Drawing.Size(163, 38);
            this.txtPartId.TabIndex = 3;
            this.txtPartId.TextChanged += new System.EventHandler(this.Part_Id);
            // 
            // ID_Lab
            // 
            this.ID_Lab.AutoSize = true;
            this.ID_Lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ID_Lab.Location = new System.Drawing.Point(21, 79);
            this.ID_Lab.Name = "ID_Lab";
            this.ID_Lab.Size = new System.Drawing.Size(125, 37);
            this.ID_Lab.TabIndex = 2;
            this.ID_Lab.Text = "Part ID:";
            // 
            // txtPart
            // 
            this.txtPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPart.Location = new System.Drawing.Point(285, 195);
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(296, 38);
            this.txtPart.TabIndex = 5;
            this.txtPart.TextChanged += new System.EventHandler(this.Part_Name);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(21, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Part Name:";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQty.Location = new System.Drawing.Point(285, 462);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(115, 38);
            this.txtQty.TabIndex = 11;
            this.txtQty.TextChanged += new System.EventHandler(this.Quantity);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(21, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity:";
            // 
            // txtSale
            // 
            this.txtSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSale.Location = new System.Drawing.Point(285, 367);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(199, 38);
            this.txtSale.TabIndex = 9;
            this.txtSale.TextChanged += new System.EventHandler(this.Sale_Cost);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(21, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sale Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCost.Location = new System.Drawing.Point(285, 276);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(199, 38);
            this.txtCost.TabIndex = 7;
            this.txtCost.TextChanged += new System.EventHandler(this.Part_Cost);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(21, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Part Cost:";
            // 
            // frmPartReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 797);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Reg_Button);
            this.Name = "frmPartReg";
            this.Text = "Register Stock";
            this.Load += new System.EventHandler(this.RegisterPart_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Reg_Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commenceRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairAnalysisToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartId;
        private System.Windows.Forms.Label ID_Lab;
    }
}