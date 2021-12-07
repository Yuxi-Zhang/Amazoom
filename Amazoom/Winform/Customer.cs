using Amazoom;
using Amazoom.Item;
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



// input: List<string[]> goods = new List<string[]>();
// goods is an input list from other form, it contains good names and quantity
// output:  List<string[]> shoppingList = new List<string[]>();
// shoppinglist is the output list from the program, the first element is the item name and the second element is the quantity.




namespace customer
{
    public partial class AO : Form
    {
        List<goods> goods = new List<goods>();
        List<string[]> shoppingList = new List<string[]>();
        List<int[,]> fromCustomer = new List<int[,]>();
        int[] settingXYR;

        int i = 0;
        public AO(List<goods> stocks, int[] settings)
        {
            InitializeComponent();
            goods = stocks;
            settingXYR = settings;
            PopulateDataGridView(stocks);
        }
        
        private void PopulateDataGridView(List<goods> stocks)
        {
            //string[] row0 = { "A", "2" };
            //string[] row1 = { "B", "5" };
            //string[] row2 = { "C", "2" };
            //goods.Add(row0);
            //goods.Add(row1);
            //goods.Add(row2);

            for (i = 0; i < stocks.Count; i++)
            {

                string s1 = stocks[i].goodsname;
                string s2 = stocks[i].num.ToString();

                string[] row1 = { s1, s2 };
                dataGridView.Rows.Add(row1);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(dataGridView.SelectedRows[]);
            //var a = dataGridView.SelectedRows[0].Index;
            //dataGridViewShoppingList.Rows.Add(dataGridView.Rows[a]);

            string[] row1 = { "", "" };
            string value1 = " ";
            string value2 = " ";
            int i = 0;

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                row1[0] = row.Cells[0].Value.ToString();
                row1[1] = row.Cells[1].Value.ToString();
                dataGridViewShoppingList.Rows.Add(row1);

            }

            //string[,] Row = { value1, value2 };
        }

        //dataGridViewShoppingList.Rows.Add(row1);
    

    private void button1_Click(object sender, EventArgs e)
    {
        //string[] row1 = { "", "" };
        //int i = 0;
        string name;
        string num;
        while (dataGridViewShoppingList.RowCount != 1)
        {
            //row1[0] = dataGridViewShoppingList.Rows[0].Cells[0].Value.ToString();
            //row1[1] = dataGridViewShoppingList.Rows[0].Cells[1].Value.ToString();
            name = dataGridViewShoppingList.Rows[0].Cells[0].Value.ToString();
            num = dataGridViewShoppingList.Rows[0].Cells[1].Value.ToString();
            shoppingList.Add(new string[] { name, num });
            dataGridViewShoppingList.Rows.RemoveAt(0);
        }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewShoppingList.Rows.RemoveAt(dataGridViewShoppingList.SelectedRows[0].Index);
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            //shoppingList 
            while (shoppingList.Count != 0)
            {
                for (int i = 0; i < goods.Count; i++)
                {
                    string shopping = shoppingList[0][0];
                    string goodsname = goods[i].goodsname;
                    bool flag = (shopping == goodsname);
                    if (goods[i].goodsname == shoppingList[0][0])
                    {
                        x = goods[i].posX;
                        y = goods[i].posY;
                        fromCustomer.Add(new int[,] { { x, y } });
                        shoppingList.RemoveAt(0);
                        // important! remove完后shoppingList后，可能会继续遍历goods[i]导致out of range
                        if (shoppingList.Count <= 0)
                        {
                            break;
                        }
                    }
                }
            }
            

            var manager = new Manager(fromCustomer, settingXYR);

            manager.Show();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            var newCustomer = new customer.AO(goods, settingXYR);
            newCustomer.Show();
        }
    }
}
