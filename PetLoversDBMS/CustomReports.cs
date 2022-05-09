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
    public partial class CustomReports : Form
    {
        public CustomReports()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            try
            {
                string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
                using (MySqlConnection cn = new MySqlConnection(scon))
                {
                    cn.Open();
                    MySqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "select item_id as 'Product Number', item_price as 'Price', item_quant as 'Quantity', s.supplier_name as 'Supplier' from inventory i, supplier s where s.supplier_id=i.supplier_id group by s.supplier_id, item_id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;
                    dataGridView1.DataSource = bindingSource;
                }
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
                using (MySqlConnection cn = new MySqlConnection(scon))
                {
                    cn.Open();
                    MySqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "select emp_id as 'Employee number', concat(emp_fname, ' ', emp_lname) as 'Employee Name', emp_address as 'Address', timestampdiff(year, emp_start, curdate()) as 'Current Length of Employ' from employee";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;
                    dataGridView1.DataSource = bindingSource;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
                using (MySqlConnection cn = new MySqlConnection(scon))
                {
                    cn.Open();
                    MySqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "select cust_fname as 'Customer First name', cust_lname as 'Last Name', pet_id as 'Pet ID' from customer c, pet p where c.cust_id=p.cust_id group by pet_id order by cust_lname";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;
                    dataGridView1.DataSource = bindingSource;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

        private void button4_Click(object sender, EventArgs e)
        {
            string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
            using (MySqlConnection cn = new MySqlConnection(scon))
            {
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select pet_id as 'Pet ID', timestampdiff(year, pet_dob, curdate()) as 'Age', pet_type as 'Type', pet_breed as 'Breed' from pet where pet_type = 'dog' order by pet_breed";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                dataGridView1.DataSource = bindingSource;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
            using (MySqlConnection cn = new MySqlConnection(scon))
            {
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select supplier_name 'Supplier name', supplier_address as 'Address' from supplier";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                dataGridView1.DataSource = bindingSource;
            }
        }
    }
}
