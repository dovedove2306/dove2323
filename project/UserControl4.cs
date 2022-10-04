using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class UserControl4 : UserControl
    {
        function fn = new function();
        String query;
        public UserControl4()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtHName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                String name = txtHName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String pass = txtPassword.Text;

                query = "insert into employee (ename,moblie,gender,emailid,username,pass) values('" + name+ "','" + mobile + "','" + gender + "','" + email + "','" + username + "','" + pass + "' )";
                fn.setData(query, "Employee Registered.");

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Fill all Fields.","Warning....!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void TabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabEmployee.SelectedIndex == 1)
            {
                setEmployee(DataGridView1);
            }
            else if (TabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView1);
            }
        }
        public void clearAll()
        {
            txtHName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.GetData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Confirmation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = $"delete from employee where eid = '{txtid.Text}'";
                    fn.setData(query, "Record Deleated.");
                    TabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }

        private void UserControl4_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
