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
                    //cmd.CommandText = "UPDATE CUSTOMER SET PET_ID = (@3) WHERE CUST_ID = (@4)";
                    //cmd.Parameters.AddWithValue("@3", petId);
                    //cmd.Parameters.AddWithValue("@4", custId);
                    //cmd.ExecuteNonQuery();
                    cn.Close();
                }
                MessageBox.Show("Database updated successfully!");
                this.Close();
            }
        }

        //private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dataGridView1.CurrentRow.Selected)
        //    {
        //        int rowInd = dataGridView1.SelectedCells[0].RowIndex;
        //        DataGridViewRow row = dataGridView1.Rows[rowInd];
        //        int petId = Convert.ToInt32(row.Cells["cust_id"].Value);
        //        int custId = int.Parse(txtBxCust.Text);
        //        txtBxPet.Text = petId.ToString();
        //        txtBxPet.Enabled = false;
        //        string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
        //        using (MySqlConnection cn = new MySqlConnection(scon))
        //        {
        //            cn.Open();
        //            MySqlCommand cmd = new MySqlCommand(scon, cn);
        //            cmd.CommandText = "UPDATE PET SET CUST_ID = (@1) WHERE PET_ID = (@2)";
        //            cmd.Parameters.AddWithValue("@1", custId);
        //            cmd.Parameters.AddWithValue("@2", petId);
        //            cmd.ExecuteNonQuery();
        //            cmd.CommandText = "UPDATE CUSTOMER SET PET_ID = (@1) WHERE CUST_ID = (@2)";
        //            cmd.Parameters.AddWithValue("@1", petId);
        //            cmd.Parameters.AddWithValue("@2", custId);
        //            cmd.ExecuteNonQuery();
        //            cn.Close();
        //        }
        //    }
        //}
    }
}
