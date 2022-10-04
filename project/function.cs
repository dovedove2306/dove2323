using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project
{
    class function
    {
        private MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection("host=localhost;username=root;password=;database=myhotel; ");
            
            return con;
        }

        public DataTable getData(String query)
        {
            MySqlConnection con = getConnection(); 
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query,con) ;
            DataTable ds = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
            
        }

        public void setData(String query, String message)
        {
            MySqlConnection con = getConnection();           
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query,con);

            cmd.ExecuteNonQuery();
            con.Close();

            System.Windows.Forms.MessageBox.Show("'" + message + "'", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public DataSet GetData(String query)
        {
            MySqlConnection con = getConnection();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con); 
            //string sql = "SELECT * FROM equipment";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public MySqlDataReader getForCombo(String query)

        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader sdr = cmd.ExecuteReader();
            return sdr;

        }

    }
}

