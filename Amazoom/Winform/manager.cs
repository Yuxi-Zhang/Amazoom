using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Manager : Form
    {
        public Manager(List<int[,]> shoppinglist, int[] settings)
        {
            InitializeComponent();
            Program program = new Program();
            program.run(shoppinglist, 1, settings);
        }

        private void CustomerOrder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listBoxStocks.Items.Add("Item222");
            listBoxOrders.Items.Add("Check!");
        }
    }
}
