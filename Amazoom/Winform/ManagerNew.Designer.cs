
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
            this.ItemInStock = new System.Windows.Forms.DataGridView();
            this.StockAlert = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restock = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StatusRobot = new System.Windows.Forms.DataGridView();
            this.RobotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusRobot)).BeginInit();
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
            this.OrderTree.Location = new System.Drawing.Point(195, 254);
            this.OrderTree.Name = "OrderTree";
            this.OrderTree.Size = new System.Drawing.Size(295, 238);
            this.OrderTree.TabIndex = 4;
            this.OrderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OrderTree_AfterSelect);
            // 
            // ItemInStock
            // 
            this.ItemInStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemInStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.Quantity,
            this.PositionX,
            this.PositionY});
            this.ItemInStock.Location = new System.Drawing.Point(864, 275);
            this.ItemInStock.Name = "ItemInStock";
            this.ItemInStock.RowHeadersWidth = 82;
            this.ItemInStock.RowTemplate.Height = 33;
            this.ItemInStock.Size = new System.Drawing.Size(778, 150);
            this.ItemInStock.TabIndex = 5;
            // 
            // StockAlert
            // 
            this.StockAlert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockAlert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.RemainQuantity,
            this.Restock});
            this.StockAlert.Location = new System.Drawing.Point(945, 858);
            this.StockAlert.Name = "StockAlert";
            this.StockAlert.RowHeadersWidth = 82;
            this.StockAlert.RowTemplate.Height = 33;
            this.StockAlert.Size = new System.Drawing.Size(684, 150);
            this.StockAlert.TabIndex = 6;
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
            // StatusRobot
            // 
            this.StatusRobot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatusRobot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RobotID,
            this.Status});
            this.StatusRobot.Location = new System.Drawing.Point(216, 858);
            this.StatusRobot.Name = "StatusRobot";
            this.StatusRobot.RowHeadersWidth = 82;
            this.StatusRobot.RowTemplate.Height = 33;
            this.StatusRobot.Size = new System.Drawing.Size(491, 150);
            this.StatusRobot.TabIndex = 7;
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
            // PositionX
            // 
            this.PositionX.HeaderText = "Positionx";
            this.PositionX.MinimumWidth = 10;
            this.PositionX.Name = "PositionX";
            this.PositionX.Width = 200;
            // 
            // PositionY
            // 
            this.PositionY.HeaderText = "PositionY";
            this.PositionY.MinimumWidth = 10;
            this.PositionY.Name = "PositionY";
            this.PositionY.Width = 200;
            // 
            // ManagerNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1188);
            this.Controls.Add(this.StatusRobot);
            this.Controls.Add(this.StockAlert);
            this.Controls.Add(this.ItemInStock);
            this.Controls.Add(this.OrderTree);
            this.Controls.Add(this.LowStock);
            this.Controls.Add(this.CustomerOrder);
            this.Controls.Add(this.RobotStatus);
            this.Controls.Add(this.StockItem);
            this.Name = "ManagerNew";
            this.Text = "a";
            ((System.ComponentModel.ISupportInitialize)(this.ItemInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusRobot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StockItem;
        private System.Windows.Forms.TextBox RobotStatus;
        private System.Windows.Forms.TextBox CustomerOrder;
        private System.Windows.Forms.TextBox LowStock;
        private System.Windows.Forms.TreeView OrderTree;
        private System.Windows.Forms.DataGridView ItemInStock;
        private System.Windows.Forms.DataGridView StockAlert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn Restock;
        private System.Windows.Forms.DataGridView StatusRobot;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionY;
    }
}