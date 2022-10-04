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
    public partial class UserControl3 : UserControl
    {
        function fn = new function();
        String query;
        public UserControl3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0)
            {
                query = "select * from customer ";
                getRecord(query);
            }
            else if(txtSearchBy.SelectedIndex == 1)
            {
                query = "select * from customer WHERE checkout ='' ";
                getRecord(query);
            }
            else if (txtSearchBy.SelectedIndex == 2)
            {
                query = "select * from customer WHERE checkout !='' ";
                getRecord(query);
            }
        }
        private void getRecord(String query)
        {
            DataSet ds = fn.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }
    }
}
