using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PetReport form2 = new PetReport();
            form2.Show();
            
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void btnEmpl_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(); 
            employee.Show();
        }

        private void btnCustRep_Click(object sender, EventArgs e)
        {
            CustomReports customReports = new CustomReports();
            customReports.Show();
        }
    }
}
