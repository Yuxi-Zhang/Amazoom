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
    public partial class customer1: Form
    {
        public customer1()
        {
            InitializeComponent();
        }

        private void customer1_Load(object sender, EventArgs e)
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = 3;
            panel.RowCount = 1;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panel.Controls.Add(new Label() { Text = "Address" }, 1, 0);
            panel.Controls.Add(new Label() { Text = "Contact No" }, 2, 0);
            panel.Controls.Add(new Label() { Text = "Email ID" }, 3, 0);

            // For Add New Row (Loop this code for add multiple rows)
            panel.RowCount = panel.RowCount + 1;
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panel.Controls.Add(new Label() { Text = "Street, City, State" }, 1, panel.RowCount - 1);
            panel.Controls.Add(new Label() { Text = "888888888888" }, 2, panel.RowCount - 1);
            panel.Controls.Add(new Label() { Text = "xxxxxxx@gmail.com" }, 3, panel.RowCount - 1);

        }

        private void Aplus_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Aquantity.Text) + 1;
            Aquantity.Text = count.ToString();
        }

        private void Aminus_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Aquantity.Text) - 1;

            if (count <= 0)
            {
                count = 0;
            }
            Aquantity.Text = count.ToString();
        }

        private void AddItem(string item, string status, string quantity)
        {
            //get a reference to the previous existent 
            RowStyle temp = cart.RowStyles[cart.RowCount - 1];
            //increase panel rows count by one
            cart.RowCount++;
            //add a new RowStyle as a copy of the previous one
            cart.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //add controls
            cart.Controls.Add(new Label() {Text = item, TextAlign = ContentAlignment.MiddleCenter, Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left) }, 0, cart.RowCount - 1);
            cart.Controls.Add(new TextBox() {Text = status, TextAlign = HorizontalAlignment.Center, Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left), Multiline=true }, 1, cart.RowCount - 1);
            cart.Controls.Add(new TextBox() {Text = quantity, TextAlign = HorizontalAlignment.Center, Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left), Multiline = true }, 2, cart.RowCount - 1);
            cart.Controls.Add(new Button() {Text = "+", Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left) }, 3, cart.RowCount - 1);
            cart.Controls.Add(new Button() {Text = "-", Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left) }, 4, cart.RowCount - 1);
        }

        private void order_Click(object sender, EventArgs e)
        {
            AddItem("AA", "in stocks", "80");
        }


    }
}
