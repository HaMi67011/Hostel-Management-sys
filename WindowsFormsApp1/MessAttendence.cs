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
   
    public partial class MessAttendence : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");

        public MessAttendence()
        {
            InitializeComponent();

        }
        int bill = 0 ,total =0;
        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Lunch.Checked == true)
            {
                count++;
                bill += 100;

            }
            if (breakfast.Checked == true)
            {
                count++;
                bill += 50;
            }

            if (Dinner.Checked == true)
            {
                count++;
                bill += 150;
            }
            total = count * bill;
            txttotal.Text = total.ToString();
        }

        private void outTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into MESS_ATTENDENCE(ROLL_NO,BREAK_FAST,LUNCH_,DINNER_,mess_bill) values ('" +txtid.Text+ "','" +breakfast.Text+ "','" +Lunch.Text+"' , '" +Dinner.Text+ "','"+txttotal.Text+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();
           
            MessageBox.Show("SUBMITTED!!!!!!!");
            txttotal.Clear();

        }
        
    }
}
