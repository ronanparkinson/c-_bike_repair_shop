using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BRSYS
{
    public partial class frmselectParts : Form
    {
       private List<Part> parts = new List<Part>();
       public decimal total = 0;
        decimal Total = 0;
        decimal Totaloff = 0;
        public frmselectParts()
        {
            InitializeComponent();
        }

        private void selectParts_Load(object sender, EventArgs e)
        {
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string text = scparttxt.Text.ToUpper();

            if (text == "")
            {
                partsgrd.Visible = false;
                MessageBox.Show("Sorry please enter a part name into the field", "Error!");
            }

            else
            {
                partsgrd.Visible = true;
            }

            DataSet DS = new DataSet();
            partsgrd.DataSource = Part.getParts(DS, text).Tables["Pa"];
        }

        private void partsgrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Qtygb.Show();
        }

        private void grdName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void partsgrd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Part selectPart = new Part();

            selectPart.getPart(Convert.ToInt32(partsgrd.Rows[partsgrd.CurrentCell.RowIndex].Cells[0].Value));

            PartIdtxt.Text = selectPart.getPartID().ToString("00000");
            Parttxt.Text = selectPart.getName().ToString();        
            salePricetxt.Text = selectPart.getSalePrice().ToString();
            String.Format("{0:0000.00}", salePricetxt.Text);
        }

        private void Qtygb_Enter(object sender, EventArgs e)
        {
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {        

            if (lstCart.Items.Count == 0)
            {               
                lstCart.Items.Add(PartIdtxt.Text + " " + Parttxt.Text.PadRight(15, ' ') + " " + Convert.ToInt32(quantitytxt.Text).ToString("000") + " " + String.Format("{0:0.00}", Convert.ToDecimal(salePricetxt.Text)));               
                Total += (Convert.ToDecimal(salePricetxt.Text) * Convert.ToDecimal(quantitytxt.Text));           
                TotalCosttxt.Text = Convert.ToString(Total);
            }

            else if (!InCart(PartIdtxt.Text))
            {
                lstCart.Items.Add(PartIdtxt.Text + " " + Parttxt.Text.PadRight(15, ' ') + " " + Convert.ToInt32(quantitytxt.Text).ToString("000") + " " + String.Format("{0:0.00}", Convert.ToDecimal(salePricetxt.Text)));
                Total += (Convert.ToDecimal(salePricetxt.Text) * Convert.ToDecimal(quantitytxt.Text));
                TotalCosttxt.Text = Convert.ToString(Total);
            }
            else
                MessageBox.Show("Already in cart");
        }
        
        public Boolean InCart(String partId)
        {
            Boolean answer = false;
            lstCart.SelectedIndex = 0;
            int i = 1;
          
            while ((!lstCart.Text.Substring(0, 5).Equals(partId) && (i < lstCart.Items.Count)))
            {
                if (i <= lstCart.Items.Count)
                    lstCart.SelectedIndex++;
            }

            if (lstCart.Text.Substring(0, 5).Equals(PartIdtxt.Text))
                {
                    answer = true;               
                }       
           return answer;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            parts.Clear();        
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            RepairParts soldParts = new RepairParts();
            Repairs costOf = new Repairs();
            int i = 0;
            
            RepairParts.nextRepairId();
            lstCart.SelectedIndex = 0;
            while (lstCart.SelectedIndex <= lstCart.Items.Count)
            {
                soldParts.setPart_Id(Convert.ToInt32(lstCart.Text.Substring(0, 5)));
                soldParts.setRepair_Id(RepairParts.nextRepairId());
                soldParts.setQty(Convert.ToInt32(lstCart.Text.Substring(22, 3)));
                soldParts.setunitCost(Convert.ToDecimal(lstCart.Text.Substring(26, 5)));
                soldParts.addRepair();
                if (lstCart.SelectedIndex < lstCart.Items.Count - 1)
                {
                    lstCart.SelectedIndex++;
                }

                else
                {
                    break;
                }
            }

            MessageBox.Show("The Repair has been Logged!");
            frmLogRepair lr = new frmLogRepair();
            lr.Show();
        }

        private void btnREM_Click(object sender, EventArgs e)
        {           
            if(lstCart.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an item to remove");
            }

            else
            {
                Totaloff = Convert.ToDecimal(lstCart.Text.Substring(26, 5)) * Convert.ToDecimal(lstCart.Text.Substring(22,3));
                TotalCosttxt.Text = (Convert.ToDecimal(TotalCosttxt.Text) - Totaloff).ToString("000.00");
                Total -= Totaloff; 
                lstCart.Items.RemoveAt(lstCart.SelectedIndex);          
            }
        }

        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}