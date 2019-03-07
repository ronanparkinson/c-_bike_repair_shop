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
    public partial class CheckStock : Form
    {
        private Form Parent;

        public CheckStock()
        {
            InitializeComponent();
        }

        public CheckStock(frmMainMenu Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Hide();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void CheckStock_Load(object sender, EventArgs e)
        {

        }

        private void StockExit_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
