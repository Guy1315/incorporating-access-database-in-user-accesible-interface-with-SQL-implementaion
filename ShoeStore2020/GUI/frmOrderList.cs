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
    public partial class frmOrderList : Form
    {
        private OrdersDB orders;
        Orders order;
        private ProductsDB products;
        int key;
        public frmOrderList(int key)
        {
           
            InitializeComponent();
            this.key = key;
            orders = new OrdersDB();
            order = new Orders(key);
            products = new ProductsDB();
            label4.Text = key.ToString();
            label5.Text = order.OrderDate.ToString();
            label8.Text = order.ArrivalDate.ToString();
            label9.Text = order.SupplierId.ToString();
        }

        private void frmOrderList_Load(object sender, EventArgs e)
        {
            InitializeListView();
            string sql = "SELECT ordersdetails.productId, ordersdetails.orderId, ordersdetails.amount, products.Pprice, [Pprice]*[amount] AS Expr1 FROM products INNER JOIN ordersdetails ON products.[productId] = ordersdetails.[productId] WHERE (ordersdetails.orderId)=" + Convert.ToInt32(label4.Text);
            ;
            DAL d = DAL.GetInstance();
            //עדכון נתונים במסד הנתונים
            d.ExecuteNonQuery(sql);
            //OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet(sql);
            DataTable dtable;
            // Get the table from the data set
            dtable = DAL.GetInstance().GetDisplayTable("ordersdetails", sql);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
