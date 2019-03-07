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
    public partial class LogRepair : Form
    {
        frmMainMenu parent;

        public LogRepair()
        {
            InitializeComponent();
        }

        public LogRepair(frmMainMenu Parent)
        {
            this.parent = Parent;
            InitializeComponent();
        }

        private void Address1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogRepair_Load(object sender, EventArgs e)
        {

        }

        private void SaveRepair_Click(object sender, EventArgs e)
        {

        }

        private void CancelLog_Click(object sender, EventArgs e)
        {

        }

        private void orderStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void analysisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void Add1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogQ_Click(object sender, EventArgs e)
        {

        }

        private void LogA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
