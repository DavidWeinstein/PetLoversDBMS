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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtBxName.Text;
                string addr = txtBxAddr.Text;
                string phone = txtBxPhone.Text;
                string site = txtBxSite.Text;
                string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
                using (MySqlConnection cn = new MySqlConnection(scon))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand(scon, cn);
                    cmd.CommandText = "INSERT INTO SUPPLIER SET SUPPLIER_NAME = (@1), SUPPLIER_ADDRESS = (@2), SUPPLIER_PHONE = (@3), SUPPLIER_SITE = (@4)";
                    cmd.Parameters.AddWithValue("@1", name);
                    cmd.Parameters.AddWithValue("@2", addr);
                    cmd.Parameters.AddWithValue("@3", phone);
                    cmd.Parameters.AddWithValue("@4", site);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("New supplier added!");
                    this.Close();
                }
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
