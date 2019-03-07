using System;
using System.Windows.Forms;

namespace BRSYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuStockCheck_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogRepair nextForm = new frmLogRepair(this);
            nextForm.Show();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuRegStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPartReg nextForm = new frmPartReg(this);
            nextForm.Show();
        }

        private void orderStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReplenish nextForm = new frmReplenish(this);
            nextForm.Show();
        }

        private void LogRepair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogRepair nextForm = new frmLogRepair(this);
            nextForm.Show();
        }


        private void Finish_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFinish nextForm = new frmFinish(this);
            nextForm.Show();
             
        }

        private void Collect_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCollect nextForm = new frmCollect(this);
            nextForm.Show();
        }

        private void updateStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateStock nextForm = new frmUpdateStock(this);
            nextForm.Show();
        }

        private void mnuCommence_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCommence nextForm = new frmCommence(this);
            nextForm.Show();
            
          
        }

        private void ForenameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(Forename.Text != "t00189412" && txtPassw.Text != "1234567" )
            {
                MessageBox.Show("No matching accounts try again!", "Unsuccessful login!");
            }

            else
            {
                
                MessageBox.Show("You have logged in successfully!", "Successful login");
            }
        }

        private void salesAnylysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesAnalysis nextForm = new frmSalesAnalysis(this);
            nextForm.Show();
        }

        private void repairAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRepairAnalysis nextForm = new frmRepairAnalysis(this);
            nextForm.Show();
        }
    }

   

}
