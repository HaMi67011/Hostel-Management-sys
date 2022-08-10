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
    public partial class ViewStd : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");
        public ViewStd()
        {

            InitializeComponent();
            groupBox1.Visible = true;

            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from STUDENT_DETAILS ", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select ROLL_NO,NAME,AGE,CONTACT_NO,JoinDate,EmailId,PASS,ADDRESS,DEPT from STUDENT_DETAILS where ROLL_NO = '" + stdId.Text + "' or NAME = '" + name.Text + "'", con);
            OleDbDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                stdId.Text = data.GetValue(0).ToString();
                name.Text = data.GetValue(1).ToString();
                AGe.Text = data.GetValue(2).ToString();
                phone.Text = data.GetValue(3).ToString();
                date.Text = data.GetValue(4).ToString();
                mailid.Text = data.GetValue(5).ToString();
                fee.Text = data.GetValue(6).ToString();
                addr.Text = data.GetValue(7).ToString();
                Dept.Text = data.GetValue(8).ToString();
            }


            OleDbDataAdapter oda = new OleDbDataAdapter("select ROLL_NO,NAME,AGE,CONTACT_NO,JoinDate,EmailId,PASS,ADDRESS,DEPT from STUDENT_DETAILS where ROLL_NO = '" + stdId.Text + "' or NAME = '" + name.Text + "'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (stdId.Text != "" || name.Text != "") {
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand("delete from allocation where ROLL_NO = '"+ stdId.Text + "'",con);
                OleDbCommand cmd = new OleDbCommand("DELETE from STUDENT_DETAILS where ROLL_NO = '" + stdId.Text + "' or NAME = '" + name.Text + "'", con);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("STUDENT DATA IS DELTED");

            }
            else
            MessageBox.Show("PLEASE ENTER ROLL NO or NAME TO DELETE VALUE ");

            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from STUDENT_DETAILS ", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            while(stdId.Text == "" && name.Text == "" && AGe.Text == "" && Dept.Text == "" && phone.Text == "" && mailid.Text == "" && date.Text == "" && fee.Text == "" && addr.Text == "")
            {
                MessageBox.Show("DATA IS NOT FILLED");
            }

            OleDbCommand cmd = new OleDbCommand("Update STUDENT_DETAILS set ROLL_NO = '" + stdId.Text + "' , NAME = '" + name.Text + "' , DEPT = '"+ Dept.Text + "' , CONTACT_NO  = '" + phone.Text + "' , AGE = '" + AGe.Text + "' , JoinDate = '"+date.Text+ "' , EmailId = '" + mailid.Text + "' , PASS = '" + fee.Text + "'  , ADDRESS = '"+addr.Text + "' where ROLL_NO = '" + stdId.Text + "' ", con );
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("UPDATED !!!!!!!");

            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from STUDENT_DETAILS ", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void ViewStd_Load(object sender, EventArgs e)
        {

        }
    }
}
