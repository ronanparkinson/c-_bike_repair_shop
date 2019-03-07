namespace BRSYS
{
    partial class frmMainMenu
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
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegStock = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommence = new System.Windows.Forms.ToolStripMenuItem();
            this.Finish = new System.Windows.Forms.ToolStripMenuItem();
            this.Collect = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesAnylysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Forename = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ForenameBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.repairToolStripMenuItem,
            this.MenuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(900, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegStock,
            this.updateStockToolStripMenuItem,
            this.orderStockToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.customersToolStripMenuItem.Text = "Parts";
            // 
            // mnuRegStock
            // 
            this.mnuRegStock.Name = "mnuRegStock";
            this.mnuRegStock.Size = new System.Drawing.Size(261, 38);
            this.mnuRegStock.Text = "Register stock";
            this.mnuRegStock.Click += new System.EventHandler(this.mnuRegStock_Click);
            // 
            // updateStockToolStripMenuItem
            // 
            this.updateStockToolStripMenuItem.Name = "updateStockToolStripMenuItem";
            this.updateStockToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.updateStockToolStripMenuItem.Text = "Update Stock";
            this.updateStockToolStripMenuItem.Click += new System.EventHandler(this.updateStockToolStripMenuItem_Click);
            // 
            // orderStockToolStripMenuItem
            // 
            this.orderStockToolStripMenuItem.Name = "orderStockToolStripMenuItem";
            this.orderStockToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.orderStockToolStripMenuItem.Text = "Order Stock";
            this.orderStockToolStripMenuItem.Click += new System.EventHandler(this.orderStockToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogRepair,
            this.mnuCommence,
            this.Finish,
            this.Collect});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(93, 38);
            this.reportToolStripMenuItem.Text = "Repair";
            // 
            // LogRepair
            // 
            this.LogRepair.Name = "LogRepair";
            this.LogRepair.Size = new System.Drawing.Size(309, 38);
            this.LogRepair.Text = "Log Repair";
            this.LogRepair.Click += new System.EventHandler(this.LogRepair_Click);
            // 
            // mnuCommence
            // 
            this.mnuCommence.Name = "mnuCommence";
            this.mnuCommence.Size = new System.Drawing.Size(309, 38);
            this.mnuCommence.Text = "Commence Repair";
            this.mnuCommence.Click += new System.EventHandler(this.mnuCommence_Click);
            // 
            // Finish
            // 
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(309, 38);
            this.Finish.Text = "Completed Repair";
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // Collect
            // 
            this.Collect.Name = "Collect";
            this.Collect.Size = new System.Drawing.Size(309, 38);
            this.Collect.Text = "Collected repair";
            this.Collect.Click += new System.EventHandler(this.Collect_Click);
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesAnylysisToolStripMenuItem,
            this.repairAnalysisToolStripMenuItem});
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(97, 38);
            this.repairToolStripMenuItem.Text = "Report";
            // 
            // salesAnylysisToolStripMenuItem
            // 
            this.salesAnylysisToolStripMenuItem.Name = "salesAnylysisToolStripMenuItem";
            this.salesAnylysisToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.salesAnylysisToolStripMenuItem.Text = "Sales Analysis";
            this.salesAnylysisToolStripMenuItem.Click += new System.EventHandler(this.salesAnylysisToolStripMenuItem_Click);
            // 
            // repairAnalysisToolStripMenuItem
            // 
            this.repairAnalysisToolStripMenuItem.Name = "repairAnalysisToolStripMenuItem";
            this.repairAnalysisToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.repairAnalysisToolStripMenuItem.Text = "Repair Analysis";
            this.repairAnalysisToolStripMenuItem.Click += new System.EventHandler(this.repairAnalysisToolStripMenuItem_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.CheckOnClick = true;
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(64, 38);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // Forename
            // 
            this.Forename.AutoSize = true;
            this.Forename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Forename.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Forename.Location = new System.Drawing.Point(40, 131);
            this.Forename.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Forename.Name = "Forename";
            this.Forename.Size = new System.Drawing.Size(165, 37);
            this.Forename.TabIndex = 1;
            this.Forename.Text = "T-number:";
            this.Forename.Click += new System.EventHandler(this.label1_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SubmitButton.Location = new System.Drawing.Point(46, 415);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(220, 83);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ForenameBox
            // 
            this.ForenameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForenameBox.Location = new System.Drawing.Point(268, 125);
            this.ForenameBox.Margin = new System.Windows.Forms.Padding(4);
            this.ForenameBox.Name = "ForenameBox";
            this.ForenameBox.Size = new System.Drawing.Size(360, 44);
            this.ForenameBox.TabIndex = 2;
            this.ForenameBox.TextChanged += new System.EventHandler(this.ForenameBox_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Password.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Password.Location = new System.Drawing.Point(40, 263);
            this.Password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(167, 37);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password:";
            // 
            // txtPassw
            // 
            this.txtPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassw.Location = new System.Drawing.Point(268, 257);
            this.txtPassw.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.Size = new System.Drawing.Size(436, 44);
            this.txtPassw.TabIndex = 6;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 574);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ForenameBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.Forename);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem orderStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRegStock;
        private System.Windows.Forms.Label Forename;
        private System.Windows.Forms.ToolStripMenuItem LogRepair;
        private System.Windows.Forms.ToolStripMenuItem mnuCommence;
        private System.Windows.Forms.ToolStripMenuItem Finish;
        private System.Windows.Forms.ToolStripMenuItem Collect;
        private System.Windows.Forms.ToolStripMenuItem salesAnylysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairAnalysisToolStripMenuItem;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox ForenameBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtPassw;
        private System.Windows.Forms.ToolStripMenuItem updateStockToolStripMenuItem;
    }
}

