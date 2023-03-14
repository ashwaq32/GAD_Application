
namespace Motor_Spa_Wform
{
    partial class Home_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_OrderDetails = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_CustomerRegistration = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_Admin);
            this.panel1.Controls.Add(this.btn_OrderDetails);
            this.panel1.Controls.Add(this.btn_Order);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_CustomerRegistration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 91);
            this.panel1.TabIndex = 0;
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.Maroon;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Location = new System.Drawing.Point(803, 0);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(205, 91);
            this.btn_Admin.TabIndex = 3;
            this.btn_Admin.Text = "Admin";
            this.btn_Admin.UseVisualStyleBackColor = false;
            // 
            // btn_OrderDetails
            // 
            this.btn_OrderDetails.BackColor = System.Drawing.Color.Maroon;
            this.btn_OrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrderDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OrderDetails.ForeColor = System.Drawing.Color.White;
            this.btn_OrderDetails.Location = new System.Drawing.Point(601, 0);
            this.btn_OrderDetails.Name = "btn_OrderDetails";
            this.btn_OrderDetails.Size = new System.Drawing.Size(205, 91);
            this.btn_OrderDetails.TabIndex = 2;
            this.btn_OrderDetails.Text = "Order Details";
            this.btn_OrderDetails.UseVisualStyleBackColor = false;
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.Color.Maroon;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Order.ForeColor = System.Drawing.Color.White;
            this.btn_Order.Location = new System.Drawing.Point(399, 0);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(205, 91);
            this.btn_Order.TabIndex = 2;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(200, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 91);
            this.button2.TabIndex = 1;
            this.button2.Text = "Customer Details";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_CustomerRegistration
            // 
            this.btn_CustomerRegistration.BackColor = System.Drawing.Color.Maroon;
            this.btn_CustomerRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CustomerRegistration.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CustomerRegistration.ForeColor = System.Drawing.Color.White;
            this.btn_CustomerRegistration.Location = new System.Drawing.Point(0, 0);
            this.btn_CustomerRegistration.Name = "btn_CustomerRegistration";
            this.btn_CustomerRegistration.Size = new System.Drawing.Size(205, 91);
            this.btn_CustomerRegistration.TabIndex = 0;
            this.btn_CustomerRegistration.Text = "Customer Registration";
            this.btn_CustomerRegistration.UseVisualStyleBackColor = false;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Motor_Spa_Wform.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 703);
            this.Controls.Add(this.panel1);
            this.Name = "Home_Form";
            this.Text = "Home_Form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_OrderDetails;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_CustomerRegistration;
        private System.Windows.Forms.Button btn_Admin;
    }
}