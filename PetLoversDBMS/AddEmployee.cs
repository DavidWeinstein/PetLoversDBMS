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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string last = txtBxLast.Text;
                string first = txtBxFirst.Text;
                string addr = txtBxAddr.Text;
                string phone = txtBxPhon.Text;
                string dep = txtBxDep.Text;
                string sal = txtBxSal.Text;
                DateTime dob = dateTimePicker1.Value;
                DateTime start = dateTimePicker2.Value;
                string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
                using (MySqlConnection cn = new MySqlConnection(scon))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand(scon, cn);
                    cmd.CommandText = "INSERT INTO employee set emp_lname = (@1), emp_fname = (@2), emp_address = (@3), emp_phone = (@8), emp_depenedants = (@4), emp_salary = (@5), emp_dob = (@6), emp_start = (@7)";
                    cmd.Parameters.AddWithValue("@1", last);
                    cmd.Parameters.AddWithValue("@2", first);
                    cmd.Parameters.AddWithValue("@3", addr);
                    cmd.Parameters.AddWithValue("@4", dep);
                    cmd.Parameters.AddWithValue("@5", sal);
                    cmd.Parameters.AddWithValue("@6", dob);
                    cmd.Parameters.AddWithValue("@7", start);
                    cmd.Parameters.AddWithValue("@8", phone);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("New Employee added!");
                    this.Close();
                }
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "error");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");

            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
