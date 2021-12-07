using Amazoom.Winform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazoom
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            var customer = new customer1();
            var ao = new customer.AO();

            customer.Show();
            ao.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            var admin = new managerOverall();
            admin.Show();

            var test = new Manager();
            test.Show();

        }
    }
}
