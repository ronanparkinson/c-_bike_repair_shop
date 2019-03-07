using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace BRSYS
{
    class Repairs
    {
        private int Repair_Id;
        private String Forename;
        private String Surname;
        private int Mobile;
        private String Description;
        private String Email;
        private String regDate;
        private decimal RepairCost;
        private Char status;

        public Repairs()
        {
            this.Repair_Id = 0;
            this.Forename = "";
            this.Surname = "";
            this.Mobile = 0;
            this.Description = "";
            this.Email = "";
            this.regDate = "";
            this.RepairCost = 0;
            this.status = 'L';
        }

        public static int nextLogId()
        {
            int intNextLogId;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQl = "SELECT MAX(Repair_Id) FROM Repairs";

            OracleCommand cmd = new OracleCommand(strSQl, myConn);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.IsDBNull(0))
            {
                intNextLogId = 1;
            }
            else
            {
                intNextLogId = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            myConn.Close();

            return intNextLogId;
        }

        public void saveRepairDetails()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = @"INSERT INTO Repairs VALUES(" + this.Repair_Id +
                ",'" + this.Forename + "','" + this.Surname + "'," +
                this.Mobile + ",'" + this.Email + "','" + this.Description + "','" + this.regDate +
                "'," + this.RepairCost + ",'" + this.status + "')";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public static DataSet getRepairs(DataSet DS, string Surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            try
            {
                conn.Open();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            string strSql = "SELECT * FROM Repairs WHERE Surname LIKE'" + Surname + "%'";
            OracleCommand cmd = new OracleCommand(strSql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "Re");

            conn.Close();

            return DS;
        }

        public void getRepair(int Id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define sql query
            String strSQL = "SELECT * FROM Repairs WHERE Repair_Id =" + Id;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the Oracle command
            OracleDataReader dr = cmd.ExecuteReader();

            //instantiate the instance variables of the object with dr
            dr.Read();

            Repair_Id = Convert.ToInt32(dr.GetDecimal(0));
            Surname = dr.GetString(2);


            conn.Close();
        }

        public void updateRepair(char status,  int Repair_Id)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE Repairs SET Status = '" + status + "' " +
                "WHERE Repair_ID = " + Repair_Id;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public void setRepair_Id(int Repair_Id)
        {
            this.Repair_Id = Repair_Id;
        }

        public void setForename(String Forename)
        {
            this.Forename = Forename;
        }

        public void setSurname(String Surname)
        {
            this.Surname = Surname;
        }

        public void setMobile(int Mobile)
        {
            this.Mobile = Mobile;
        }

        public void setDescription(String Description)
        {
            this.Description = Description;
        }

        public void setEmail(String Email)
        {
            this.Email = Email;
        }

        public void setregDate(String regDate)
        {
            this.regDate = regDate;
        }

        public void setRepairCost(decimal RepairCost)
        {
            this.RepairCost = RepairCost;
        }

        public void setStatus(Char Status)
        {
            this.status = Status;
        }

        public int getRepair_Id()
        {
            return Repair_Id;
        }

        public String getForename()
        {
            return Forename;
        }

        public String getSurname()
        {
            return Surname;
        }

        public int getMobile()
        {
            return Mobile;
        }

        public String getEmail()
        {
            return Email;
        }

        public String getDescription()
        {
            return Description;
        }

        public String getRepairDate()
        {
            return regDate;
        }

        public decimal getRepairCost()
        {
            return RepairCost;
        }

        public Char getStatus()
        {
            return status;
        }

        public static DataSet getAnalysisValues(String Year)
        {
            // Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Def sql Query

            string strSql = @"SELECT to_char(RepairDate, 'mm') AS Month, sum(RepairCost)
                            FROM Repairs WHERE RepairDate LIKE '%" + Year + "' " +
                            "GROUP BY to_char(RepairDate, 'mm') ORDER BY to_char(RepairDate, 'mm')";

            //String strSQL = "SELECT NAME FROM Subjects ORDER BY NAME";
            OracleCommand cmd = new OracleCommand(strSql, conn);

            //Ex Query

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet DS = new DataSet();

            da.Fill(DS, "Ana");

            conn.Close();
            return DS;
        }
       }
}
