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

            customer.Show();
        }
    }
}
