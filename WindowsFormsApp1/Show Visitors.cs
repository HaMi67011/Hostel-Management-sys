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
    public partial class Show_Visitors : Form
    {
        public Show_Visitors()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");

        private void search_Click(object sender, EventArgs e)
        {
            con.Open();

            while (stdId.Text == "" && date.Text == "")
                MessageBox.Show("CORRECT INPUT !!!!!!!");

            if(stdId.Text != "" && date.Text == "")
            {
                OleDbCommand cmd = new OleDbCommand("select * from VISITORS where ROLL_NO = '" + stdId.Text +"' ");
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from VISITORS where ROLL_NO = '" + stdId.Text + "' ", con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            if (stdId.Text == "" && date.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand("select * from VISITORS where DATEVISIT = '" + date.Text + "' ",con);
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from VISITORS where DATEVISIT = '" + date.Text + "' ", con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;


            }

            if (stdId.Text != "" && date.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand("select * from VISITORS where DATEVISIT = '" + date.Text + "' and ROLL_NO = '" + stdId.Text + "'  ",con);
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from VISITORS where DATEVISIT = '" + date.Text + "' and ROLL_NO = '" + stdId.Text + "' ", con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
            }



            con.Close();
        }
    }
}
