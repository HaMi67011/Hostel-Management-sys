using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class stdMain : Form
    {
        public stdMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
            WindowState = FormWindowState.Maximized;
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomAllocation room = new RoomAllocation();
            room.MdiParent = this;
            room.Show();
            room.Activate();

        }

        private void viewStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shifting shift = new Shifting();
            shift.MdiParent = this;
            shift.Show();
            shift.Activate();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessAttendence mess = new MessAttendence();
            mess.MdiParent = this;
            mess.Show();
            mess.Activate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stdBill bil = new stdBill();
            bil.MdiParent = this;
            bil.Show();
            bil.Activate();
        }

        private void visitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Visitors visitor = new Add_Visitors();
            visitor.MdiParent = this;
            visitor.Show();
            visitor.Activate();
        }

        private void stdMain_Load(object sender, EventArgs e)
        {

        }
    }
}
