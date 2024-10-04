namespace eShop
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
            this.labe_MainConnect = new System.Windows.Forms.Label();
            this.label_MainUsername = new System.Windows.Forms.Label();
            this.label_MainPassword = new System.Windows.Forms.Label();
            this.textBox_MainUsername = new System.Windows.Forms.TextBox();
            this.textBox_MainPassword = new System.Windows.Forms.TextBox();
            this.checkBox_MainShow = new System.Windows.Forms.CheckBox();
            this.button_MainLogin = new System.Windows.Forms.Button();
            this.button_MainSingIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labe_MainConnect
            // 
            this.labe_MainConnect.AutoSize = true;
            this.labe_MainConnect.Location = new System.Drawing.Point(229, 62);
            this.labe_MainConnect.Name = "labe_MainConnect";
            this.labe_MainConnect.Size = new System.Drawing.Size(132, 15);
            this.labe_MainConnect.TabIndex = 0;
            this.labe_MainConnect.Text = "Sign-in to your account";
            this.labe_MainConnect.Click += new System.EventHandler(this.labe_MainConnect_Click);
            // 
            // label_MainUsername
            // 
            this.label_MainUsername.AutoSize = true;
            this.label_MainUsername.Location = new System.Drawing.Point(239, 122);
            this.label_MainUsername.Name = "label_MainUsername";
            this.label_MainUsername.Size = new System.Drawing.Size(60, 15);
            this.label_MainUsername.TabIndex = 1;
            this.label_MainUsername.Text = "Username";
            this.label_MainUsername.Click += new System.EventHandler(this.label_MainUsername_Click);
            // 
            // label_MainPassword
            // 
            this.label_MainPassword.AutoSize = true;
            this.label_MainPassword.Location = new System.Drawing.Point(239, 175);
            this.label_MainPassword.Name = "label_MainPassword";
            this.label_MainPassword.Size = new System.Drawing.Size(57, 15);
            this.label_MainPassword.TabIndex = 2;
            this.label_MainPassword.Text = "Password";
            this.label_MainPassword.Click += new System.EventHandler(this.label_MainPassword_Click);
            // 
            // textBox_MainUsername
            // 
            this.textBox_MainUsername.Location = new System.Drawing.Point(239, 140);
            this.textBox_MainUsername.Name = "textBox_MainUsername";
            this.textBox_MainUsername.Size = new System.Drawing.Size(100, 23);
            this.textBox_MainUsername.TabIndex = 3;
            this.textBox_MainUsername.TextChanged += new System.EventHandler(this.textBox_MainUsername_TextChanged);
            // 
            // textBox_MainPassword
            // 
            this.textBox_MainPassword.Location = new System.Drawing.Point(239, 193);
            this.textBox_MainPassword.Name = "textBox_MainPassword";
            this.textBox_MainPassword.Size = new System.Drawing.Size(100, 23);
            this.textBox_MainPassword.TabIndex = 4;
            this.textBox_MainPassword.TextChanged += new System.EventHandler(this.textBox_MainPassword_TextChanged);
            // 
            // checkBox_MainShow
            // 
            this.checkBox_MainShow.AutoSize = true;
            this.checkBox_MainShow.Location = new System.Drawing.Point(239, 222);
            this.checkBox_MainShow.Name = "checkBox_MainShow";
            this.checkBox_MainShow.Size = new System.Drawing.Size(102, 19);
            this.checkBox_MainShow.TabIndex = 5;
            this.checkBox_MainShow.Text = "hide password";
            this.checkBox_MainShow.UseVisualStyleBackColor = true;
            this.checkBox_MainShow.CheckedChanged += new System.EventHandler(this.checkBox_MainShow_CheckedChanged);
            // 
            // button_MainLogin
            // 
            this.button_MainLogin.Location = new System.Drawing.Point(201, 268);
            this.button_MainLogin.Name = "button_MainLogin";
            this.button_MainLogin.Size = new System.Drawing.Size(59, 29);
            this.button_MainLogin.TabIndex = 6;
            this.button_MainLogin.Text = "Login";
            this.button_MainLogin.UseVisualStyleBackColor = true;
            this.button_MainLogin.Click += new System.EventHandler(this.button_MainLogin_Click);
            // 
            // button_MainSingIn
            // 
            this.button_MainSingIn.Location = new System.Drawing.Point(302, 268);
            this.button_MainSingIn.Name = "button_MainSingIn";
            this.button_MainSingIn.Size = new System.Drawing.Size(59, 29);
            this.button_MainSingIn.TabIndex = 7;
            this.button_MainSingIn.Text = "Sing Up";
            this.button_MainSingIn.UseVisualStyleBackColor = true;
            this.button_MainSingIn.Click += new System.EventHandler(this.button_MainSingIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_MainSingIn);
            this.Controls.Add(this.button_MainLogin);
            this.Controls.Add(this.checkBox_MainShow);
            this.Controls.Add(this.textBox_MainPassword);
            this.Controls.Add(this.textBox_MainUsername);
            this.Controls.Add(this.label_MainPassword);
            this.Controls.Add(this.label_MainUsername);
            this.Controls.Add(this.labe_MainConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labe_MainConnect;
        private Label label_MainUsername;
        private Label label_MainPassword;
        private TextBox textBox_MainUsername;
        private TextBox textBox_MainPassword;
        private CheckBox checkBox_MainShow;
        private Button button_MainLogin;
        private Button button_MainSingIn;
    }
}