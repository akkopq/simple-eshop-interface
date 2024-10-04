using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace eShop
{
    public partial class Form2 : Form
    {
        UserList user;
        public Form2()
        {
            InitializeComponent();
            user = new UserList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label_CreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void label_CreateUsername_Click(object sender, EventArgs e)
        {

        }

        private void label_CreatePassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox_CreateUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CreatePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_CreateShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CreateShow.Checked)
            {
                textBox_CreatePassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBox_CreatePassword.UseSystemPasswordChar = false;
            }
        }

        private void button_CreateSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_CreateUsername.Text))
            {

                MessageBox.Show("Username can't be null");
                return;
            }

            if (string.IsNullOrEmpty(textBox_CreatePassword.Text))
            {

                MessageBox.Show("Password can't be null");
                return;
            }

            User users = new User(textBox_CreateUsername.Text, textBox_CreatePassword.Text);
            user.LoadUser();
            user.Add(users);
            user.SaveUser();
            MessageBox.Show("Account successfully created!");
            this.Visible = false;
            Form1 c = new Form1();
            c.Show();
        }
    }
}
