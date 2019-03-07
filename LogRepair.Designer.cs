namespace BRSYS
{
    partial class LogRepair
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
            this.LogQ = new System.Windows.Forms.Label();
            this.LogA = new System.Windows.Forms.ComboBox();
            this.SaveRepair = new System.Windows.Forms.Button();
            this.CancelLog = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commenceRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MobileNumber = new System.Windows.Forms.Label();
            this.Add1 = new System.Windows.Forms.TextBox();
            this.Address1 = new System.Windows.Forms.Label();
            this.SurnameEnter = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Forename = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogQ
            // 
            this.LogQ.AutoSize = true;
            this.LogQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogQ.Location = new System.Drawing.Point(40, 77);
            this.LogQ.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LogQ.Name = "LogQ";
            this.LogQ.Size = new System.Drawing.Size(199, 37);
            this.LogQ.TabIndex = 0;
            this.LogQ.Text = "Log Repair ?";
            this.LogQ.Click += new System.EventHandler(this.LogQ_Click);
            // 
            // LogA
            // 
            this.LogA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogA.FormattingEnabled = true;
            this.LogA.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.LogA.Location = new System.Drawing.Point(314, 77);
            this.LogA.Margin = new System.Windows.Forms.Padding(5);
            this.LogA.Name = "LogA";
            this.LogA.Size = new System.Drawing.Size(159, 45);
            this.LogA.TabIndex = 1;
            this.LogA.SelectedIndexChanged += new System.EventHandler(this.LogA_SelectedIndexChanged);
            // 
            // SaveRepair
            // 
            this.SaveRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SaveRepair.Location = new System.Drawing.Point(47, 606);
            this.SaveRepair.Margin = new System.Windows.Forms.Padding(5);
            this.SaveRepair.Name = "SaveRepair";
            this.SaveRepair.Size = new System.Drawing.Size(146, 74);
            this.SaveRepair.TabIndex = 18;
            this.SaveRepair.Text = "Log";
            this.SaveRepair.UseVisualStyleBackColor = true;
            this.SaveRepair.Click += new System.EventHandler(this.SaveRepair_Click);
            // 
            // CancelLog
            // 
            this.CancelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CancelLog.Location = new System.Drawing.Point(228, 606);
            this.CancelLog.Margin = new System.Windows.Forms.Padding(5);
            this.CancelLog.Name = "CancelLog";
            this.CancelLog.Size = new System.Drawing.Size(168, 74);
            this.CancelLog.TabIndex = 19;
            this.CancelLog.Text = "Cancel";
            this.CancelLog.UseVisualStyleBackColor = true;
            this.CancelLog.Click += new System.EventHandler(this.CancelLog_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenu,
            this.stockToolStripMenuItem,
            this.repairToolStripMenuItem,
            this.analysisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(882, 42);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backMenu
            // 
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(76, 36);
            this.backMenu.Text = "Back";
            this.backMenu.Click += new System.EventHandler(this.backMenu_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderStockToolStripMenuItem,
            this.registerStockToolStripMenuItem,
            this.updateStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.stockToolStripMenuItem.Text = "Parts";
            // 
            // orderStockToolStripMenuItem
            // 
            this.orderStockToolStripMenuItem.Name = "orderStockToolStripMenuItem";
            this.orderStockToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.orderStockToolStripMenuItem.Text = "Order Stock";
            this.orderStockToolStripMenuItem.Click += new System.EventHandler(this.orderStockToolStripMenuItem_Click);
            // 
            // registerStockToolStripMenuItem
            // 
            this.registerStockToolStripMenuItem.Name = "registerStockToolStripMenuItem";
            this.registerStockToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.registerStockToolStripMenuItem.Text = "Register Stock";
            // 
            // updateStockToolStripMenuItem
            // 
            this.updateStockToolStripMenuItem.Name = "updateStockToolStripMenuItem";
            this.updateStockToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.updateStockToolStripMenuItem.Text = "Update Stock";
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
            this.analysisToolStripMenuItem.Click += new System.EventHandler(this.analysisToolStripMenuItem_Click);
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
            this.groupBox1.Controls.Add(this.EmailBox);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.MobileNumber);
            this.groupBox1.Controls.Add(this.Add1);
            this.groupBox1.Controls.Add(this.Address1);
            this.groupBox1.Controls.Add(this.SurnameEnter);
            this.groupBox1.Controls.Add(this.Surname);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Forename);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox1.Location = new System.Drawing.Point(47, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 423);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details:";
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmailBox.Location = new System.Drawing.Point(297, 354);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(5);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(431, 44);
            this.EmailBox.TabIndex = 27;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.email.Location = new System.Drawing.Point(26, 362);
            this.email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(106, 37);
            this.email.TabIndex = 26;
            this.email.Text = "Email:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(297, 281);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(431, 44);
            this.textBox2.TabIndex = 25;
            // 
            // MobileNumber
            // 
            this.MobileNumber.AutoSize = true;
            this.MobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MobileNumber.Location = new System.Drawing.Point(25, 288);
            this.MobileNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.Size = new System.Drawing.Size(170, 37);
            this.MobileNumber.TabIndex = 24;
            this.MobileNumber.Text = "Moible No:";
            // 
            // Add1
            // 
            this.Add1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Add1.Location = new System.Drawing.Point(297, 216);
            this.Add1.Margin = new System.Windows.Forms.Padding(5);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(431, 44);
            this.Add1.TabIndex = 23;
            // 
            // Address1
            // 
            this.Address1.AutoSize = true;
            this.Address1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Address1.Location = new System.Drawing.Point(23, 216);
            this.Address1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Address1.Name = "Address1";
            this.Address1.Size = new System.Drawing.Size(169, 37);
            this.Address1.TabIndex = 22;
            this.Address1.Text = "Address 1:";
            // 
            // SurnameEnter
            // 
            this.SurnameEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SurnameEnter.Location = new System.Drawing.Point(294, 149);
            this.SurnameEnter.Margin = new System.Windows.Forms.Padding(5);
            this.SurnameEnter.Multiline = true;
            this.SurnameEnter.Name = "SurnameEnter";
            this.SurnameEnter.Size = new System.Drawing.Size(431, 45);
            this.SurnameEnter.TabIndex = 21;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Surname.Location = new System.Drawing.Point(20, 149);
            this.Surname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(156, 37);
            this.Surname.TabIndex = 20;
            this.Surname.Text = "Surname:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(294, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 45);
            this.textBox1.TabIndex = 19;
            // 
            // Forename
            // 
            this.Forename.AutoSize = true;
            this.Forename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Forename.Location = new System.Drawing.Point(20, 85);
            this.Forename.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Forename.Name = "Forename";
            this.Forename.Size = new System.Drawing.Size(172, 37);
            this.Forename.TabIndex = 18;
            this.Forename.Text = "Forename:";
            // 
            // LogRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelLog);
            this.Controls.Add(this.SaveRepair);
            this.Controls.Add(this.LogA);
            this.Controls.Add(this.LogQ);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LogRepair";
            this.Text = "Log Repair";
            this.Load += new System.EventHandler(this.LogRepair_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogQ;
        private System.Windows.Forms.ComboBox LogA;
        private System.Windows.Forms.Button SaveRepair;
        private System.Windows.Forms.Button CancelLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backMenu;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commenceRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairAnalysisToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label MobileNumber;
        private System.Windows.Forms.TextBox Add1;
        private System.Windows.Forms.Label Address1;
        private System.Windows.Forms.TextBox SurnameEnter;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Forename;
    }
}