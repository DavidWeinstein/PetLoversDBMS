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
    public partial class SellPet : Form
    {
        public SellPet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Visible = true;
            custLbl.Visible = true;
            
            txtBxCust.Visible = true;
            
            string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
            using (MySqlConnection cn = new MySqlConnection(scon))
            {
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select * from pet where cust_id is null";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                dataGridView1.DataSource = bindingSource;
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                
                try
                {
                    int petId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["pet_id"].Value);
                    int custId = int.Parse(txtBxCust.Text);
                    string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
                    using (MySqlConnection cn = new MySqlConnection(scon))
                    {

                        cn.Open();
                        MySqlCommand cmd = new MySqlCommand(scon, cn);
                        cmd.CommandText = "UPDATE PET SET CUST_ID = (@1) WHERE PET_ID = (@2)";
                        cmd.Parameters.AddWithValue("@1", custId);
                        cmd.Parameters.AddWithValue("@2", petId);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                    MessageBox.Show("Database updated successfully!");
                    this.Close();
                } catch (MySqlException ex)
                {
                    MessageBox.Show("Incorrect customer id selected. Check and try again.");
                }
                
            }
        }
    }
}
