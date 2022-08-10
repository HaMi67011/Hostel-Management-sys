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
    public partial class Shifting : Form
    {
        public Shifting()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");

        private void Search_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select ROLL_NO,PRE_ROOM,HALL_NAME,NEW_ROOM,NEWHALL_NAME,DATESHIFT from shifting where ROLL_NO = '" + stdId.Text + "' ", con);
            OleDbDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                CurRoom.Text = data.GetValue(1).ToString();
                HallName.Text = data.GetValue(2).ToString();
                NewRoom.Text = data.GetValue(3).ToString();
                newHallName.Text = data.GetValue(4).ToString();
                dateTimePicker1.Text = data.GetValue(5).ToString();
            }

            MessageBox.Show("SEARCH COMPLETED!!!!!!!!!!!");

            con.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into shifting(ROLL_NO,PRE_ROOM,HALL_NAME,NEW_ROOM,NEWHALL_NAME,DATESHIFT) VALUES ('" + stdId.Text + "' , '" + CurRoom.Text + "' , '" + HallName.Text + "', '" + NewRoom.Text + "' ,'" + newHallName.Text + "' ,'" + dateTimePicker1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("INSERTED!!!!!!!!!!");
            
        }
    }
}
