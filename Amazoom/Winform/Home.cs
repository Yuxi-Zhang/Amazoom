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
        public List<string[]> toCustomer = new List<string[]>();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());         
        }
        public Home()
        {
            InitializeComponent();
            //Home_Load(object sender, EventArgs e);
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
           // var customer = new customer1();
            var ao = new customer.AO(toCustomer);

            //customer.Show();
            ao.Show();
        }

        public void Home_Load(object sender, EventArgs e)
        {
            goods item1 = new goods(100, "apple", 1, null, null, 1, 3);
            goods item2 = new goods(100, "pear", 1, null, null, 1, 4);
            goods item3 = new goods(100, "pineapple", 1, null, null, 2, 2);
            goods item4 = new goods(100, "pipe", 1, null, null, 3, 4);
            goods item5 = new goods(100, "sensor", 1, null, null, 2, 5);

            //List<string[]> toCustomer = new List<string[]>();

            toCustomer.Add(new string[] { item1.goodsname, item1.num.ToString() });
            toCustomer.Add(new string[] { item2.goodsname, item2.num.ToString() });
            toCustomer.Add(new string[] { item3.goodsname, item3.num.ToString() });
            toCustomer.Add(new string[] { item4.goodsname, item4.num.ToString() });
            toCustomer.Add(new string[] { item5.goodsname, item5.num.ToString() });
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            var admin = new managerOverall();
            admin.Show();

            var test = new Manager(toCustomer);
            test.Show();

        }
    }
}
