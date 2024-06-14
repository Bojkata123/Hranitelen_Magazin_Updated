using Hranitelen_Magazin.Controller;
using Hranitelen_Magazin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hranitelen_Magazin
{
    public partial class HranitelenMagazin : Form
    {
        ProductController productController = new ProductController();
        ProductTypeController productTypeController = new ProductTypeController();
        public HranitelenMagazin()
        {
            InitializeComponent();
        }
        
        private void LoadRecord(Product product)
        {
            txtID.BackColor = Color.White;

            txtID.Text = product.Id.ToString();
            txtBrand.Text = product.Brand;
            txtPrice.Text = product.Price.ToString();
            txtDescription.Text = product.Description;
            txtExpirationDate.Text = product.ExpirationDate.ToString();

            cmbProductType.Text = product.ProductTypes.ProductTypeName;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<ProductType> allProductTypes = productTypeController.GetAllProductTypes();
            cmbProductType.DataSource = allProductTypes;
            cmbProductType.DisplayMember = "ProductTypeName";
            cmbProductType.ValueMember = "Id";
            SelectAll();

            lblID.BackColor = System.Drawing.Color.Transparent;
            lblBrand.BackColor = System.Drawing.Color.Transparent;
            lblDescription.BackColor = System.Drawing.Color.Transparent;
            lblPrice.BackColor = System.Drawing.Color.Transparent;
            lblExpirationDate.BackColor = System.Drawing.Color.Transparent;
            lblProductType.BackColor = System.Drawing.Color.Transparent;


        }
        private void ClearScreen()
        {
            //textBox1.BackColor = Color.White;
            txtBrand.Clear();
            txtDescription.Clear();
            txtExpirationDate.Clear();
            txtPrice.Clear();
            txtID.Clear();
            cmbProductType.Text = "";
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            // Ако няма намерен и визуализиран запис на екрана!!!
            if (string.IsNullOrEmpty(txtDescription.Text) || txtDescription.Text == "")
            {
                MessageBox.Show("Въведете данни!");
                txtDescription.Focus();
                return;
            }
            Product newProduct = new Product();
            newProduct.Brand = (txtBrand.Text);
            newProduct.Price = decimal.Parse(txtPrice.Text);
            newProduct.ExpirationDate = DateTime.Parse(txtExpirationDate.Text);
            newProduct.Description = (txtDescription.Text);
            newProduct.ProductTypeId = (int)cmbProductType.SelectedValue;


            productController.Create(newProduct);
            MessageBox.Show("Записът е успешно добавен!");

            SelectAll();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txtID.Text) || !txtID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за търсене!");
                txtID.BackColor = Color.Red;
                txtID.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txtID.Text);
            }
            // Ако няма намерен запис търсим по Id и визуализираме на екрана
            if (string.IsNullOrEmpty(txtBrand.Text))
            {
                Product findedProduct = productController.Get(findId);
                if (findedProduct == null)
                {
                    MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!");
                    txtID.BackColor = Color.Red;
                    txtID.Focus();
                    return;
                }
                LoadRecord(findedProduct);
            }
            else // Ако има намерен вече запис променяме по полетата
            {
                Product updatedProduct = new Product();
                updatedProduct.Brand = txtBrand.Text;
                updatedProduct.Description = (txtDescription.Text);
                updatedProduct.ExpirationDate = DateTime.Parse(txtExpirationDate.Text);
                updatedProduct.Price = decimal.Parse(txtPrice.Text);

                updatedProduct.ProductTypeId = (int)cmbProductType.SelectedValue;

                productController.Update(findId, updatedProduct);
            }
            SelectAll();
        }

        private void btnFIND_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txtID.Text) || !txtID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за търсене!");
                txtID.BackColor = Color.Cyan;
                txtID.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txtID.Text);
            }
            Product findedProduct = productController.Get(findId);
            if (findedProduct == null)
            {
                MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!");
            }
            else
            {
                LoadRecord(findedProduct);
            }
        }

        private void SelectAll()
        {
            List<Product> allProducts = productController.GetAll();
            listBox.Items.Clear();
            foreach (var item in allProducts)
            {
                listBox.Items.Add($"ID-[{item.Id}]," +
                    $" Product Brand-[{item.Brand}]," +
                    $" Price-[{item.Price}]," +
                    $" Expiration Date-[{item.ExpirationDate}]," +
                    $" Description-[{item.Description}]," +
                    $" ProductType-[{item.ProductTypes.ProductTypeName}]");
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txtID.Text) || !txtID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за търсене!");
                txtID.BackColor = Color.Red;
                txtID.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txtID.Text);
            }
            Product findedProduct = productController.Get(findId);
            if (findedProduct == null)
            {
                MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!");
                txtID.BackColor = Color.Red;
                txtID.Focus();
                return;
            }
            LoadRecord(findedProduct);

            DialogResult answer = MessageBox.Show("Наистина ли искате да изтриете запис No " + findId + " ?",
                "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                productController.Delete(findId);
            }

            SelectAll();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
