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
using ShoeStore2020.Data;
using System.Data.OleDb;

namespace ShoeStore2020.GUI
{
    public partial class frmOrders : Form
    {
        private AddState state;
        private SalesDB sales;
        private ProductsDB products;
        private Sales sale;
        private int key;
        public frmOrders(int key)
        {
            InitializeComponent();
            this.key = key;
            sales = new SalesDB();
            products = new ProductsDB();
            sale = new Sales(key);
            state = AddState.UPDATE;
            sale.DateSale = DateTime.Now;;
            label4.Text = key.ToString();
            label5.Text = sale.DateSale.ToString();
        }
        private void InitializeListView()
        {
            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
// Sort the items in the list in ascending order.
listView1.Sorting = SortOrder.Ascending;
            // Attach Subitems to the ListView
            listView1.Columns.Add("מוצר", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("כמות", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("מחיר", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("סהכ", 100, HorizontalAlignment.Left);
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            InitializeListView();
            string sql = "SELECT salesdetails.productId, salesdetails.saleId, salesdetails.amount, products.Pprice, [Pprice]*[amount] AS Expr1 FROM products INNER JOIN salesdetails ON products.[productId] = salesdetails.[productId] WHERE (salesdetails.saleId)=" + Convert.ToInt32(label4.Text);
;
            DAL d = DAL.GetInstance();
            //עדכון נתונים במסד הנתונים
            d.ExecuteNonQuery(sql);
            //OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet(sql);
            DataTable dtable;
            // Get the table from the data set
            dtable = DAL.GetInstance().GetDisplayTable("salesdetails", sql);
            // Clear the ListView control
            listView1.Items.Clear();
            // Display items in the ListView control
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];
                // Only row that have not been deleted
                if (drow.RowState != DataRowState.Deleted)
                {
                    // Define the list items
                    ListViewItem lvi = new ListViewItem(drow["productId"].ToString());
                    lvi.SubItems.Add(drow["amount"].ToString());
                    lvi.SubItems.Add(drow["Pprice"].ToString());
                    lvi.SubItems.Add(drow["Expr1"].ToString());

                    // Add the list items to the ListView
                    listView1.Items.Add(lvi);
                    Lpay.Text = ((Convert.ToInt32(Lpay.Text)) + (Convert.ToInt32(drow["Expr1"]))).ToString();
                }
            }

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lpay_Click(object sender, EventArgs e)
        {

        }
    }
}
