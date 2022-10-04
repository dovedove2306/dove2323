using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.All__User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddRoom()
        {
            InitializeComponent();
        }
        public static DataTable globalTable=new DataTable();
        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataTable ds = fn.getData(query);
            globalTable = ds;
            dataGridView2.DataSource = ds;
        }
              
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                String roomno = txtRoomNo.Text;
                String type = txtType.Text;
                String bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into rooms (roomNo,roomType,bed,price) values ('"+roomno+ "','" + type + "','" + bed + "','" + price + "')";
                fn.setData(query, "Room Added.");

                UC_AddRoom_Load(this, null);
                clearAll();
                    
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning !! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } 
        public void clearAll()
        {
            txtRoomNo.Clear();
            txtType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();

        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();

        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);

        }
        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserControl1 usctl = new UserControl1();
            dataGridView2.CurrentRow.Selected = true;
         
            Dashboard.x1 = dataGridView2.Rows[e.RowIndex].Cells["roomNo"].Value.ToString();
            Dashboard.x2 = dataGridView2.Rows[e.RowIndex].Cells["roomType"].Value.ToString();
            Dashboard.x3 = dataGridView2.Rows[e.RowIndex].Cells["bed"].Value.ToString();
            Dashboard.x4 = dataGridView2.Rows[e.RowIndex].Cells["price"].Value.ToString();

          /* usctl.label_type.Text = dataGridView2.Rows[e.RowIndex].Cells["roomType"].Value.ToString();
            usctl.label_room.Text = dataGridView2.Rows[e.RowIndex].Cells["roomNo"].Value.ToString();*/



        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void label_Room_Click(object sender, EventArgs e)
        {

        }
    }
}
