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
    public partial class AddPet : Form
    {
        public AddPet()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string type, breed, health, nutr, temp;
            DateTime dob = new DateTime();
            type = txtBxType.Text;
            breed = txtBxBreed.Text;
            health = txtBxHlth.Text;
            nutr = txtBxNut.Text;
            temp = txtBxTemp.Text;
            dob = dateTimeDOB.Value;
            string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
            using (MySqlConnection cn = new MySqlConnection(scon))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(scon, cn);
                cmd.CommandText = "INSERT INTO PET SET pet_type = (@1), pet_breed = (@2), pet_health = (@3), pet_nutr = (@4), pet_temp = (@5), pet_dob = (@6)";
                cmd.Parameters.AddWithValue("@1", type);
                cmd.Parameters.AddWithValue("@2", breed);
                cmd.Parameters.AddWithValue("@3", health);
                cmd.Parameters.AddWithValue("@4", nutr);
                cmd.Parameters.AddWithValue("@5", temp);
                cmd.Parameters.AddWithValue("@6", dob);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            MessageBox.Show("Pet added sucessfully");
            this.Close();
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
