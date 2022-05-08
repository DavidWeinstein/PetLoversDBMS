using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetLoversDBMS
{
    public partial class AddCustomer : Form
    {
        int custId;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
            using (MySqlConnection cn = new MySqlConnection(scon))
            {
                cn.Open();
                MySqlDataReader reader;
                string sql = "Select max(cust_id) from customer;";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    custId = reader.GetInt32(0);
                    custId++;
                }
                textBox1.Text = custId.ToString();
                textBox1.Enabled = false;
            }
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            string last, first, addr, number;
            last = txtBxLast.Text;
            first = txtBxFirst.Text;
            addr = txtBxAddr.Text;
            number = txtBxNum.Text;
            string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
            using (MySqlConnection cn = new MySqlConnection(scon))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(scon, cn);
                cmd.CommandText = "INSERT INTO CUSTOMER SET CUST_ID = (@1), CUST_LNAME = (@2), CUST_FNAME = (@3), CUST_ADDR = (@4), CUST_NUM = (@5)";
                cmd.Parameters.AddWithValue("@1", custId);
                cmd.Parameters.AddWithValue("@2", last);
                cmd.Parameters.AddWithValue("@3", first);
                cmd.Parameters.AddWithValue("@4", addr);
                cmd.Parameters.AddWithValue("@5", number);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            MessageBox.Show("Customer added sucessfully");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
