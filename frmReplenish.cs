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
    public partial class frmReplenish : Form
    {

        frmMainMenu Parent;
        public frmReplenish()
        {
            InitializeComponent();
        }

        public frmReplenish(frmMainMenu Parent)
        {
            this.Parent = Parent;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Replenish_Load(object sender, EventArgs e)
        {
           
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void quantitytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void Quantitylbl_Click(object sender, EventArgs e)
        {

        }

        private void grdReplenish_Enter(object sender, EventArgs e)
        {

        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string text = nameTxt.Text.ToUpper();

            if (text == "")
            {
                grdData.Visible = false;
                MessageBox.Show("Sorry please enter a part name into the field", "Error!");

            }

            else
            {
                grdData.Visible = true;
            }

            DataSet DS = new DataSet();
            grdData.DataSource = Part.getParts(DS, text).Tables["Pa"];
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Part selectQuantity = new Part();

            selectQuantity.getPart(Convert.ToInt32(grdData.Rows[grdData.CurrentCell.RowIndex].Cells[0].Value));

            PartIdtxt.Text = selectQuantity.getPartID().ToString("00000");
            quantitytxt.Text = selectQuantity.getQty().ToString();

            grdReplenish.Show();


        }

        private void Replenishbtn_Click(object sender, EventArgs e)
        {
            int parsedValue;

            if (quantitytxt.Text == "")
            {
                MessageBox.Show("Sorry please enter all fields! ", "Name Error!");
            }

            else if (!int.TryParse(quantitytxt.Text, out parsedValue))
            {
                MessageBox.Show("Only numbers can be entered into this field");
                return;
            }

            else
            {
                Part replenishQuantity = new Part();

                replenishQuantity.setPartId(Convert.ToInt32(grdData.Rows[grdData.CurrentCell.RowIndex].Cells[0].Value));
                replenishQuantity.setQuantity(Convert.ToInt32(quantitytxt.Text));

                replenishQuantity.replenishQuantity();

                MessageBox.Show("Stock has been replenished " ,"Stock Replenished!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                grdData.Visible = false;
                grdReplenish.Visible = false;
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }
    }
}
