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
    public partial class frmUpdateStock : Form
    {
        frmMainMenu parent;

        public frmUpdateStock()
        {
            InitializeComponent();
        }

        public frmUpdateStock(frmMainMenu Parent)
        {
            this.parent = Parent;
            InitializeComponent();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
        }

        private void UpBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grdName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdatePart.Show();
        }

        private void Part_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = txtPart.Text.ToUpper();

            if (text == "")
            {
                grdName.Visible = false;
                MessageBox.Show("Sorry please enter a part name into the field", "Error!");

            }

            else
            {
                grdName.Visible = true;
            }

            DataSet DS = new DataSet();
            grdName.DataSource = Part.getParts(DS, text).Tables["Pa"];
        }

        private void grdName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
  
            Part updatePart = new Part();

            updatePart.getPart(Convert.ToInt32(grdName.Rows[grdName.CurrentCell.RowIndex].Cells[0].Value));

                PartIdtxt.Text = updatePart.getPartID().ToString("00000");
                newParttxt.Text = updatePart.getName().ToString();
                newCosttxt.Text = updatePart.getCostPrice().ToString();
                newSaletxt.Text = updatePart.getSalePrice().ToString();
                newQtytxt.Text = updatePart.getQty().ToString();
                newStatustxt.Text = updatePart.getStatus().ToString();

                UpdatePart.Show();

            if (newParttxt.Text == "" || newCosttxt.Text == "" || newSaletxt.Text == "" || newQtytxt.Text == "")
            {
                MessageBox.Show("Sorry please enter all fields! ", "Name Error!");
            }

            if (newStatustxt.Text == "Available")
                {
                    updatePart.setStatus(Convert.ToChar('A'));
                }

                else
                {
                    updatePart.setStatus(Convert.ToChar('D'));
                }
            

  
        }

        private void UpdatePart_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newCosttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void newSaletxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void newCosttxt_TextChanged_1(object sender, EventArgs e)
        {

        }



        private void newParttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPartIdtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (newParttxt.Text == "" || newCosttxt.Text == "" || newSaletxt.Text == "" || newQtytxt.Text == "")
            {
                MessageBox.Show("Sorry please enter all fields! ", "Name Error!");
            }

            int parsedValue;
            if (!int.TryParse(newQtytxt.Text, out parsedValue))
            {
                MessageBox.Show("Only numbers can be entered into this field");
                return;
            }

            else if(!int.TryParse(newCosttxt.Text, out parsedValue))
            {
                MessageBox.Show("Only numbers can be entered into this field");
                return;
            }

            else if (!int.TryParse(newSaletxt.Text, out parsedValue))
            {
                MessageBox.Show("Only numbers can be entered into this field");
                return;
            }

            else
            {
                Part myPart = new Part();

                myPart.setPartId(Convert.ToInt32(grdName.Rows[grdName.CurrentCell.RowIndex].Cells[0].Value));
                myPart.setName(newParttxt.Text);
                myPart.setCostPrice(Convert.ToDecimal(newCosttxt.Text));
                myPart.setSalePrice(Convert.ToDecimal(newSaletxt.Text));
                myPart.setQuantity(Convert.ToInt32(newQtytxt.Text));

                myPart.updateStock();

                MessageBox.Show("Stock " + newParttxt.Text + " Has been updated", "Updated!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                grdName.Visible = false;
                UpdatePart.Visible = false;
            }
        }

        private void PartIdtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}