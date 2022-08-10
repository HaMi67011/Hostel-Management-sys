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
using System.Data.Services.Client;
using System.Data.OleDb;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        static int attempt = 3;
        string query;
        DataSet ds;
        Class1 fn = new Class1();
        String name;
        String password;

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=HAMI;Password=hami6700;Unicode=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Admin" && textBox2.Text != "Admin")
            {

                try
                {
                    con.Open();
                    query = "select ROLL_NO,PASS from  student_details where ROLL_NO ='" + textBox1.Text + "' and pass= '" + textBox2.Text + "'";
                    ds = fn.getdata(query);

                    name = ds.Tables[0].Rows[0][0].ToString();

                    password = ds.Tables[0].Rows[0][1].ToString();

                    con.Close();
                }

                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("INVALID USER!!!!!");
                }
                catch (InvalidOperationException)
                {
                    con.Close();
                }
            }
            

            if (textBox1.Text == "Admin" && attempt >= 0)
                {
                    if (textBox2.Text == "Admin" && attempt >= 0)
                    {
                        main main = new main();
                        main.Show();
                        this.Hide();

                    }
                    else
                    {
                        if (attempt == 0)
                            Application.Exit();
                        MessageBox.Show("Password Incorrect\n You have Attempts lefts " + Convert.ToString(attempt));
                        attempt--;
                    }
                }


                else if (textBox1.Text == name && attempt >= 0)
                {
                    if (textBox2.Text == password && attempt >= 0)
                    {
                        stdMain main = new stdMain();
                        main.Show();
                        this.Hide();

                    }
                    else
                    {

                        if (attempt == 0)
                            Application.Exit();
                        MessageBox.Show("Password Incorrect\n You have Attempts lefts " + Convert.ToString(attempt) + "\n");
                        attempt--;
                    }
                }
                else
                {
                    if (attempt == 0)
                        Application.Exit();
                    MessageBox.Show("Password Incorrect\n You have Attempts lefts " + Convert.ToString(attempt));
                    attempt--;
                }

            
            

        }
    }
}
