
namespace Project1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnDeleteFromCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxProducts
            // 
            this.lbxProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.ItemHeight = 28;
            this.lbxProducts.Location = new System.Drawing.Point(35, 104);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(193, 228);
            this.lbxProducts.TabIndex = 0;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoEllipsis = true;
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProducts.Location = new System.Drawing.Point(35, 61);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(0, 28);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToCart.Location = new System.Drawing.Point(234, 104);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(94, 71);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Ürün Ekle";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lbxCart
            // 
            this.lbxCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 28;
            this.lbxCart.Location = new System.Drawing.Point(349, 108);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(201, 200);
            this.lbxCart.TabIndex = 3;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCart.Location = new System.Drawing.Point(349, 63);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(65, 28);
            this.lblCart.TabIndex = 4;
            this.lblCart.Text = "label1";
            // 
            // btnDeleteFromCart
            // 
            this.btnDeleteFromCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteFromCart.Location = new System.Drawing.Point(556, 104);
            this.btnDeleteFromCart.Name = "btnDeleteFromCart";
            this.btnDeleteFromCart.Size = new System.Drawing.Size(94, 71);
            this.btnDeleteFromCart.TabIndex = 5;
            this.btnDeleteFromCart.Text = "Ürün Ekle";
            this.btnDeleteFromCart.UseVisualStyleBackColor = true;
            this.btnDeleteFromCart.Click += new System.EventHandler(this.btnDeleteFromCart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteFromCart);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lbxCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lbxProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnDeleteFromCart;
    }
}

