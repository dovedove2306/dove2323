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
    public partial class Dashboard : Form
    {
       
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            userControl11.Visible = false;
            btnAddRoom.PerformClick();
           
        }
        public static string x1, x2, x3, x4;

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Movingpanel.Left = btnAddRoom.Left + 18;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Movingpanel.Left = btnCustomerRegistrstion.Left+18;
            userControl11.Visible = true;
            userControl11.BringToFront();

            userControl11.txtRoomType.Text = x1;
            userControl11.txtRoomNo.Text = x2;

            userControl11.txtBed.Text = x3;
            userControl11.txtPrice.Text = x4;
            
           



        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            userControl21.Visible = true;
            userControl21.BringToFront();

            Movingpanel.Left = btnCheckOut.Left + 18;
        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            userControl31.Visible = true;
            userControl31.BringToFront();

            Movingpanel.Left = btnCustomerDetail.Left + 18;
        }
        
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            userControl41.Visible = true;
            userControl41.BringToFront();
            Movingpanel.Left = btnEmployee.Left + 18;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void uC_AddRoom1_ControlAdded(object sender, ControlEventArgs e)
        {
            
            
        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {
        }
        private void userControl31_Load(object sender, EventArgs e)
        {
           

        }
    }
}
