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
    public partial class adminShift : Form
    {
        public adminShift()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");

        private void Search_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from SHIFTING where ROLL_NO ='"+stdId.Text+"' ",con);

            OleDbDataAdapter oda = new OleDbDataAdapter("select * from SHIFTING where ROLL_NO ='" + stdId.Text + "' ", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;




            con.Close();
            MessageBox.Show("SEARCHED COMPLETED !!!!!!!!!!!");
        }
    }
}
