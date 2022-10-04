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
    public partial class UserControl2 : UserControl
    {
        function fn = new function();
        String query;
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            query = "select cname,moblie,nationality,gender,dob,idproof,addres,checkin,roomid from customer where checkout = 'NO'";
            DataSet ds = fn.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select cname,moblie,nationality,gender,dob,idproof,addres,checkin,roomid from customer where cname like '" + txtName.Text + "'";
            DataSet ds = fn.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }
        int rid;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtCName.Text = (DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtRoom.Text = (DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());      
            }
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("Are You Sure?" , "Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)

                {
                    String cdate = txtCheckOut.Text;
                    query = "update customer set  checkout = '" + cdate + "' where cname = '" + txtCName.Text + "'";
                    fn.setData(query, "Check Out Successfully.");
                    query = "update rooms set booked = 'NO' where roomNo = '" + txtRoom.Text + "' ";
                    fn.setData(query, "");
                    UserControl2_Load(this, null);
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckOut.ResetText();
        }

        private void txtCheckOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UserControl2_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtCName.Text = (DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtRoom.Text = (DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            }
        }
    }
}
