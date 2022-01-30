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
    public partial class frmSupplier : Form
    {
        private AddState state;
        private SuppliersDB suppliers;
        public frmSupplier()
        {
            InitializeComponent();
            suppliers = new SuppliersDB();

            state = AddState.NAVIGATE;
            Populate(suppliers.GetCurrentRow());
            SetButtonStates(true);
        }
        private void Clear()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Text = "";
                if (c is ComboBox)
                    (c as ComboBox).Text = "";
                if (c is DateTimePicker)
                    (c as DateTimePicker).Value = DateTime.Today;
            }
        }
        private bool UpdateObject(Suppliers supplier)
        {
            bool ok = true;
            try
            {
                supplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
                errorProvider1.SetError(txtSupplierId, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSupplierId, ex.Message);
                ok = false;
            }
            try
            {
                supplier.SupplierName = txtSupplierName.Text;
                errorProvider1.SetError(txtSupplierName, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSupplierName, ex.Message);
                ok = false;
            }
            try
            {
                supplier.ContactNumber = Convert.ToInt32(txtContactNumber.Text);
                errorProvider1.SetError(txtContactNumber, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtContactNumber, ex.Message);
                ok = false;
            }
            try
            {
                supplier.ContactMail = txtContactMail.Text;
                errorProvider1.SetError(txtContactMail, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtContactMail, ex.Message);
                ok = false;
            }
            try
            {
                supplier.ContactName = txtContactName.Text;
                errorProvider1.SetError(txtContactName, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtContactName, ex.Message);
                ok = false;
            }
            return ok;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierId_Click(object sender, EventArgs e)
        {

        }
        private void SetButtonStates(bool b)
        {
            buttonSave.Enabled = !b;
            buttonUpdate.Enabled = b;
            buttonLeft.Enabled = b;
            buttonRight.Enabled = b;
            buttonCancel.Enabled = !b;
            buttonNew.Enabled = b;
            txtContactMail.Enabled = !b;
            txtContactName.Enabled = !b;
            txtContactNumber.Enabled = !b;
            txtSupplierName.Enabled = !b;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Clear();
            state = AddState.ADDNEW;
            SetButtonStates(false);
            txtSupplierId.Text = suppliers.GetKey().ToString();
        }
        private void Populate(Suppliers suppliers)
        {
            txtSupplierId.Text= suppliers.SupplierId.ToString();
            txtSupplierName.Text = suppliers.SupplierName.ToString();
            txtContactNumber.Text = suppliers.ContactNumber.ToString();
            txtContactName.Text = suppliers.ContactName.ToString();
            txtContactMail.Text = suppliers.SupplierId.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SetButtonStates(false);
            state = AddState.UPDATE;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SetButtonStates(false);
            Populate(suppliers.GetCurrentRow());
            SetButtonStates(true);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            suppliers.MovePrev();
            Populate(suppliers.GetCurrentRow());
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            suppliers.MoveNext();
            Populate(suppliers.GetCurrentRow());
        }
        Suppliers sup;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            sup = new Suppliers();
                if (UpdateObject(sup))
                    if (state == AddState.ADDNEW)
                    {
                        suppliers.Add(sup);
                    }
                    else
                    {
                        suppliers.UpdateRow(sup);

                    }
                SetButtonStates(true);
                state = AddState.NAVIGATE;
                suppliers.Save();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newOrder.orders' table. You can move, or remove it, as needed.
       
            // TODO: This line of code loads data into the 'guyDataSet1.products' table. You can move, or remove it, as needed.
  //          this.productsTableAdapter.Fill(this.guyDataSet1.products);
            // TODO: This line of code loads data into the 'guyDataSet1.orders_details' table. You can move, or remove it, as needed.
          //  this.orders_detailsTableAdapter.Fill(this.guyDataSet1.orders_details);
            // TODO: This line of code loads data into the 'guyDataSet1.orders' table. You can move, or remove it, as needed.
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearch f = new frmSearch();
            f.Show();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();

        }
        int codeorder;
        private void button3_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter1.Fill(this.newOrder.orders);
            codeorder =  newOrder.orders.Count + 1;
            newOrder.orders.AddordersRow(codeorder,Convert.ToInt32(txtSupplierId.Text),DateTime.Today,DateTime.Today.AddDays(7));
            this.ordersTableAdapter1.Update(this.newOrder.orders);
            int flag = 1;
            frmItemSale f = new frmItemSale(codeorder,flag, Convert.ToInt32(txtSupplierId.Text));
            f.Show();
           
        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
