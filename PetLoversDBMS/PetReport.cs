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
    public partial class PetReport : Form
    {
        public PetReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
            using (MySqlConnection cn = new MySqlConnection(scon) )
            {
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select * from pet";

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
