using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data.OleDb;
using System.Data.Services.Client;


namespace WindowsFormsApp1
{
    public partial class main : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");


        public main()
        {
            InitializeComponent();
            //con.Open();
            //OleDbDataAdapter oda = new OleDbDataAdapter("Select * from hostel", con);
            //DataTable dt = new DataTable();
            //oda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();

            IsMdiContainer = true;

            WindowState = FormWindowState.Maximized;
        }

        

        private void Hostel_Click(object sender, EventArgs e)
        {

            //con.Open();
            //OleDbDataAdapter oda = new OleDbDataAdapter("Select * from hostel", con);
            //DataTable dt = new DataTable();
            //oda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();
        }

        private void Room_Click(object sender, EventArgs e)
        {
            //con.Open();
            //OleDbCommand cmd = new OleDbCommand("Insert into hostel values('" + txtname.Text+"')", con);
            //cmd.ExecuteNonQuery();
            //con.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Addstd addstudent = new Addstd();
            addstudent.MdiParent = this;
            addstudent.Show();
            addstudent.Activate();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            std_payment payment = new std_payment();
            payment.MdiParent = this;
            payment.Show();
            payment.Activate();
        }

        private void viewPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewHostelDetails pay = new viewHostelDetails();
            pay.MdiParent = this;
            pay.Show();
            pay.Activate();
        }

        private void viewStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStd std = new ViewStd();
            std.MdiParent = this;
            std.Show();
            std.Activate();
        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendence_going attStd = new Attendence_going();
            attStd.MdiParent = this;
            attStd.Show();
            attStd.Activate();
        }

        private void shiftingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminShift shift = new adminShift();
            shift.MdiParent = this;
            shift.Show();
            shift.Activate();
        }

        private void visitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Visitors visitor = new Show_Visitors();
            visitor.MdiParent = this;
            visitor.Show();
            visitor.Activate();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
