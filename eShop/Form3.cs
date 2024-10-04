using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShop
{
    public partial class Form3 : Form
    {
        ProductList productList;
        ProductList prodList;
        Cart cart;
        int i = 1;
        public int TotalValue { get; set; }
        public Form3()
        {
            InitializeComponent();
            ProductList Prod = new ProductList();
            UserList users = new UserList();
             Prod.Add(new Product(1, "salam sasesc", "salam cristim 250g", 49, "12/012/2022", 1, "03/08/2023"));
             Prod.Add(new Product(2, "branza feta", "bio", 89, "26/04/2016", 1, "25/12/2099"));
             Prod.Add(new Product(3, "pizza la cuptor", "capricioasa", 14, "17/01/2023", 1, "19/01/2023"));
             Prod.Add(new Product(4, "cabanos", "carnati sticks 80g", 7, "07/01/2023", 1, "25/12/2023"));
             Prod.Add(new Product(5, "bere", "5% concentratie alcool", 4, "17/12/2022", 2, "09/10/2024"));
             Prod.Add(new Product(6, "apa plata", "borsec 0.5L", 3, "4/9/2022", 2, "03/09/2183"));
             Prod.SaveProduct();
             Prod.SaveProduct();
             Prod.LoadProduct();
            productList = new ProductList();
            cart = new Cart();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            productList.LoadProduct();
            richTextBox_Catalogue.Clear();
            richTextBox_Catalogue.Text = productList.ToString();
        }

        private void label_Catalogue_Click(object sender, EventArgs e)
        {

        }

        private void label_Cart_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_Catalogue_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_Cart_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_ID_Click(object sender, EventArgs e)
        {

        }

        private void label_Category_Click(object sender, EventArgs e)
        {

        }

        private void label_Quantity_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Category_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_AddCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ID.Text))
            {
                MessageBox.Show("ID can't be null");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Quantity.Text))
            {
                MessageBox.Show("Quantity can't be null");
                return;
            }
            int idord = Int32.Parse(textBox_ID.Text);
            int qua = Int32.Parse(textBox_Quantity.Text);
            if (idord < 1)
            {
                MessageBox.Show($"Select ID");
                return;
            }
            if (qua < 1)
            {
                MessageBox.Show($"Select Quantity");
                return;
            }
            Order orders = new Order(idord, qua);
            int c = Int32.Parse(textBox_ID.Text);

            Product s = productList.SearchById(c);
            if (s != null)
            {
                cart.LoadFromDiskOrder(i);
                Order ord = cart.GetById(s.Id);
                if (ord == null)
                {
                    cart.Add(orders);
                    TotalValue = TotalValue + cart.Calc(c) * Int32.Parse(textBox_Quantity.Text);
                }
                else
                {
                    TotalValue = TotalValue - cart.Calc(ord.ProductId) * ord.Count;
                    orders.Count += ord.Count;
                    cart.Remove(ord);
                    cart.Add(orders);
                    TotalValue = TotalValue + cart.Calc(orders.ProductId) * orders.Count;
                }

                cart.SaveOnDiskOrder(i);
                richTextBox_Cart.Text = cart.ToString();


            }
            else
            {
                MessageBox.Show($"id {s} doesn't exist");
            }
            textBox_Price.Text = TotalValue.ToString();

        }

        private void button_Category_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Category.Text))
            {
                MessageBox.Show("Category can't be null");
                return;
            }
            if (textBox_Category.Text.ToLower() == "food")
            {
                prodList = new ProductList();
                prodList = productList.Combine(1);
            }
            else if (textBox_Category.Text.ToUpper() == "drinks")
            {
                prodList = new ProductList();
                prodList = prodList.Combine(2);
                richTextBox_Cart.Text = prodList.Combine(1).ToString();
            }
            else
            {
                MessageBox.Show("error");
                return;
            }

            richTextBox_Catalogue.Text = prodList.ToString();
        }

        private void button_Price_Click(object sender, EventArgs e)
        {
            productList.SortByPrice();
            richTextBox_Catalogue.Clear();
            richTextBox_Catalogue.Text = productList.ToString();
        }

        private void button_Date_Click(object sender, EventArgs e)
        {
            productList.SortByDate();
            richTextBox_Catalogue.Clear();
            richTextBox_Catalogue.Text = productList.ToString();
        }

        private void label_TotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            i++;
            TotalValue = 0;
            textBox_Price.Text = "0";
            richTextBox_Cart.Clear();
            cart = new Cart();

        }

        private void label_IDCart_Click(object sender, EventArgs e)
        {

        }

        private void textBox_IDCart_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            cart.LoadFromDiskOrder(i);
            int idord = Int32.Parse(textBox_IDCart.Text);
            Order ord = cart.GetById(idord);
            if (ord != null && ord.Count == 1)
            {

                TotalValue = TotalValue - cart.Calc(idord) * ord.Count;
                cart.Remove(ord);
                textBox_Price.Text = TotalValue.ToString();
            }
            else if (ord != null && ord.Count > 1)
            {
                TotalValue = TotalValue - cart.Calc(idord);
                int cnt = ord.Count - 1;
                cart.Remove(ord);
                ord = new Order(idord, cnt);
                cart.Add(ord);
                textBox_Price.Text = TotalValue.ToString();
            }
            else
            {
                MessageBox.Show($"id {idord} is not in yout cart");
            }
            cart.SaveOnDiskOrder(i);
            richTextBox_Cart.Text = cart.ToString();
        }
    }
}
