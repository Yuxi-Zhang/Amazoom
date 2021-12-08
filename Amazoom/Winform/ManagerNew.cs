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
        public List<goods> stocks = new List<goods>();
        public ManagerNew(List<goods> stockList, List<int[,]> shoppinglist, int[] settings)
        {
            InitializeComponent();
            Program program = new Program();
            program.run(shoppinglist, 1, settings);
            stocks = stockList;
            PopulateDataGridView(stocks);
        }

        private void OrderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {


        }

        private void PopulateDataGridView(List<goods> stocks)
        {
            //string[] row0 = { "A", "2" };
            //string[] row1 = { "B", "5" };
            //string[] row2 = { "C", "2" };
            //goods.Add(row0);
            //goods.Add(row1);
            //goods.Add(row2);
            int i = 0;
            for (i = 0; i < stocks.Count; i++)
            {

                string s1 = stocks[i].goodsname;
                string s2 = stocks[i].num.ToString();
                string s3 = stocks[i].posX.ToString();
                string s4 = stocks[i].posY.ToString();
                string[] row1 = { s1, s2, s3, s4 };
                ItemInStock.Rows.Add(row1);
            }
        }
    }
}
