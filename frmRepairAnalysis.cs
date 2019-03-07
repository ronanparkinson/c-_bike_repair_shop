using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRSYS
{
    public partial class frmRepairAnalysis : Form
    {
        frmMainMenu Parent;

        public frmRepairAnalysis()
        {
            InitializeComponent();
        }

        public frmRepairAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();
            this.Parent = Parent;

        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRepairAnalysis_Load(object sender, EventArgs e)
        {
            cboYear.Items.Add(DateTime.Today.Year); //2017
            cboYear.Items.Add(DateTime.Today.Year - 1);
            cboYear.Items.Add(DateTime.Today.Year - 2);

            setDefaultGrid();
        }

        public void setDefaultGrid()
        {
            for (int i = 0; i < 12; i++)
            {
                grdData.Rows[0].Cells[i].Value = 0;
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }
    }
}
