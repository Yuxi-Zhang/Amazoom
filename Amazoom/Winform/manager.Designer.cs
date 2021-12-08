
namespace WindowsFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.IteminStock = new System.Windows.Forms.DataGridView();
            this.Item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Alert = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restock = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.RobotStatus = new System.Windows.Forms.DataGridView();
            this.RobotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Robot_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerOrder = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.IteminStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_Alert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RobotStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1119, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 52);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Items in Stock";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(255, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 38);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Customers\' Order";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox3.Location = new System.Drawing.Point(255, 847);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(289, 38);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Low Stock Alert";
            // 
            // IteminStock
            // 
            this.IteminStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.IteminStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.IteminStock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.IteminStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IteminStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_name,
            this.Item_number,
            this.Item_location});
            this.IteminStock.Location = new System.Drawing.Point(910, 114);
            this.IteminStock.Name = "IteminStock";
            this.IteminStock.RowHeadersWidth = 82;
            this.IteminStock.RowTemplate.Height = 33;
            this.IteminStock.Size = new System.Drawing.Size(687, 222);
            this.IteminStock.TabIndex = 4;
            // 
            // Item_name
            // 
            this.Item_name.HeaderText = "Item_name";
            this.Item_name.MinimumWidth = 10;
            this.Item_name.Name = "Item_name";
            this.Item_name.Width = 162;
            // 
            // Item_number
            // 
            this.Item_number.HeaderText = "Item_number";
            this.Item_number.MinimumWidth = 10;
            this.Item_number.Name = "Item_number";
            this.Item_number.Width = 181;
            // 
            // Item_location
            // 
            this.Item_location.HeaderText = "Item_location";
            this.Item_location.MinimumWidth = 10;
            this.Item_location.Name = "Item_location";
            this.Item_location.Width = 184;
            // 
            // Stock_Alert
            // 
            this.Stock_Alert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Stock_Alert.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Stock_Alert.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Stock_Alert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stock_Alert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemQuantity});
            this.Stock_Alert.Location = new System.Drawing.Point(39, 922);
            this.Stock_Alert.Name = "Stock_Alert";
            this.Stock_Alert.RowHeadersWidth = 82;
            this.Stock_Alert.RowTemplate.Height = 33;
            this.Stock_Alert.Size = new System.Drawing.Size(693, 150);
            this.Stock_Alert.TabIndex = 6;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 10;
            this.ItemID.Name = "ItemID";
            this.ItemID.Width = 117;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "ItemQuantity";
            this.ItemQuantity.MinimumWidth = 10;
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Width = 177;
            // 
            // Restock
            // 
            this.Restock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restock.Location = new System.Drawing.Point(39, 1100);
            this.Restock.Name = "Restock";
            this.Restock.Size = new System.Drawing.Size(336, 88);
            this.Restock.TabIndex = 7;
            this.Restock.Text = "Restock Selected";
            this.Restock.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(1158, 847);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(236, 38);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Robot Status";
            // 
            // RobotStatus
            // 
            this.RobotStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RobotStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RobotStatus.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.RobotStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RobotStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RobotID,
            this.Robot_Status});
            this.RobotStatus.Location = new System.Drawing.Point(910, 922);
            this.RobotStatus.Name = "RobotStatus";
            this.RobotStatus.RowHeadersWidth = 82;
            this.RobotStatus.RowTemplate.Height = 33;
            this.RobotStatus.Size = new System.Drawing.Size(687, 150);
            this.RobotStatus.TabIndex = 9;
            // 
            // RobotID
            // 
            this.RobotID.HeaderText = "RobotID";
            this.RobotID.MinimumWidth = 10;
            this.RobotID.Name = "RobotID";
            this.RobotID.Width = 134;
            // 
            // Robot_Status
            // 
            this.Robot_Status.HeaderText = "Robot_Status";
            this.Robot_Status.MinimumWidth = 10;
            this.Robot_Status.Name = "Robot_Status";
            this.Robot_Status.Width = 187;
            // 
            // CustomerOrder
            // 
            this.CustomerOrder.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOrder.Location = new System.Drawing.Point(181, 114);
            this.CustomerOrder.Name = "CustomerOrder";
            this.CustomerOrder.Size = new System.Drawing.Size(436, 222);
            this.CustomerOrder.TabIndex = 10;
            this.CustomerOrder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CustomerOrder_AfterSelect);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 1535);
            this.Controls.Add(this.CustomerOrder);
            this.Controls.Add(this.RobotStatus);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Restock);
            this.Controls.Add(this.Stock_Alert);
            this.Controls.Add(this.IteminStock);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Manager";
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.IteminStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_Alert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RobotStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView IteminStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_location;
        private System.Windows.Forms.DataGridView Stock_Alert;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.Button Restock;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView RobotStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Robot_Status;
        private System.Windows.Forms.TreeView CustomerOrder;
    }
}