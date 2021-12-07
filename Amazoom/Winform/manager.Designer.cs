namespace Amazoom.Winform
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxStocks = new System.Windows.Forms.ListBox();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.listBoxOut = new System.Windows.Forms.ListBox();
            this.listBoxWait = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDownRestock = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxAlert = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(987, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items in stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(987, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Orders ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1380, 734);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Out for delivery";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(980, 638);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 42);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wait for delivery ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1380, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 42);
            this.label5.TabIndex = 6;
            this.label5.Text = "Delivery truck";
            // 
            // listBoxStocks
            // 
            this.listBoxStocks.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStocks.FormattingEnabled = true;
            this.listBoxStocks.ItemHeight = 36;
            this.listBoxStocks.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3",
            "Item4",
            "Item5",
            "Item6",
            "Item7",
            "Item8",
            "Item9",
            "Item10"});
            this.listBoxStocks.Location = new System.Drawing.Point(987, 102);
            this.listBoxStocks.Name = "listBoxStocks";
            this.listBoxStocks.Size = new System.Drawing.Size(233, 148);
            this.listBoxStocks.TabIndex = 7;
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 36;
            this.listBoxOrders.Location = new System.Drawing.Point(987, 414);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(233, 148);
            this.listBoxOrders.TabIndex = 8;
            // 
            // listBoxOut
            // 
            this.listBoxOut.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOut.FormattingEnabled = true;
            this.listBoxOut.ItemHeight = 36;
            this.listBoxOut.Location = new System.Drawing.Point(1380, 790);
            this.listBoxOut.Name = "listBoxOut";
            this.listBoxOut.Size = new System.Drawing.Size(233, 148);
            this.listBoxOut.TabIndex = 9;
            // 
            // listBoxWait
            // 
            this.listBoxWait.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWait.FormattingEnabled = true;
            this.listBoxWait.ItemHeight = 36;
            this.listBoxWait.Location = new System.Drawing.Point(987, 698);
            this.listBoxWait.Name = "listBoxWait";
            this.listBoxWait.Size = new System.Drawing.Size(233, 148);
            this.listBoxWait.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1380, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(458, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "Maximum loading weight";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1380, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 65);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delivery";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1744, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 68);
            this.button2.TabIndex = 13;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1380, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 68);
            this.button3.TabIndex = 14;
            this.button3.Text = "Restock";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRestock
            // 
            this.numericUpDownRestock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRestock.Location = new System.Drawing.Point(1699, 273);
            this.numericUpDownRestock.Name = "numericUpDownRestock";
            this.numericUpDownRestock.Size = new System.Drawing.Size(120, 50);
            this.numericUpDownRestock.TabIndex = 15;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(1619, 616);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 50);
            this.numericUpDown2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1380, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 42);
            this.label7.TabIndex = 17;
            this.label7.Text = "Restock Item: ";
            // 
            // listBoxAlert
            // 
            this.listBoxAlert.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlert.FormattingEnabled = true;
            this.listBoxAlert.ItemHeight = 36;
            this.listBoxAlert.Location = new System.Drawing.Point(1380, 101);
            this.listBoxAlert.Name = "listBoxAlert";
            this.listBoxAlert.Size = new System.Drawing.Size(233, 148);
            this.listBoxAlert.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1380, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 42);
            this.label8.TabIndex = 18;
            this.label8.Text = "Alert";
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX.Location = new System.Drawing.Point(213, 46);
            this.textBoxX.Multiline = true;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 35);
            this.textBoxX.TabIndex = 20;
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxY.Location = new System.Drawing.Point(525, 46);
            this.textBoxY.Multiline = true;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 35);
            this.textBoxY.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(358, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 42);
            this.label9.TabIndex = 22;
            this.label9.Text = "mapY:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 42);
            this.label10.TabIndex = 23;
            this.label10.Text = "mapX:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(686, 31);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(118, 50);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 1040);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.listBoxAlert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDownRestock);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxWait);
            this.Controls.Add(this.listBoxOut);
            this.Controls.Add(this.listBoxOrders);
            this.Controls.Add(this.listBoxStocks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Manager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxStocks;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.ListBox listBoxOut;
        private System.Windows.Forms.ListBox listBoxWait;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDownRestock;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxAlert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAdd;
    }
}