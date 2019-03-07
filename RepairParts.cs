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
    class RepairParts
    {

        private int Repair_Id;
        private int Part_Id;
        private decimal unitCost;
        private int Qty;

        public RepairParts()
        {
            Repair_Id = 0;
            Part_Id = 0;
            unitCost = 0;
            Qty = 0;
        }

        public static int nextRepairId()
        {
            int intNextRepairId;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQl = "SELECT MAX(RepairId) FROM RepairParts";

            OracleCommand cmd = new OracleCommand(strSQl, myConn);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.IsDBNull(0))
            {
                intNextRepairId = 1;
            }
            else
            {
                intNextRepairId = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            myConn.Close();      
            return intNextRepairId;
        }

        public void addRepair()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "INSERT INTO RepairParts VALUES(" + this.Repair_Id +
                "," + this.Part_Id + "," + this.unitCost + "," +
                this.Qty + ")";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Update RepairCost
            String strSQL2 = "UPDATE Repairs SET RepairCost = " + this.unitCost * this.Qty + " WHERE Repair_ID = " + this.Repair_Id;
            OracleCommand cmd2 = new OracleCommand(strSQL2, myConn);

            cmd2.ExecuteNonQuery();

            myConn.Close();
        }

        public RepairParts(int Repair_Id, int Part_Id, int unitCost, int Qty)
        {
            this.Repair_Id = Repair_Id;
            this.Part_Id = Part_Id;
            this.unitCost = unitCost;
            this.Qty = Qty;
        }

        public void setRepair_Id(int Repair_Id)
        {
            this.Repair_Id = Repair_Id;
        }

        public void setPart_Id(int Part_Id)
        {
            this.Part_Id = Part_Id;
        }

        public void setunitCost(decimal unitCost)
        {
            this.unitCost = unitCost;
        }

        public void setQty(int Qty)
        {
            this.Qty = Qty;
        }

        public int getRepair_Id()
        {
            return Repair_Id;
        }

        public int getPart_Id()
        {
            return Part_Id;
        }

        public decimal getunitCost()
        {
            return unitCost;
        }

        public int getQty()
        {
            return Qty;
        }
    }
}
