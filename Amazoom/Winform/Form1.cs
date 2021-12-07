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
        List<string[]> goods = new List<string[]>();

        List<string[]> shoppingList = new List<string[]>();
        int i = 0;
        public AO(List<string[]> list)
        {
            InitializeComponent();
            goods = list;
            PopulateDataGridView(goods);
            

        }
        
        private void PopulateDataGridView(List<string[]> goods)
        {
            /*string[] row0 = { "A", "2" };
            string[] row1 = { "B", "5" };
            string[] row2 = { "C", "2" };
            goods.Add(row0);
            goods.Add(row1);
            goods.Add(row2);*/

            for(i=0;i<goods.Count;i++)
            dataGridView.Rows.Add(goods[i]);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        string[] row1 = { "", "" };
            int i = 0;
        while (dataGridViewShoppingList.RowCount != 1)
        {
            row1[0] = dataGridViewShoppingList.Rows[0].Cells[0].Value.ToString();
            row1[1] = dataGridViewShoppingList.Rows[0].Cells[1].Value.ToString();
            shoppingList.Add(row1);
            dataGridViewShoppingList.Rows.RemoveAt(0);
        }

    }

    private void dataGridViewShoppingList_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewShoppingList.Rows.RemoveAt(dataGridViewShoppingList.SelectedRows[0].Index);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var manager = new Manager(shoppingList);

            manager.Show();
        }
    }
}
