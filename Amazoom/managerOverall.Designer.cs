
namespace Amazoom
{
    partial class managerOverall
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
            this.Stock = new System.Windows.Forms.Button();
            this.Alert = new System.Windows.Forms.Button();
            this.RobotStatus = new System.Windows.Forms.Button();
            this.OrderStatus = new System.Windows.Forms.Button();
            this.Manager_interface = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(465, 108);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(250, 100);
            this.Stock.TabIndex = 1;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            this.Stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // Alert
            // 
            this.Alert.Location = new System.Drawing.Point(50, 280);
            this.Alert.Name = "Alert";
            this.Alert.Size = new System.Drawing.Size(250, 100);
            this.Alert.TabIndex = 2;
            this.Alert.Text = "Alert";
            this.Alert.UseVisualStyleBackColor = true;
            this.Alert.Click += new System.EventHandler(this.Alert_Click);
            // 
            // RobotStatus
            // 
            this.RobotStatus.Location = new System.Drawing.Point(465, 280);
            this.RobotStatus.Name = "RobotStatus";
            this.RobotStatus.Size = new System.Drawing.Size(250, 100);
            this.RobotStatus.TabIndex = 3;
            this.RobotStatus.Text = "Status of Robot";
            this.RobotStatus.UseVisualStyleBackColor = true;
            this.RobotStatus.Click += new System.EventHandler(this.RobotStatus_Click);
            // 
            // OrderStatus
            // 
            this.OrderStatus.Location = new System.Drawing.Point(50, 108);
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.Size = new System.Drawing.Size(250, 100);
            this.OrderStatus.TabIndex = 4;
            this.OrderStatus.Text = "Status of orders";
            this.OrderStatus.UseVisualStyleBackColor = true;
            this.OrderStatus.Click += new System.EventHandler(this.OrderStatus_Click);
            // 
            // Manager_interface
            // 
            this.Manager_interface.BackColor = System.Drawing.SystemColors.Menu;
            this.Manager_interface.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Manager_interface.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manager_interface.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Manager_interface.Location = new System.Drawing.Point(243, 30);
            this.Manager_interface.Name = "Manager_interface";
            this.Manager_interface.Size = new System.Drawing.Size(309, 44);
            this.Manager_interface.TabIndex = 5;
            this.Manager_interface.Text = "Welcome Manager";
            // 
            // managerOverall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Manager_interface);
            this.Controls.Add(this.OrderStatus);
            this.Controls.Add(this.RobotStatus);
            this.Controls.Add(this.Alert);
            this.Controls.Add(this.Stock);
            this.Name = "managerOverall";
            this.Text = "managerOverall";
            this.Load += new System.EventHandler(this.managerOverall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Button Alert;
        private System.Windows.Forms.Button RobotStatus;
        private System.Windows.Forms.Button OrderStatus;
        private System.Windows.Forms.TextBox Manager_interface;
    }
}