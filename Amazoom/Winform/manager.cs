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
    public partial class Manager: Form
    {
        public Manager(List<string[]> shoppinglist)
        {
            InitializeComponent();
            Program program = new Program();
            program.run(shoppinglist, 1);
        }


        int count = 0;
        int X = 1, Y = 1;

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            while(count< int.Parse(textBoxX.Text) * int.Parse(textBoxY.Text))
            {
                for (int i = 0; i <= X-1; i++)
                {
                    Button btn = new Button();
                    btn.Text = (count / int.Parse(textBoxX.Text)).ToString() + (count % int.Parse(textBoxX.Text)).ToString();
                    btn.Name = (count / int.Parse(textBoxX.Text)).ToString() + (count % int.Parse(textBoxX.Text)).ToString();
                    //btn.BackColor = Color.Red;
                    btn.Size = new Size(35, 35);
                    btn.Location = new Point(30 * (i + 2)-20, 30 * Y+20);
                    Controls.Add(btn);
                }

                if (X == int.Parse(textBoxX.Text))
                {
                    X = 0;
                    Y++;
                }

                if (count == int.Parse(textBoxX.Text) * int.Parse(textBoxY.Text))
                {
                    buttonAdd.Enabled = false;
                }
                count++;
                X++;
            }

            //Convert.ToString(44).BackColor = Color.Red;
            //button = this.button.GetControlFromPosition(j, i);
            //button.BackColor = Color.BLACK;
            //a33.BackColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxStocks.Items.Add("Item222");
            listBoxOrders.Items.Add("Check!");


            

        }


    }
}
