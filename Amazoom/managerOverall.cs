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
    public partial class managerOverall : Form
    {
        public managerOverall()
        {
            InitializeComponent();
        }


        private void Alert_Click(object sender, EventArgs e)
        {

        }

        private void RobotStatus_Click(object sender, EventArgs e)
        {

        }

        private void OrderStatus_Click(object sender, EventArgs e)
        {
            var Allorder = new OrderStatus();
            Allorder.Show();
        }

        private void Stock_Click(object sender, EventArgs e)
        {

        }

        private void managerOverall_Load(object sender, EventArgs e)
        {

        }
    }
}
