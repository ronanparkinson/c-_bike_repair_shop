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
    public partial class frmFinish : Form
    {

        frmMainMenu parent;

        public frmFinish()
        {
            InitializeComponent();
        }

        public frmFinish(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void CommenceTitle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string text = Surtxt.Text.ToUpper();

            if (text == "")
            {
                repairsdgv.Visible = false;
                MessageBox.Show("Sorry please enter a part name into the field", "Error!");
            }

            else
            {
                repairsdgv.Visible = true;
            }

            DataSet DS = new DataSet();
            repairsdgv.DataSource = Repairs.getRepairs(DS, text).Tables["Re"];
        }

        private void repairsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            infogb.Show();
        }

        private void repairsdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Repairs selectRepair = new Repairs();
            selectRepair.getRepair(Convert.ToInt32(repairsdgv.Rows[repairsdgv.CurrentCell.RowIndex].Cells[0].Value));

            RepairIdtxt.Text = selectRepair.getRepair_Id().ToString();
            Surnametxt.Text = selectRepair.getSurname().ToString();
            Statustxt.Text = selectRepair.getStatus().ToString();
        }

        private void Finishbtn_Click(object sender, EventArgs e)
        {
            Repairs upR = new Repairs();
            upR.updateRepair('F', Convert.ToInt32(RepairIdtxt.Text));
            MessageBox.Show("Repair has been updated");
            frmFinish fin = new frmFinish();
            fin.Close();
        }
    }
}
