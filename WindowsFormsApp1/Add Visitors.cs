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
    public partial class Add_Visitors : Form
    {
        public Add_Visitors()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");

        private void enter_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = new OleDbCommand("insert into VISITORS(ROLL_NO ,CNIC ,NAME ,AGE_ ,PHONE_NO ,DATEVISIT ,ADDRESS ) values ('" +stdId.Text+"','"+cnic.Text + "','" +name.Text+ "' ,'" +AGe.Text+"' , '" +phone.Text+ "' , '" +date.Text+"','"+addr.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("VISITOR DETAILS ENTER!!!!!!!!!");

            con.Close();
        }
    }
}
