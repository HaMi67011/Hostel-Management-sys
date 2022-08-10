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
    public partial class std_payment : Form
    {

        private string stdid;

        public std_payment()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");

        public void Std_payment(string student_id)
        {
            InitializeComponent();
            stdid = student_id;
        }

      

        private void Pay_Click(object sender, EventArgs e)
        {
            con.Open();

            String mess_bill;

            if (mess.Checked && hostel.Checked == false)
            {
                OleDbCommand cmd = new OleDbCommand("select mess_bill from MESS_ATTENDENCE where roll_no = '" + stdId.Text + "'", con);
                OleDbCommand cmd1= new OleDbCommand("select NAME from  student_details where roll_no = '" + stdId.Text + "'", con);

                OleDbDataReader data = cmd.ExecuteReader();
                OleDbDataReader data1 = cmd1.ExecuteReader();


                while (data.Read()) {
                    tot_fee.Text = data.GetValue(0).ToString();
                }

                while (data1.Read())
                {
                    stdName.Text = data1.GetValue(0).ToString();
                }

                mess_bill = tot_fee.Text;
                

                int tot_bills = Int32.Parse(mess_bill);
                int ent_bills = Int32.Parse(amunt.Text);


                int due = tot_bills - ent_bills;

                string due_fee = due.ToString();

                duefee.Text = due_fee;

                //    cmd.ExecuteNonQuery();
                //cmd1.ExecuteNonQuery();
                OleDbCommand cmd5 = new OleDbCommand("update MESS_ATTENDENCE set mess_bill = '" + duefee.Text +  "'   where roll_no = '" + stdId.Text + "'", con);
                cmd5.ExecuteNonQuery();

            }

            if (hostel.Checked && mess.Checked == false)
            {
                OleDbCommand cmd2 = new OleDbCommand("select NAME from  student_details where roll_no = '" + stdId.Text + "'", con);

                OleDbDataReader data3 = cmd2.ExecuteReader();

                while (data3.Read())
                {
                    stdName.Text = data3.GetValue(0).ToString();
                }

                int tot_bills = 34000;
                int ent_bills = Int32.Parse(amunt.Text);


                int due = tot_bills - ent_bills;

                string due_fee = due.ToString();

                duefee.Text = due_fee;

                //cmd2.ExecuteNonQuery();


            }

            if (hostel.Checked && mess.Checked)
            {
                MessageBox.Show("ERROR!!!!");
                tot_fee.Clear();
            }

            duefee.Clear();
            amunt.Clear();

            con.Close();

            MessageBox.Show("PAYMENT DONE!!!!!!!!!!!!!!");
        }

        private void std_payment_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd4 = new OleDbCommand("select NAME from  student_details where roll_no = '" + stdId.Text + "'", con);
            OleDbDataReader data4 = cmd4.ExecuteReader();

            if (mess.Checked && hostel.Checked == false)
            {
                OleDbCommand cmd5 = new OleDbCommand("select mess_bill from MESS_ATTENDENCE where roll_no = '" + stdId.Text + "'", con);

                OleDbDataReader data5 = cmd5.ExecuteReader();


                while (data5.Read())
                {
                    tot_fee.Text = data5.GetValue(0).ToString();
                }

                OleDbCommand cmd6 = new OleDbCommand("select NAME from  student_details where roll_no = '" + stdId.Text + "'", con);

                OleDbDataReader data6 = cmd6.ExecuteReader();

                while (data6.Read())
                {
                    stdName.Text = data6.GetValue(0).ToString();
                }



            }

            if (hostel.Checked && mess.Checked == false)
            {

                OleDbCommand cmd7 = new OleDbCommand("select NAME from  student_details where roll_no = '" + stdId.Text + "'", con);

                OleDbDataReader data7 = cmd7.ExecuteReader();

                while (data7.Read())
                {
                    stdName.Text = data7.GetValue(0).ToString();
                }


                tot_fee.Text = "34000";

            }


            if (hostel.Checked && mess.Checked)
            {
                MessageBox.Show("ERROR!!!!");
                tot_fee.Clear();
            }

            con.Close();
        }

        
    }
}
