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

namespace Amazoom
{
    public partial class Home : Form
    {
        public List<goods> toCustomer = new List<goods>();
        public List<goods> stockList = new List<goods>();
        public List<goods> toCustomerZYX = new List<goods>();
        public int[] settings = new int[3];
        //public all stock;

        //public all stocks;
        public int total;
        public int mapX;
        public int mapY;
        public int numRobot;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
            

        }
        public Home()
        {
            InitializeComponent();
            textBoxTotal.Text = "10";
            textBoxX.Text = "9";
            textBoxY.Text = "9";
            textBoxRobots.Text = "5";
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            all stocks = new all();
            stocks.Initialize();
            //var customer = new customer.AO(stocks.getAll());
            var customer = new customer.AO(toCustomerZYX, settings);
            customer.Show();
        }

        public void Home_Load(object sender, EventArgs e)
        {
            /*goods item1 = new goods(100, "apple", 1, 3);
            goods item2 = new goods(100, "pear", 1, 4);
            goods item3 = new goods(100, "pineapple", 2, 2);
            goods item4 = new goods(100, "pipe", 3, 4);
            goods item5 = new goods(100, "sensor", 1, null, null, 2, 5);

            toCustomer.Add(new string[] { item1.goodsname, item1.num.ToString() });
            toCustomer.Add(new string[] { item2.goodsname, item2.num.ToString() });
            toCustomer.Add(new string[] { item3.goodsname, item3.num.ToString() });
            toCustomer.Add(new string[] { item4.goodsname, item4.num.ToString() });
            toCustomer.Add(new string[] { item5.goodsname, item5.num.ToString() });*/
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            var manager = new ManagerNew(stockList, null, null);
            manager.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            all stocks = new all();
            total = Convert.ToInt32(textBoxTotal.Text);
            mapX = Convert.ToInt32(textBoxX.Text);
            mapY = Convert.ToInt32(textBoxY.Text);
            numRobot = Convert.ToInt32(textBoxRobots.Text);

            settings[0] = mapX;
            settings[1] = mapY;
            settings[2] = numRobot;
            toCustomerZYX = stocks.addStocks(total, mapX, mapY);
            stockList = toCustomerZYX;
            //int XY = 10;
        }
    }
}
