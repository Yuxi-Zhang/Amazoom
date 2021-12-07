
namespace Amazoom.Winform
{
    partial class ManagerNew
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
            this.StockItem = new System.Windows.Forms.TextBox();
            this.RobotStatus = new System.Windows.Forms.TextBox();
            this.CustomerOrder = new System.Windows.Forms.TextBox();
            this.LowStock = new System.Windows.Forms.TextBox();
            this.OrderTree = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restock = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.RobotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // StockItem
            // 
            this.StockItem.BackColor = System.Drawing.Color.Gainsboro;
            this.StockItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.StockItem.Location = new System.Drawing.Point(1144, 145);
            this.StockItem.Name = "StockItem";
            this.StockItem.Size = new System.Drawing.Size(250, 38);
            this.StockItem.TabIndex = 0;
            this.StockItem.Text = "Item in Stock";
            // 
            // RobotStatus
            // 
            this.RobotStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.RobotStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RobotStatus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotStatus.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RobotStatus.Location = new System.Drawing.Point(216, 729);
            this.RobotStatus.Name = "RobotStatus";
            this.RobotStatus.Size = new System.Drawing.Size(250, 38);
            this.RobotStatus.TabIndex = 1;
            this.RobotStatus.Text = "Robot Status";
            // 
            // CustomerOrder
            // 
            this.CustomerOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.CustomerOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerOrder.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOrder.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CustomerOrder.Location = new System.Drawing.Point(195, 145);
            this.CustomerOrder.Name = "CustomerOrder";
            this.CustomerOrder.Size = new System.Drawing.Size(295, 38);
            this.CustomerOrder.TabIndex = 2;
            this.CustomerOrder.Text = "Customers\' order";
            // 
            // LowStock
            // 
            this.LowStock.BackColor = System.Drawing.Color.Gainsboro;
            this.LowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LowStock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowStock.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LowStock.Location = new System.Drawing.Point(1128, 729);
            this.LowStock.Name = "LowStock";
            this.LowStock.Size = new System.Drawing.Size(280, 38);
            this.LowStock.TabIndex = 3;
            this.LowStock.Text = "Low Stock Alert\r\n\r\n";
            // 
            // OrderTree
            // 
            this.OrderTree.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTree.Location = new System.Drawing.Point(216, 276);
            this.OrderTree.Name = "OrderTree";
            this.OrderTree.Size = new System.Drawing.Size(243, 197);
            this.OrderTree.TabIndex = 4;
            this.OrderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OrderTree_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.Quantity,
            this.Location});
            this.dataGridView1.Location = new System.Drawing.Point(945, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(684, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 10;
            this.ItemID.Name = "ItemID";
            this.ItemID.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 10;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 200;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 10;
            this.Location.Name = "Location";
            this.Location.Width = 200;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.RemainQuantity,
            this.Restock});
            this.dataGridView2.Location = new System.Drawing.Point(945, 858);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(684, 150);
            this.dataGridView2.TabIndex = 6;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 10;
            this.Item.Name = "Item";
            this.Item.Width = 200;
            // 
            // RemainQuantity
            // 
            this.RemainQuantity.HeaderText = "RemainQuantity";
            this.RemainQuantity.MinimumWidth = 10;
            this.RemainQuantity.Name = "RemainQuantity";
            this.RemainQuantity.Width = 200;
            // 
            // Restock
            // 
            this.Restock.HeaderText = "Restock";
            this.Restock.MinimumWidth = 10;
            this.Restock.Name = "Restock";
            this.Restock.Width = 200;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RobotID,
            this.Status});
            this.dataGridView3.Location = new System.Drawing.Point(216, 858);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(491, 150);
            this.dataGridView3.TabIndex = 7;
            // 
            // RobotID
            // 
            this.RobotID.HeaderText = "RobotID";
            this.RobotID.MinimumWidth = 10;
            this.RobotID.Name = "RobotID";
            this.RobotID.Width = 200;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.Width = 200;
            // 
            // ManagerNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1188);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OrderTree);
            this.Controls.Add(this.LowStock);
            this.Controls.Add(this.CustomerOrder);
            this.Controls.Add(this.RobotStatus);
            this.Controls.Add(this.StockItem);
            this.Name = "ManagerNew";
            this.Text = "a";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StockItem;
        private System.Windows.Forms.TextBox RobotStatus;
        private System.Windows.Forms.TextBox CustomerOrder;
        private System.Windows.Forms.TextBox LowStock;
        private System.Windows.Forms.TreeView OrderTree;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn Restock;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}