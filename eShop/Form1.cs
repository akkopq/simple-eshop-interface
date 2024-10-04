namespace eShop
{
    public partial class Form1 : Form
    {
        UserList user;
        public Form1()
        {
            InitializeComponent();
            user = new UserList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labe_MainConnect_Click(object sender, EventArgs e)
        {

        }

        private void label_MainUsername_Click(object sender, EventArgs e)
        {

        }

        private void label_MainPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox_MainUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_MainPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_MainShow_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_MainShow.Checked)
            {
                textBox_MainPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBox_MainPassword.UseSystemPasswordChar = false;
            }
        }

        private void button_MainLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MainUsername.Text))
            {

                MessageBox.Show("Username can't be null");
                return;
            }

            if (string.IsNullOrEmpty(textBox_MainPassword.Text))
            {

                MessageBox.Show("Password can't be null");
                return;
            }

            user.LoadUser();
            User c = user.GetByUser(textBox_MainUsername.Text);
            if (c == null)
            {
                MessageBox.Show($"error");
                return;
            }

            User s = user.GetByPass(textBox_MainPassword.Text);
            if (s == null)
            {
                MessageBox.Show($"error");
                return;
            }

            if (c.Equals(s))
            {
                Form3 frm = new Form3();
                this.Visible = false;
                frm.Show();
            }
        }

        private void button_MainSingIn_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Visible = false;
        }
    }
}