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
    public partial class frmMain : Form
    {
        private AddState state;
        private Sales sale;
        private ProductsDB products;
        public frmMain()
        {
            InitializeComponent();
            state = AddState.NAVIGATE;
            arrivalDateToolStripTextBox.Text = DateTime.Today.ToShortDateString();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            frmProduct f = new frmProduct();
            f.Show();
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            frmSupplier f = new frmSupplier();
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'guyProjectShoesDataSet.orders_details' table. You can move, or remove it, as needed.
   

        }

        private void btn_NewSale_Click(object sender, EventArgs e)
        {
            Sales = new SalesDB();
            ProductsDB products = new ProductsDB();
            int key = Sales.GetKey();
            state = AddState.ADDNEW;
            Sales sale = new Sales(key);//מכירה חדשה
            sale.SaleId = Convert.ToInt32(key);
            sale.DateSale = DateTime.Now;
            //הכנסת קוד מכירה,תאריך וקוד לקוח לאובייקט מכירה
            Sales.Add(sale);
            Sales.Save();//שמירה מכירה חדשה במסד

            frmItemSale f = new frmItemSale(this, key);
            f.Show();//מעבר לטופס של כל המוצרים
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.Fill(this.ordertoday.orders, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(arrivalDateToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = ordersDataGridView.CurrentCell.RowIndex;
            int codeorder = Convert.ToInt32(ordersDataGridView.Rows[rowindex].Cells[0].Value);
            int codeitem = Convert.ToInt32(ordersDataGridView.Rows[rowindex].Cells[4].Value);//קוד מוצר
            int amount = Convert.ToInt32(ordersDataGridView.Rows[rowindex].Cells[5].Value);
            //update Products;
            ProductsDB products = new ProductsDB();
            Products item = new Products();
            products.Find(codeitem);
            item.AmountOfProducts = item.AmountOfProducts + amount;
            products.UpdateRow(item);
            products.Save();
            //update processing;
            this.orders_detailsTableAdapter.Fill(this.guyProjectShoesDataSet.orders_details);
            guyProjectShoesDataSet.Tables[0].Rows[0]["orderStatus"] = "arrived";

            orders_detailsTableAdapter.Update(guyProjectShoesDataSet.orders_details);

        }

        private void ordersDataGridView_Click(object sender, EventArgs e)
        {
            //int rowindex = ordersDataGridView.CurrentCell.RowIndex;
            //int codeorder = Convert.ToInt32(ordersDataGridView.Rows[rowindex].Cells[0].Value);
            //int codeitem = Convert.ToInt32(ordersDataGridView.Rows[rowindex].Cells[4].Value);//קוד מוצר
            //int amount = Convert.ToInt32(ordersDataGridView.Rows[rowindex].Cells[5].Value);
            ////update items
            //ProductsDB items = new ProductsDB();
            //Products item = new Products();
            //items.Find(codeitem);
            //item.AmountOfProducts = item.AmountOfProducts + amount;
            //items.UpdateRow(item);
            //items.Save();
            ////update processing
            //this.orders_detailsTableAdapter.Fill(this.guyProjectShoesDataSet.orders_details);
            //guyProjectShoesDataSet.Tables[0].Rows[0]["orderStatus"] = "arrived";

            //orders_detailsTableAdapter.Update(guyProjectShoesDataSet.orders_details);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_ShowOrders_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void arrivalDateToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
