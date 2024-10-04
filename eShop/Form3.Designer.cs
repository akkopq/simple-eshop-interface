namespace eShop
{
    partial class Form3
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
            this.label_Cart = new System.Windows.Forms.Label();
            this.richTextBox_Catalogue = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Cart = new System.Windows.Forms.RichTextBox();
            this.label_Catalogue = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.label_IDCart = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Category = new System.Windows.Forms.TextBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_IDCart = new System.Windows.Forms.TextBox();
            this.button_AddCart = new System.Windows.Forms.Button();
            this.button_Category = new System.Windows.Forms.Button();
            this.button_Price = new System.Windows.Forms.Button();
            this.button_Date = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Cart
            // 
            this.label_Cart.AutoSize = true;
            this.label_Cart.Location = new System.Drawing.Point(705, 31);
            this.label_Cart.Name = "label_Cart";
            this.label_Cart.Size = new System.Drawing.Size(83, 15);
            this.label_Cart.TabIndex = 1;
            this.label_Cart.Text = "Shopping Cart";
            this.label_Cart.Click += new System.EventHandler(this.label_Cart_Click);
            // 
            // richTextBox_Catalogue
            // 
            this.richTextBox_Catalogue.Location = new System.Drawing.Point(12, 49);
            this.richTextBox_Catalogue.Name = "richTextBox_Catalogue";
            this.richTextBox_Catalogue.ReadOnly = true;
            this.richTextBox_Catalogue.Size = new System.Drawing.Size(357, 173);
            this.richTextBox_Catalogue.TabIndex = 2;
            this.richTextBox_Catalogue.Text = "";
            this.richTextBox_Catalogue.TextChanged += new System.EventHandler(this.richTextBox_Catalogue_TextChanged);
            // 
            // richTextBox_Cart
            // 
            this.richTextBox_Cart.Location = new System.Drawing.Point(431, 49);
            this.richTextBox_Cart.Name = "richTextBox_Cart";
            this.richTextBox_Cart.ReadOnly = true;
            this.richTextBox_Cart.Size = new System.Drawing.Size(357, 173);
            this.richTextBox_Cart.TabIndex = 3;
            this.richTextBox_Cart.Text = "";
            this.richTextBox_Cart.TextChanged += new System.EventHandler(this.richTextBox_Cart_TextChanged);
            // 
            // label_Catalogue
            // 
            this.label_Catalogue.AutoSize = true;
            this.label_Catalogue.Location = new System.Drawing.Point(12, 31);
            this.label_Catalogue.Name = "label_Catalogue";
            this.label_Catalogue.Size = new System.Drawing.Size(61, 15);
            this.label_Catalogue.TabIndex = 4;
            this.label_Catalogue.Text = "Catalogue";
            this.label_Catalogue.Click += new System.EventHandler(this.label_Catalogue_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(12, 255);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 15);
            this.label_ID.TabIndex = 5;
            this.label_ID.Text = "ID";
            this.label_ID.Click += new System.EventHandler(this.label_ID_Click);
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(102, 255);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(55, 15);
            this.label_Category.TabIndex = 6;
            this.label_Category.Text = "Category";
            this.label_Category.Click += new System.EventHandler(this.label_Category_Click);
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Location = new System.Drawing.Point(231, 255);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(53, 15);
            this.label_Quantity.TabIndex = 7;
            this.label_Quantity.Text = "Quantity";
            this.label_Quantity.Click += new System.EventHandler(this.label_Quantity_Click);
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.AutoSize = true;
            this.label_TotalPrice.Location = new System.Drawing.Point(453, 242);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(61, 15);
            this.label_TotalPrice.TabIndex = 8;
            this.label_TotalPrice.Text = "Total Price";
            this.label_TotalPrice.Click += new System.EventHandler(this.label_TotalPrice_Click);
            // 
            // label_IDCart
            // 
            this.label_IDCart.AutoSize = true;
            this.label_IDCart.Location = new System.Drawing.Point(529, 293);
            this.label_IDCart.Name = "label_IDCart";
            this.label_IDCart.Size = new System.Drawing.Size(18, 15);
            this.label_IDCart.TabIndex = 9;
            this.label_IDCart.Text = "ID";
            this.label_IDCart.Click += new System.EventHandler(this.label_IDCart_Click);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(12, 273);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(48, 23);
            this.textBox_ID.TabIndex = 10;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // textBox_Category
            // 
            this.textBox_Category.Location = new System.Drawing.Point(102, 273);
            this.textBox_Category.Name = "textBox_Category";
            this.textBox_Category.Size = new System.Drawing.Size(100, 23);
            this.textBox_Category.TabIndex = 11;
            this.textBox_Category.TextChanged += new System.EventHandler(this.textBox_Category_TextChanged);
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(231, 273);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(100, 23);
            this.textBox_Quantity.TabIndex = 12;
            this.textBox_Quantity.TextChanged += new System.EventHandler(this.textBox_Quantity_TextChanged);
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(553, 239);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(100, 23);
            this.textBox_Price.TabIndex = 13;
            this.textBox_Price.TextChanged += new System.EventHandler(this.textBox_Price_TextChanged);
            // 
            // textBox_IDCart
            // 
            this.textBox_IDCart.Location = new System.Drawing.Point(553, 290);
            this.textBox_IDCart.Name = "textBox_IDCart";
            this.textBox_IDCart.Size = new System.Drawing.Size(100, 23);
            this.textBox_IDCart.TabIndex = 14;
            this.textBox_IDCart.TextChanged += new System.EventHandler(this.textBox_IDCart_TextChanged);
            // 
            // button_AddCart
            // 
            this.button_AddCart.Location = new System.Drawing.Point(350, 272);
            this.button_AddCart.Name = "button_AddCart";
            this.button_AddCart.Size = new System.Drawing.Size(80, 23);
            this.button_AddCart.TabIndex = 15;
            this.button_AddCart.Text = "Add to Cart";
            this.button_AddCart.UseVisualStyleBackColor = true;
            this.button_AddCart.Click += new System.EventHandler(this.button_AddCart_Click);
            // 
            // button_Category
            // 
            this.button_Category.Location = new System.Drawing.Point(12, 345);
            this.button_Category.Name = "button_Category";
            this.button_Category.Size = new System.Drawing.Size(106, 23);
            this.button_Category.TabIndex = 16;
            this.button_Category.Text = "Sort by Category";
            this.button_Category.UseVisualStyleBackColor = true;
            this.button_Category.Click += new System.EventHandler(this.button_Category_Click);
            // 
            // button_Price
            // 
            this.button_Price.Location = new System.Drawing.Point(160, 345);
            this.button_Price.Name = "button_Price";
            this.button_Price.Size = new System.Drawing.Size(87, 23);
            this.button_Price.TabIndex = 17;
            this.button_Price.Text = "Sort by Price";
            this.button_Price.UseVisualStyleBackColor = true;
            this.button_Price.Click += new System.EventHandler(this.button_Price_Click);
            // 
            // button_Date
            // 
            this.button_Date.Location = new System.Drawing.Point(298, 345);
            this.button_Date.Name = "button_Date";
            this.button_Date.Size = new System.Drawing.Size(80, 23);
            this.button_Date.TabIndex = 18;
            this.button_Date.Text = "Sort by Date";
            this.button_Date.UseVisualStyleBackColor = true;
            this.button_Date.Click += new System.EventHandler(this.button_Date_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(705, 238);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(80, 23);
            this.button_Save.TabIndex = 19;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(696, 289);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(89, 23);
            this.button_Remove.TabIndex = 20;
            this.button_Remove.Text = "Remove Item";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Date);
            this.Controls.Add(this.button_Price);
            this.Controls.Add(this.button_Category);
            this.Controls.Add(this.button_AddCart);
            this.Controls.Add(this.textBox_IDCart);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.textBox_Category);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_IDCart);
            this.Controls.Add(this.label_TotalPrice);
            this.Controls.Add(this.label_Quantity);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_Catalogue);
            this.Controls.Add(this.richTextBox_Cart);
            this.Controls.Add(this.richTextBox_Catalogue);
            this.Controls.Add(this.label_Cart);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_Cart;
        private RichTextBox richTextBox_Catalogue;
        private RichTextBox richTextBox_Cart;
        private Label label_Catalogue;
        private Label label_ID;
        private Label label_Category;
        private Label label_Quantity;
        private Label label_TotalPrice;
        private Label label_IDCart;
        private TextBox textBox_ID;
        private TextBox textBox_Category;
        private TextBox textBox_Quantity;
        private TextBox textBox_Price;
        private TextBox textBox_IDCart;
        private Button button_AddCart;
        private Button button_Category;
        private Button button_Price;
        private Button button_Date;
        private Button button_Save;
        private Button button_Remove;
    }
}