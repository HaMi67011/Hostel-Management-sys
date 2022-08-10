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


//table not created
namespace WindowsFormsApp1
{
    public partial class RoomAllocation : Form
    {
        public RoomAllocation()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");

        private void Search_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select ROLL_NO,ROOM_NO,cap from ALLOCATION where ROLL_NO = '"+stdId.Text+ "' ",con);
            OleDbDataReader data = cmd.ExecuteReader();
            //check for room capaciy
            while (data.Read())
            {
                StdRoom.Text = data.GetValue(1).ToString();
                RomCap.Text = data.GetValue(2).ToString();
            }

            con.Close();
        }
    }
}
