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
    public partial class CustomerOrder : Form
    {
        public Dictionary<string, int[]> orders = new Dictionary<string, int[]>();

        public CustomerOrder(Dictionary<string, int[]> dicOrder)
        {
            InitializeComponent();
            orders = dicOrder;

            PopulateDataGridView(orders);
        }

        private void PopulateDataGridView(Dictionary<string, int[]> orders)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                string s1 = orders.ElementAt(i).Key;
                int[] position = orders.ElementAt(i).Value;
                string posX = position[0].ToString();
                string posY = position[1].ToString();
                string[] row1 = { s1, posX, posY };
                dataGridView.Rows.Add(row1);
            }

        }
    }
}
