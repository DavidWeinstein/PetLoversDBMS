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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string lowQuant = "The following need a reorder soon:" + Environment.NewLine;
            string newLine = Environment.NewLine;
            string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
            using (MySqlConnection cn = new MySqlConnection(scon))
            {
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select * from inventory";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                dataGridView1.DataSource = bindingSource;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(5) < 10)
                    {
                        lowQuant += reader.GetString(2) + newLine;
                    }
                }

            }
            MessageBox.Show(lowQuant);
        }

        private void btnShowSupp_Click(object sender, EventArgs e)
        {
            string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
            using (MySqlConnection cn = new MySqlConnection(scon))
            {
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select * from supplier";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                dataGridView1.DataSource = bindingSource;
                

            }
        }

        private void btnUpdateItm_Click(object sender, EventArgs e)
        {
            UpdateItem updateItem = new UpdateItem();
            updateItem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.Show();
        }
    }
}
