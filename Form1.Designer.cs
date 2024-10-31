namespace QuanLySanPham
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.btnaddToCart = new System.Windows.Forms.Button();
            this.btnremoveFromCart = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.totalvaluelbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.totalvaluelbl);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.btnremoveFromCart);
            this.panel1.Controls.Add(this.btnaddToCart);
            this.panel1.Controls.Add(this.cartListBox);
            this.panel1.Controls.Add(this.productListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 453);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sản phẩm";
            // 
            // productListBox
            // 
            this.productListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 18;
            this.productListBox.Location = new System.Drawing.Point(12, 63);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(455, 146);
            this.productListBox.TabIndex = 1;
            // 
            // cartListBox
            // 
            this.cartListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 18;
            this.cartListBox.Location = new System.Drawing.Point(12, 234);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(455, 110);
            this.cartListBox.TabIndex = 2;
            // 
            // btnaddToCart
            // 
            this.btnaddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddToCart.Location = new System.Drawing.Point(536, 63);
            this.btnaddToCart.Name = "btnaddToCart";
            this.btnaddToCart.Size = new System.Drawing.Size(107, 35);
            this.btnaddToCart.TabIndex = 3;
            this.btnaddToCart.Text = "Thêm";
            this.btnaddToCart.UseVisualStyleBackColor = true;
            this.btnaddToCart.Click += new System.EventHandler(this.btnaddToCart_Click);
            // 
            // btnremoveFromCart
            // 
            this.btnremoveFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveFromCart.Location = new System.Drawing.Point(536, 129);
            this.btnremoveFromCart.Name = "btnremoveFromCart";
            this.btnremoveFromCart.Size = new System.Drawing.Size(107, 33);
            this.btnremoveFromCart.TabIndex = 4;
            this.btnremoveFromCart.Text = "Xóa";
            this.btnremoveFromCart.UseVisualStyleBackColor = true;
            this.btnremoveFromCart.Click += new System.EventHandler(this.btnremoveFromCart_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.AutoSize = true;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(536, 189);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(107, 34);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // totalvaluelbl
            // 
            this.totalvaluelbl.AutoSize = true;
            this.totalvaluelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalvaluelbl.Location = new System.Drawing.Point(21, 366);
            this.totalvaluelbl.Name = "totalvaluelbl";
            this.totalvaluelbl.Size = new System.Drawing.Size(0, 16);
            this.totalvaluelbl.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(536, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 417);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalvaluelbl;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnremoveFromCart;
        private System.Windows.Forms.Button btnaddToCart;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

