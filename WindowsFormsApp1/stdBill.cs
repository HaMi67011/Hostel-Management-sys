using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class stdBill : Form
    {
        public stdBill()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");

        private void search_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select mess_bill from MESS_ATTENDENCE where ROLL_NO ='" + StdId.Text +"'",con);
            OleDbDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                HosDue.Text = "34000";
                MessDue.Text = data.GetValue(0).ToString();
            }

            con.Close();
        }
    }
}
