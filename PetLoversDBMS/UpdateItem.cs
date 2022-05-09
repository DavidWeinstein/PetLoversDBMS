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
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string itemId = txtBxItemId.Text;
                string suppId = txtBxSuppId.Text;
                string itemName = txtBxName.Text;
                double price = Convert.ToDouble(txtBxPrice.Text);
                string type = txtBxType.Text;
                int qnt = Convert.ToInt32(txtBxQnt.Text);
                if (String.IsNullOrEmpty(itemId))
                {
                    string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
                    using (MySqlConnection cn = new MySqlConnection(scon))
                    {
                        cn.Open();
                        MySqlCommand cmd = new MySqlCommand(scon, cn);
                        cmd.CommandText = "INSERT INTO INVENTORY SET SUPPLIER_ID = (@1), ITEM_NAME = (@2), ITEM_PRICE = (@3), ITEM_TYPE = (@4), ITEM_QUANT = (@5)";
                        cmd.Parameters.AddWithValue("@1", suppId);
                        cmd.Parameters.AddWithValue("@2", itemName);
                        cmd.Parameters.AddWithValue("@3", price);
                        cmd.Parameters.AddWithValue("@4", type);
                        cmd.Parameters.AddWithValue("@5", qnt);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("New Item added!");
                        this.Close();
                    }
                } else
                {
                    string scon = "server=localhost;uid=root;pwd=admin123;database=petlovers";
                    using (MySqlConnection cn = new MySqlConnection(scon))
                    {
                        cn.Open();
                        MySqlCommand cmd = new MySqlCommand(scon, cn);
                        cmd.CommandText = "update inventory set SUPPLIER_ID = (@1), ITEM_NAME = (@2), ITEM_PRICE = (@3), ITEM_TYPE = (@4), ITEM_QUANT = (@5) where item_id = (@6)";
                        cmd.Parameters.AddWithValue("@1", suppId);
                        cmd.Parameters.AddWithValue("@2", itemName);
                        cmd.Parameters.AddWithValue("@3", price);
                        cmd.Parameters.AddWithValue("@4", type);
                        cmd.Parameters.AddWithValue("@5", qnt);
                        cmd.Parameters.AddWithValue("@6", itemId);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Item updated!");
                        this.Close();
                    }
                }
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
