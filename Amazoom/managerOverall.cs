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
            var alert = new Alert();
            alert.Show();
        }

        private void RobotStatus_Click(object sender, EventArgs e)
        {
            var robotstatus = new StatusOfRobot();
            robotstatus.Show();
        }

        private void OrderStatus_Click(object sender, EventArgs e)
        {
            var Allorder = new OrderStatus();
            Allorder.Show();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            var stockstatus = new Stock();
            stockstatus.Show();
        }

        private void managerOverall_Load(object sender, EventArgs e)
        {

        }
    }
}
