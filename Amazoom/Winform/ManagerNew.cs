using Amazoom.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazoom.Winform
{
    
    public partial class ManagerNew : Form
    {
        List<goods> stocks = new List<goods>();
        public ManagerNew(List<goods> stockList)
        {
            InitializeComponent();
            stocks = stockList;
        }

        private void OrderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {


        }
    }
}
