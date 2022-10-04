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
    public partial class UserControl1 : UserControl

    {

        function fn = new function();
        String query;
        public UserControl1()
        {
            InitializeComponent();
        }
        private MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection("host=localhost;username=root;password=;database=myhotel; ");

            return con;
        }
        public void setComboBox(String query, ComboBox combo)
        {
            MySqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
                MessageBox.Show(query);
            }    
            sdr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCheckIn_ValueChanged(object sender, EventArgs e)
        {
            //txtRoomNo.Items.Clear();
            //txtPrice.Clear();
            //query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and roomType='" + txtRoomNo.Text + "'and booked= 'No'  ";
            //setComboBox(query, txtRoomNo);
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and roomType ='" + txtRoomType.Text + "'  and booked= 'No'";
            
            setComboBox(query, txtRoomNo);
            


        }
        
        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }
        
        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con = getConnection();
            con.Open();
            string sql = "SELECT * FROM rooms where roomType = '" + txtRoomNo.Text + "'";
            var cmd = new MySqlCommand(sql, con);
            DataTable dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtRoomType.Text=dt.Rows[i][1].ToString();
            }
            con.Close();
        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtcontact.Text != "" && txtNatinolity.Text != "" && txtGender.Text != "" && txtdate.Text != "" && txtIDProof.Text != "" && txtAddress.Text != "" && txtCheckIn.Text != "" && txtPrice.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtcontact.Text);
                string national = txtNatinolity.Text;
                string gender = txtGender.Text;
                string dob = txtdate.Text;
                string address = txtAddress.Text;
                string checkin = txtCheckIn.Text;
                string idproof = txtIDProof.Text;

                query = " insert into customer(cname,moblie,nationality,gender,dob,idproof,addres,checkin,roomid	) values('" + name + "'," + mobile + ",'" + national + "','" + gender + "','" + dob + "','" + idproof + "','" + address + "','" + checkin + "','" + txtRoomNo.Text +"')";
                fn.setData(query, " Room No " + txtRoomNo.Text + "Allocation Successful.");
                clearAll();
            }
            else
            {
                MessageBox.Show("AllowDrop fields are madrtory.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            
            txtName.Clear();
            txtcontact.Clear();
            txtNatinolity.Clear();
            txtGender.SelectedIndex = -1;
            txtdate.ResetText();
            txtIDProof.Clear();
            txtAddress.Clear();
            txtBed.SelectedIndex = -1;
            txtCheckIn.ResetText();
            txtRoomNo.Items.Clear();
            txtRoomNo.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void UserControl1_Leave(object sender, EventArgs e)
        {
           
        }
        private void UserControl1_()
        {
            var con = getConnection();
            con.Open();
            string sql = "SELECT * FROM rooms where bed = '" + txtBed.Text + "' and roomType != 'Non-Ac'";
            var cmd = new MySqlCommand(sql, con);
            DataTable dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtRoomNo.Items.Add(dt.Rows[i][1].ToString());
            }
            con.Close();
        }
        public static string x1, x2, x3, x4;
        private void UserControl1_Load(object sender, EventArgs e)
        {
          
        }

        private void txtRoomNo_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text == "Non-Ac")
            {
                txtRoomNo.Items.Clear();
            }
            else
            {

                txtRoomNo.Items.Clear();

                UserControl1_();
            }
        }

        private void txtIDProof_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) )
            {
                e.Handled = true;
            }
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) )
            {
                e.Handled = true;
                
            }
            

        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {
            DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        }

        private void label14_Click(object sender, EventArgs e)
        {

            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where roomType = '" + txtRoomType.Text + "' and roomNo='" + txtRoomNo.Text + "'and booked= 'No'  ";
            setComboBox(query, txtRoomNo);
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtRoomType.Text = x2;
            //txtRoomNo.Text = x1;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_ChangeUICues(object sender, UICuesEventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            txtBed.Text = x3;
            txtPrice.Text = x4;
            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
