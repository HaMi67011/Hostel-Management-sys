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
    public partial class viewHostelDetails : Form
    {
        public viewHostelDetails()
        {
            InitializeComponent();
            groupBox1.Visible = true;

            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from  HOSTEL_BUILDING ", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        int roomno = 0;
        String room;
        int t;

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");

        private void insert_Click(object sender, EventArgs e)
        {
            

            t = int.Parse(noRoom.Text);

                
                roomno++;
                room = roomno.ToString();

            for (int i = 0; i <= t; i++)
            {
                con.Open();

                OleDbCommand cmd1 = new OleDbCommand("insert into Allocation(room_no,cap) values('"+i+"',0)", con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }

            con.Open();

            OleDbCommand cmd = new OleDbCommand("insert into HOSTEL_BUILDING(HOSTEL_ID,NAME,LOCATION,NO_OF_FLOOR,NO_OF_ROOMS) values('" + HosId.Text + "', '" + Name.Text + "','" + hosLoc.Text + "','" + noFloor.Text + "','" + noRoom.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            
            MessageBox.Show("HOSTEL DETAILS ADDED");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select HOSTEL_ID,NAME,LOCATION,NO_OF_FLOOR,NO_OF_ROOMS from HOSTEL_BUILDING where HOSTEL_ID = '" + HosId.Text + "' or NAME = '" + Name.Text + "'", con);
            OleDbDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                HosId.Text = data.GetValue(0).ToString();
                Name.Text = data.GetValue(1).ToString();
                hosLoc.Text = data.GetValue(2).ToString();
                noFloor.Text = data.GetValue(3).ToString();
                noRoom.Text = data.GetValue(4).ToString();
                
            }


            OleDbDataAdapter oda = new OleDbDataAdapter("select HOSTEL_ID,NAME,LOCATION,NO_OF_FLOOR,NO_OF_ROOMS from HOSTEL_BUILDING where HOSTEL_ID = '" + HosId.Text + "' or NAME = '" + Name.Text + "'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            while (HosId.Text == "" && Name.Text == ""  && noFloor.Text == "" && noRoom.Text == "" && hosLoc.Text == "" )
            {
                MessageBox.Show("DATA IS NOT FILLED");
            }

            OleDbCommand cmd = new OleDbCommand("Update HOSTEL_BUILDING set HOSTEL_ID = '" + HosId.Text + "' , NAME = '" + Name.Text + "' , LOCATION = '" + hosLoc.Text + "' , NO_OF_FLOOR  = '" + noFloor.Text + "' , NO_OF_ROOM = '" + noRoom.Text +  "' ", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("UPDATED !!!!!!!");

            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from HOSTEL_BUILDING ", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (HosId.Text != "" || Name.Text != "")
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE from HOSTEL_BUILDING where HOSTEL_ID  = '" + HosId.Text + "' or NAME = '" + Name.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("HOSTEL DATA IS DELTED");

            }
            else
            MessageBox.Show("PLEASE ENTER HOSTEL NO or NAME TO DELETE VALUE ");

            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from HOSTEL_BUILDING ", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
