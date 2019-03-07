namespace BRSYS
{
    partial class frmLogRepair
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
            this.custDetails = new System.Windows.Forms.GroupBox();
            this.LogIdtxt = new System.Windows.Forms.TextBox();
            this.LogIdlbl = new System.Windows.Forms.Label();
            this.Repairdtp = new System.Windows.Forms.DateTimePicker();
            this.RepairDatelbl = new System.Windows.Forms.Label();
            this.descriptiontxt = new System.Windows.Forms.TextBox();
            this.desclbl = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.Logbtn = new System.Windows.Forms.Button();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.mobileNo = new System.Windows.Forms.TextBox();
            this.MobileNumber = new System.Windows.Forms.Label();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.forenametxt = new System.Windows.Forms.TextBox();
            this.Forename = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.custDetails.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(868, 42);
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
            // custDetails
            // 
            this.custDetails.Controls.Add(this.LogIdtxt);
            this.custDetails.Controls.Add(this.LogIdlbl);
            this.custDetails.Controls.Add(this.Repairdtp);
            this.custDetails.Controls.Add(this.RepairDatelbl);
            this.custDetails.Controls.Add(this.descriptiontxt);
            this.custDetails.Controls.Add(this.desclbl);
            this.custDetails.Controls.Add(this.cancelbtn);
            this.custDetails.Controls.Add(this.Logbtn);
            this.custDetails.Controls.Add(this.emailtxt);
            this.custDetails.Controls.Add(this.email);
            this.custDetails.Controls.Add(this.mobileNo);
            this.custDetails.Controls.Add(this.MobileNumber);
            this.custDetails.Controls.Add(this.surnametxt);
            this.custDetails.Controls.Add(this.Surname);
            this.custDetails.Controls.Add(this.forenametxt);
            this.custDetails.Controls.Add(this.Forename);
            this.custDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.custDetails.Location = new System.Drawing.Point(47, 77);
            this.custDetails.Name = "custDetails";
            this.custDetails.Size = new System.Drawing.Size(785, 846);
            this.custDetails.TabIndex = 21;
            this.custDetails.TabStop = false;
            this.custDetails.Text = "Customer Details:";
            this.custDetails.Enter += new System.EventHandler(this.custDetails_Enter);
            // 
            // LogIdtxt
            // 
            this.LogIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogIdtxt.Location = new System.Drawing.Point(295, 60);
            this.LogIdtxt.Margin = new System.Windows.Forms.Padding(5);
            this.LogIdtxt.Multiline = true;
            this.LogIdtxt.Name = "LogIdtxt";
            this.LogIdtxt.ReadOnly = true;
            this.LogIdtxt.Size = new System.Drawing.Size(281, 45);
            this.LogIdtxt.TabIndex = 1;
            this.LogIdtxt.TextChanged += new System.EventHandler(this.LogIdtxt_TextChanged);
            // 
            // LogIdlbl
            // 
            this.LogIdlbl.AutoSize = true;
            this.LogIdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogIdlbl.Location = new System.Drawing.Point(24, 60);
            this.LogIdlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LogIdlbl.Name = "LogIdlbl";
            this.LogIdlbl.Size = new System.Drawing.Size(159, 37);
            this.LogIdlbl.TabIndex = 36;
            this.LogIdlbl.Text = "Repair ID:";
            // 
            // Repairdtp
            // 
            this.Repairdtp.Location = new System.Drawing.Point(293, 666);
            this.Repairdtp.Name = "Repairdtp";
            this.Repairdtp.Size = new System.Drawing.Size(431, 47);
            this.Repairdtp.TabIndex = 7;
            // 
            // RepairDatelbl
            // 
            this.RepairDatelbl.AutoSize = true;
            this.RepairDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RepairDatelbl.Location = new System.Drawing.Point(22, 676);
            this.RepairDatelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RepairDatelbl.Name = "RepairDatelbl";
            this.RepairDatelbl.Size = new System.Drawing.Size(195, 37);
            this.RepairDatelbl.TabIndex = 32;
            this.RepairDatelbl.Text = "Repair Date:";
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descriptiontxt.Location = new System.Drawing.Point(293, 559);
            this.descriptiontxt.Margin = new System.Windows.Forms.Padding(5);
            this.descriptiontxt.Multiline = true;
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(431, 87);
            this.descriptiontxt.TabIndex = 6;
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.desclbl.Location = new System.Drawing.Point(24, 566);
            this.desclbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(186, 37);
            this.desclbl.TabIndex = 30;
            this.desclbl.Text = "Description:";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelbtn.Location = new System.Drawing.Point(210, 734);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(5);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(168, 74);
            this.cancelbtn.TabIndex = 9;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Logbtn
            // 
            this.Logbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Logbtn.Location = new System.Drawing.Point(29, 734);
            this.Logbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Logbtn.Name = "Logbtn";
            this.Logbtn.Size = new System.Drawing.Size(146, 74);
            this.Logbtn.TabIndex = 8;
            this.Logbtn.Text = "Log";
            this.Logbtn.UseVisualStyleBackColor = true;
            this.Logbtn.Click += new System.EventHandler(this.Logbtn_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailtxt.Location = new System.Drawing.Point(293, 457);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(5);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(431, 44);
            this.emailtxt.TabIndex = 5;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.email.Location = new System.Drawing.Point(22, 465);
            this.email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(106, 37);
            this.email.TabIndex = 26;
            this.email.Text = "Email:";
            // 
            // mobileNo
            // 
            this.mobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mobileNo.Location = new System.Drawing.Point(294, 353);
            this.mobileNo.Margin = new System.Windows.Forms.Padding(5);
            this.mobileNo.Name = "mobileNo";
            this.mobileNo.Size = new System.Drawing.Size(431, 44);
            this.mobileNo.TabIndex = 4;
            // 
            // MobileNumber
            // 
            this.MobileNumber.AutoSize = true;
            this.MobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MobileNumber.Location = new System.Drawing.Point(22, 360);
            this.MobileNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.Size = new System.Drawing.Size(170, 37);
            this.MobileNumber.TabIndex = 24;
            this.MobileNumber.Text = "Moible No:";
            // 
            // surnametxt
            // 
            this.surnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.surnametxt.Location = new System.Drawing.Point(293, 260);
            this.surnametxt.Margin = new System.Windows.Forms.Padding(5);
            this.surnametxt.Multiline = true;
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(431, 45);
            this.surnametxt.TabIndex = 3;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Surname.Location = new System.Drawing.Point(22, 260);
            this.Surname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(156, 37);
            this.Surname.TabIndex = 20;
            this.Surname.Text = "Surname:";
            // 
            // forenametxt
            // 
            this.forenametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.forenametxt.Location = new System.Drawing.Point(293, 172);
            this.forenametxt.Margin = new System.Windows.Forms.Padding(5);
            this.forenametxt.Multiline = true;
            this.forenametxt.Name = "forenametxt";
            this.forenametxt.Size = new System.Drawing.Size(281, 45);
            this.forenametxt.TabIndex = 2;
            this.forenametxt.TextChanged += new System.EventHandler(this.forenametxt_TextChanged);
            // 
            // Forename
            // 
            this.Forename.AutoSize = true;
            this.Forename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Forename.Location = new System.Drawing.Point(22, 172);
            this.Forename.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Forename.Name = "Forename";
            this.Forename.Size = new System.Drawing.Size(172, 37);
            this.Forename.TabIndex = 18;
            this.Forename.Text = "Forename:";
            // 
            // frmLogRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 960);
            this.Controls.Add(this.custDetails);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLogRepair";
            this.Text = "Log Repair";
            this.Load += new System.EventHandler(this.LogRepair_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.custDetails.ResumeLayout(false);
            this.custDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.GroupBox custDetails;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox mobileNo;
        private System.Windows.Forms.Label MobileNumber;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox forenametxt;
        private System.Windows.Forms.Label Forename;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button Logbtn;
        private System.Windows.Forms.DateTimePicker Repairdtp;
        private System.Windows.Forms.Label RepairDatelbl;
        private System.Windows.Forms.TextBox descriptiontxt;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.TextBox LogIdtxt;
        private System.Windows.Forms.Label LogIdlbl;
    }
}