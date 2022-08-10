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
    public partial class Attendence_going : Form
    {
        public Attendence_going()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");

        private void Submit_Click(object sender, EventArgs e)
        {
            //check  needed for out first then in
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into passing_attend(ROLL_NO,IN_TIME,OUT_TIME,IN_TIME_DATE,OUT_TIME_DATE) values('" + stdid.Text + "','" + goingin.Checked + "' ,'" + goingout.Checked + "','" + inTime.Text + "','" + outTime.Text + "')", con);
            cmd.ExecuteNonQuery();
           
            con.Close();

            MessageBox.Show("RECORD ENTERED!!!!!!!");

        }

        private void check_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select ROLL_NO,IN_TIME,OUT_TIME,IN_TIME_DATE,OUT_TIME_DATE from passing_attend where ROLL_NO = '" +stdid.Text+"' ",con);
            OleDbDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                if(data.GetValue(1).ToString() == "True" && data.GetValue(2).ToString() == "False")
                {
                    goingin.Checked = true;
                }

                else if (data.GetValue(2).ToString() == "True" && data.GetValue(1).ToString() == "False")
                {
                    goingout.Checked = true;
                }
                else if (data.GetValue(2).ToString() == "True" && data.GetValue(1).ToString() == "True")
                {
                    goingin.Checked = true;
                    goingout.Checked = true;
                }
               
    

                inTime.Text=data.GetValue(3).ToString();
                outTime.Text = data.GetValue(4).ToString();


            }
                con.Close();
            MessageBox.Show("CHECK !!!!!!");
        }
    }
}
