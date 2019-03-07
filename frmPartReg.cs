using System;
using System.Windows.Forms;

namespace BRSYS
{
    public partial class frmPartReg : Form
    {

        frmMainMenu parent;

        public frmPartReg()
        {
            InitializeComponent();
        }

        public frmPartReg(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void checkStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void RegisterPart_Load(object sender, EventArgs e)
        {
            //Get next PartID and display UI
            txtPartId.Text = Part.nextPartId().ToString("00000");
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Part_Name(object sender, EventArgs e)
        {

        }

        private void Reg_Part(object sender, EventArgs e)
        {
   

            if (txtPart.Text == "" || txtCost.Text == "" || txtSale.Text == "" || txtQty.Text == "")
            {
                MessageBox.Show("Sorry please enter  text into all fields! ", "Name Error!");
            }

            else
            {
                Part myPart = new Part();

                myPart.setPartId(Convert.ToInt32(txtPartId.Text));
                myPart.setName(txtPart.Text);
                myPart.setCostPrice(Convert.ToDecimal(txtCost.Text));
                myPart.setSalePrice(Convert.ToDecimal(txtSale.Text));
                myPart.setQuantity(Convert.ToInt32(txtQty.Text));
                
                myPart.regStock();

                MessageBox.Show("Stock " + txtPartId.Text + " Resistered", "Confirmation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
      
                txtPart.Text = "";
                txtCost.Text = "";
                txtSale.Text = "";
                txtQty.Text = "";

                txtPartId.Text = Part.nextPartId().ToString("00000");
                txtPartId.Focus();
                
            }
        }

        private void Cancel_part(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        

        private void Part_Cost(object sender, EventArgs e)
        {
        }

        private void Sale_Cost(object sender, EventArgs e)
        {
        }

        private void Quantity(object sender, EventArgs e)
        {
        }

        private void Part_Id(object sender, EventArgs e)
        {
        }

        private void partInfogrb(object sender, EventArgs e)
        {
        }
    }
}
