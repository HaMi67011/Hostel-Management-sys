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
    public partial class Addstd : Form
    {
        public Addstd()
        {
            InitializeComponent();
     
        }

        String room;
        String query;
        String cap;
        int cap_room;
        DataSet ds;
        Class1 fn = new Class1();

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");



        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();


            query = "select room_no,cap from allocation where cap < 6";
            ds = fn.getdata(query);

            room = ds.Tables[0].Rows[0][0].ToString();
            cap = ds.Tables[0].Rows[0][1].ToString();



            OleDbCommand cmd = new OleDbCommand("INSERT INTO STUDENT_DETAILS(ROLL_NO,NAME,AGE,CONTACT_NO,JoinDate,EmailId,PASS,ADDRESS,DEPT)" +
               " VALUES('" + stdid.Text + "','" + fname.Text + " " + lname.Text + "','" + age.Text + "','" + phone.Text + "','" + dateTimePicker1.Text + "','" + id.Text + "','" + password.Text + "','" + richTextBox1.Text + "','" + dept.Text + "')", con);

            cmd.ExecuteNonQuery();

            cap_room = int.Parse(cap);
            cap_room = cap_room + 1;
            cap = cap_room.ToString();

            OleDbCommand cmd1 = new OleDbCommand("insert into allocation (ROLL_NO ,ROOM_NO,CAP) VALUES ('" + stdid.Text+"','" +room+ "' , '"+cap+ "' )",con);
            cmd1.ExecuteNonQuery();
            
            con.Close();

            MessageBox.Show(cap);

            MessageBox.Show("STUDENT DATA IS STORED");

            Addstd add = new Addstd();
            add.Show();
            this.Hide();

        }
    }
}
