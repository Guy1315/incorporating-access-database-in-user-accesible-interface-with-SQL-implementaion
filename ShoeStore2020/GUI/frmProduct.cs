using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoeStore2020.Model;
using ShoeStore2020.DB;
using ShoeStore2020.Utility;

namespace ShoeStore2020.GUI
{
    public partial class frmProduct : Form
    {
        private AddState state;
        private ProductsDB products;
        public frmProduct()
        {
            InitializeComponent();
            products = new ProductsDB();
           
            state = AddState.NAVIGATE;
            Populate(products.GetCurrentRow());
            SetButtonStates(true);
        }
        private void Clear()
        {
            foreach(Control c in Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Text = "";
                if (c is ComboBox)
                    (c as ComboBox).Text = "";
                if (c is DateTimePicker)
                    (c as DateTimePicker).Value = DateTime.Today;
            }
            //txtProductId.Text = "";
            //cbProductCategory.Text = "";
            //txtProductPrice.Text = "";
            //txtProductSize.Text = "";
            //cbProductBrand.Text = "";
            //cbProductType.Text= "";
            //txtSupplierId.Text = "";
            //txtShoeColor.Text = "";
        }
        //private void Clear (object sender)
        //{
        //    TextBox tb = (TextBox)sender;
        //    tb.Clear();
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'guyProjectShoesDataSet.suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.guyProjectShoesDataSet.suppliers);

        }
        //public void AddRow(IEntity obj)
        //{
        //    DataRow dr = Products.NewRow();
        //    obj.Populate(dr);
        //    table.Rows.Add(dr);
        //}

        private void Populate(Products product)
        {
            txtProductId.Text = product.ProductId.ToString();
            txtProductSize.Text = product.Size.ToString();
            txtProductPrice.Text = product.Price.ToString();
            cbSupplierId.Text = product.SupplierId.ToString();
            cbProductBrand.Text = product.Brand;
            cbProductType.Text = product.Type;
            cbProductCategory.Text = product.Category;
            cbShoeColor.Text = product.ShoeColor;
            textBox1.Text = product.AmountOfProducts.ToString();;
        }
        private bool UpdateObject(Products product)
        {
            bool ok = true;
            try
            {
                product.ProductId = Convert.ToInt32(txtProductId.Text);
                errorProvider1.SetError(txtProductId, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtProductId, ex.Message);
                ok = false;
            }
            try
            {
                product.Size = Convert.ToInt32(txtProductSize.Text);
                errorProvider1.SetError(txtProductSize, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtProductSize, ex.Message);
                ok = false;
            }
            try
            {
                product.Price = Convert.ToInt32(txtProductPrice.Text);
                errorProvider1.SetError(txtProductPrice, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtProductPrice, ex.Message);
                ok = false;
            }
            try
            {
                product.Brand = cbProductBrand.SelectedItem.ToString();
                errorProvider1.SetError(cbProductBrand, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cbProductBrand, ex.Message);
                ok = false;
            }
            try
            {
                product.Type = cbProductType.Text.ToString();
                errorProvider1.SetError(cbProductType, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cbProductType, ex.Message);
                ok = false;
            }
            try
            {
                product.Category = cbProductCategory.SelectedItem.ToString();
                errorProvider1.SetError(cbProductCategory, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cbProductCategory, ex.Message);
                ok = false;
            }
            try
            {
                product.ShoeColor = cbShoeColor.Text;
                errorProvider1.SetError(cbShoeColor, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cbShoeColor, ex.Message);
                ok = false;
            }
            try
            {
                product.AmountOfProducts = Convert.ToInt32(textBox1.Text);
                errorProvider1.SetError(textBox1, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox1, ex.Message);
                ok = false;
            }
            //try
            //{
            //int key = Convert.ToInt32(cbSupplierId.SelectedValue);
            //products.Find(key); //מביא קוד ספק
            product.SupplierId = Convert.ToInt32(cbSupplierId.SelectedValue);
                //errorProvider1.SetError(cbSupplierId, "");
            //}
            //catch (Exception ex)
            //{
            //    errorProvider1.SetError(cbSupplierId, ex.Message);
            //    ok = false;
            //}
            return ok;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonRight_Click(object sender, EventArgs e)
        {
            products.MoveNext();
            Populate(products.GetCurrentRow());
        }
        private void btnNewItem_Click(object sender, EventArgs e)
        {
            Clear();
            state = AddState.ADDNEW;
            SetButtonStates(false);
            txtProductId.Text = products.GetKey().ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetButtonStates(false);
            Populate(products.GetCurrentRow());
            SetButtonStates(true);
        }
        private void SetButtonStates(bool b)
        {
            buttonSave.Enabled =!b;
            buttonUpdate.Enabled = b;
            buttonLeft.Enabled = b;
            buttonRight.Enabled = b;
            buttonCancel.Enabled = !b;
            buttonNew.Enabled = b;
            cbProductBrand.Enabled = !b;
            cbProductCategory.Enabled = !b;
            txtProductId.Enabled = !b;
            txtProductPrice.Enabled = !b;
            txtProductSize.Enabled = !b;
            cbProductType.Enabled = !b;
            cbShoeColor.Enabled = !b;
            cbSupplierId.Enabled = !b;
            textBox1.Enabled = !b;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            if (UpdateObject(pro))
                if (state == AddState.ADDNEW)
                {
                    products.Add(pro);
                }
                else
                {
                    products.UpdateRow(pro);

                }
            SetButtonStates(true);
            state = AddState.NAVIGATE;
            products.Save();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            products.MovePrev();
            Populate(products.GetCurrentRow());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            state = AddState.ADDNEW;
            SetButtonStates(false);
            txtProductId.Text = products.GetKey().ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SetButtonStates(false);
            state = AddState.UPDATE;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SetButtonStates(false);
            Populate(products.GetCurrentRow());
            SetButtonStates(true);
        }



        private void txtProductType_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guyProjectShoesDataSet);

        }

        private void cbSupplierId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}