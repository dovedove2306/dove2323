using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1() 
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "select * from employee where username = '" + txtUsername.Text + "'and pass ='" + txtPassword.Text + "'";
            DataSet ds = fn.GetData(query);
           
            if (ds.Tables[0].Rows.Count != 0)
            {
               
                    Dashboard dash = new Dashboard();
                    dash.Show();
                    this.Hide();
                    txtPassword.Clear();
            }
            else
                {
                    labelError.Visible = true;
                    txtPassword.Clear();
                }

            }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
