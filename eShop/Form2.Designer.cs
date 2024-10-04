namespace eShop
{
    partial class Form2
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
            this.label_CreateAccount = new System.Windows.Forms.Label();
            this.label_CreateUsername = new System.Windows.Forms.Label();
            this.textBox_CreateUsername = new System.Windows.Forms.TextBox();
            this.label_CreatePassword = new System.Windows.Forms.Label();
            this.textBox_CreatePassword = new System.Windows.Forms.TextBox();
            this.checkBox_CreateShow = new System.Windows.Forms.CheckBox();
            this.button_CreateSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_CreateAccount
            // 
            this.label_CreateAccount.AutoSize = true;
            this.label_CreateAccount.Location = new System.Drawing.Point(261, 54);
            this.label_CreateAccount.Name = "label_CreateAccount";
            this.label_CreateAccount.Size = new System.Drawing.Size(89, 15);
            this.label_CreateAccount.TabIndex = 0;
            this.label_CreateAccount.Text = "Create Account";
            this.label_CreateAccount.Click += new System.EventHandler(this.label_CreateAccount_Click);
            // 
            // label_CreateUsername
            // 
            this.label_CreateUsername.AutoSize = true;
            this.label_CreateUsername.Location = new System.Drawing.Point(250, 103);
            this.label_CreateUsername.Name = "label_CreateUsername";
            this.label_CreateUsername.Size = new System.Drawing.Size(60, 15);
            this.label_CreateUsername.TabIndex = 1;
            this.label_CreateUsername.Text = "Username";
            this.label_CreateUsername.Click += new System.EventHandler(this.label_CreateUsername_Click);
            // 
            // textBox_CreateUsername
            // 
            this.textBox_CreateUsername.Location = new System.Drawing.Point(250, 121);
            this.textBox_CreateUsername.Name = "textBox_CreateUsername";
            this.textBox_CreateUsername.Size = new System.Drawing.Size(100, 23);
            this.textBox_CreateUsername.TabIndex = 2;
            this.textBox_CreateUsername.TextChanged += new System.EventHandler(this.textBox_CreateUsername_TextChanged);
            // 
            // label_CreatePassword
            // 
            this.label_CreatePassword.AutoSize = true;
            this.label_CreatePassword.Location = new System.Drawing.Point(250, 157);
            this.label_CreatePassword.Name = "label_CreatePassword";
            this.label_CreatePassword.Size = new System.Drawing.Size(57, 15);
            this.label_CreatePassword.TabIndex = 3;
            this.label_CreatePassword.Text = "Password";
            this.label_CreatePassword.Click += new System.EventHandler(this.label_CreatePassword_Click);
            // 
            // textBox_CreatePassword
            // 
            this.textBox_CreatePassword.Location = new System.Drawing.Point(250, 175);
            this.textBox_CreatePassword.Name = "textBox_CreatePassword";
            this.textBox_CreatePassword.Size = new System.Drawing.Size(100, 23);
            this.textBox_CreatePassword.TabIndex = 4;
            this.textBox_CreatePassword.TextChanged += new System.EventHandler(this.textBox_CreatePassword_TextChanged);
            // 
            // checkBox_CreateShow
            // 
            this.checkBox_CreateShow.AutoSize = true;
            this.checkBox_CreateShow.Location = new System.Drawing.Point(250, 204);
            this.checkBox_CreateShow.Name = "checkBox_CreateShow";
            this.checkBox_CreateShow.Size = new System.Drawing.Size(102, 19);
            this.checkBox_CreateShow.TabIndex = 5;
            this.checkBox_CreateShow.Text = "hide password";
            this.checkBox_CreateShow.UseVisualStyleBackColor = true;
            this.checkBox_CreateShow.CheckedChanged += new System.EventHandler(this.checkBox_CreateShow_CheckedChanged);
            // 
            // button_CreateSignIn
            // 
            this.button_CreateSignIn.Location = new System.Drawing.Point(250, 245);
            this.button_CreateSignIn.Name = "button_CreateSignIn";
            this.button_CreateSignIn.Size = new System.Drawing.Size(100, 43);
            this.button_CreateSignIn.TabIndex = 6;
            this.button_CreateSignIn.Text = "Sign Up";
            this.button_CreateSignIn.UseVisualStyleBackColor = true;
            this.button_CreateSignIn.Click += new System.EventHandler(this.button_CreateSignIn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_CreateSignIn);
            this.Controls.Add(this.checkBox_CreateShow);
            this.Controls.Add(this.textBox_CreatePassword);
            this.Controls.Add(this.label_CreatePassword);
            this.Controls.Add(this.textBox_CreateUsername);
            this.Controls.Add(this.label_CreateUsername);
            this.Controls.Add(this.label_CreateAccount);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_CreateAccount;
        private Label label_CreateUsername;
        private TextBox textBox_CreateUsername;
        private Label label_CreatePassword;
        private TextBox textBox_CreatePassword;
        private CheckBox checkBox_CreateShow;
        private Button button_CreateSignIn;
    }
}