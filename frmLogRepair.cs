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
using System.Text.RegularExpressions;

namespace BRSYS
{
    public partial class frmLogRepair : Form
    {
        frmMainMenu parent;

        public frmLogRepair()
        {
            InitializeComponent();
        }

        public frmLogRepair(frmMainMenu Parent)
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
            LogIdtxt.Text = Repairs.nextLogId().ToString("00000");
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

        private void custDetails_Enter(object sender, EventArgs e)
        {

        }

        private void forenametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        public static bool validEmail(String inStr)
        {
            if (Regex.IsMatch(inStr,
                           @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                
                return true;
            }
            else
            {
                
                return false;
            }
        }


        private void Logbtn_Click(object sender, EventArgs e)
        {
            ArrayList parts = new ArrayList();

            if (forenametxt.Text == "" || surnametxt.Text == "" || mobileNo.Text == "" || mobileNo.TextLength < 10
               || mobileNo.TextLength > 10 || emailtxt.Text == "" || descriptiontxt.Text == "" || Repairdtp.Text == "")
            {
                MessageBox.Show("Sorry please enter all fields! ", "Name Error!");
            }

            else if(validEmail(emailtxt.Text) == false){
                MessageBox.Show("This is not a valid email");
            }


            else
            {
                Repairs LogRepair = new Repairs();

                LogRepair.setRepair_Id(Convert.ToInt32(LogIdtxt.Text));
                LogRepair.setForename(forenametxt.Text);
                LogRepair.setSurname(surnametxt.Text);
                LogRepair.setMobile(Convert.ToInt32(mobileNo.Text));
                LogRepair.setEmail(emailtxt.Text);
                LogRepair.setDescription(descriptiontxt.Text);
                LogRepair.setregDate(DateTime.Now.ToString("dd-MMM-yy"));
                LogRepair.saveRepairDetails();


                MessageBox.Show("Repair " + LogIdtxt.Text + " Logged", "Repair Logged",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                forenametxt.Text = "";
                surnametxt.Text = "";
                mobileNo.Text = "";
                emailtxt.Text = "";
                descriptiontxt.Text = "";
                Repairdtp.Text = "";


                LogIdtxt.Text = Part.nextPartId().ToString("00000");
                forenametxt.Focus();

                this.Hide();
                frmselectParts nextForm = new frmselectParts();
                nextForm.Show();
            }
        }

        private void LogIdtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
