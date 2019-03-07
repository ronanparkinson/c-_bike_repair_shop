using System;
using System.Windows.Forms;
using System.Data;

namespace BRSYS
{
    public partial class frmSalesAnalysis : Form
    {
        frmMainMenu Parent;

        public frmSalesAnalysis()
        {
            InitializeComponent();
        }

        public frmSalesAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveRepair_Click(object sender, EventArgs e)
        {

        }

        private void CancelLog_Click(object sender, EventArgs e)
        {

        }



        private void cboyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdData.Visible = true;
        }

        private void frmSalesAnalysis_Load(object sender, EventArgs e)
        {
            cboyear.Items.Add(DateTime.Today.Year); //2017
            cboyear.Items.Add(DateTime.Today.Year - 1);
            cboyear.Items.Add(DateTime.Today.Year - 2);

            setDefaultGrid();

            //Get data from repair table

            DataSet aDS = Repairs.getAnalysisValues(cboyear.Text);
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void setDefaultGrid()
        {
            for(int i = 0; i < 12; i++)
            {
                grdData.Rows[0].Cells[i].Value = string.Format("0.00");
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }
    }
}
