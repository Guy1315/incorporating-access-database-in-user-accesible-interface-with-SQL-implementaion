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
using System.Data.OleDb;
using ShoeStore2020.Data;
using Microsoft.VisualBasic;

namespace ShoeStore2020.GUI
{
    public partial class frmItemSale : Form
    {
        private Form parent;
        private ProductsDB items;
        public Sales sale;
        public int key, flag, codesup;
        private OleDbConnection con;

        //came from sale
        public frmItemSale(Form f, int key)
        {
            InitializeComponent();
            this.key = key;
            button19.Visible = false;

        }
        //came from supplier - order
        public frmItemSale(int key, int flag, int codesup)
        {
                InitializeComponent();
            this.key = key;
            this.flag = flag;
            this.codesup = codesup;
            button2.Visible = false;

        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guyDataSet1);

        }

        private void frmItemSale_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'guyDataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.guyDataSet1.products);

        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == 1)//came from supplierorder
            {
                int rowindex = productsDataGridView.CurrentCell.RowIndex;
                int id = Convert.ToInt32(productsDataGridView.Rows[rowindex].Cells[0].Value);//קוד מוצר
                items = new ProductsDB();
                items.Find(id);
                string myValue = Interaction.InputBox("  הכנס כמות רצויה אך קטנה מ- " + (items.GetCurrentRow().AmountOfProducts).ToString(), "Input Box", "הכנס כמות רצויה", 100, 100);
                if (Convert.ToInt32(myValue) <= (items.GetCurrentRow().AmountOfProducts))
                {
                    string processing = "processing";
                    string SQLadd = "INSERT INTO [ordersdetails] ( orderId, productId, amount, orderStatus) VALUES(" + key + "," + items.GetCurrentRow().ProductId + "," + Convert.ToInt32(myValue) + ",'" + processing + "')";
                    string path = System.IO.Directory.GetCurrentDirectory();
                    int x = path.IndexOf("\\bin");
                    path = path.Substring(0, x) + "\\bin\\Debug\\GuyProjectShoes.accdb";
                    string myConnectionStr = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Persist Security Info=True");
                    con = new OleDbConnection(myConnectionStr);
                    con.Open();
                    OleDbCommand SQLCommand = new OleDbCommand();
                    SQLCommand.CommandText = SQLadd;
                    SQLCommand.Connection = con;
                    int response1 = -1;
                    //עדכון נתונים במסד הנתונים
                    response1 = SQLCommand.ExecuteNonQuery();
                    if (response1 >= 1)
                        MessageBox.Show("נכנס להזמנה", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // *** Update Amount ***
                    String SQLupdate = "UPDATE products SET amountOfProducts = " + (items.GetCurrentRow().AmountOfProducts - Convert.ToInt32(myValue)) + " Where productId = " + id;

                    OleDbCommand SQLCommand2 = new OleDbCommand();
                    SQLCommand2.CommandText = SQLupdate;
                    SQLCommand2.Connection = con;



                    // Update Data

                    SQLCommand2.ExecuteNonQuery();



                    MessageBox.Show("Change Amount", "Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }
                else
                {
                    MessageBox.Show((items.GetCurrentRow().AmountOfProducts).ToString() + "  והכמות הקיימת היא רק " + myValue + " הכנסת ");
                }
            }
            else
            {
                int rowindex = productsDataGridView.CurrentCell.RowIndex;
                int id = Convert.ToInt32(productsDataGridView.Rows[rowindex].Cells[0].Value);//קוד מוצר
                items = new ProductsDB();
                items.Find(id);
                string myValue = Interaction.InputBox("  הכנס כמות רצויה אך קטנה מ- " + (items.GetCurrentRow().AmountOfProducts).ToString(), "Input Box", "הכנס כמות רצויה", 100, 100);
                if (Convert.ToInt32(myValue) <= (items.GetCurrentRow().AmountOfProducts))
                {
                    string SQLadd = "INSERT INTO salesdetails ( productId, saleId, amount) VALUES(" + items.GetCurrentRow().ProductId + "," + key + "," + Convert.ToInt32(myValue) + ")";
                    string path = System.IO.Directory.GetCurrentDirectory();
                    int x = path.IndexOf("\\bin");
                    path = path.Substring(0, x) + "\\bin\\Debug\\GuyProjectShoes.accdb";
                    string myConnectionStr = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Persist Security Info=True");
                    con = new OleDbConnection(myConnectionStr);
                    con.Open();
                    OleDbCommand SQLCommand = new OleDbCommand();
                    SQLCommand.CommandText = SQLadd;
                    SQLCommand.Connection = con;
                    int response1 = -1;
                    //עדכון נתונים במסד הנתונים
                    response1 = SQLCommand.ExecuteNonQuery();
                    if (response1 >= 1)
                        MessageBox.Show("נכנס למכירה", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // *** Update Amount ***
                    String SQLupdate = "UPDATE products SET amountOfProducts = " + (items.GetCurrentRow().AmountOfProducts - Convert.ToInt32(myValue)) + " Where productId = " + id;

                    OleDbCommand SQLCommand2 = new OleDbCommand();
                    SQLCommand2.CommandText = SQLupdate;
                    SQLCommand2.Connection = con;



                    // Update Data

                    SQLCommand2.ExecuteNonQuery();



                    MessageBox.Show("Change Amount", "Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }
                else
                {
                    MessageBox.Show((items.GetCurrentRow().AmountOfProducts).ToString() + "  והכמות הקיימת היא רק " + myValue + " הכנסת ");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy(this.guyDataSet1.products, "nike");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy1(this.guyDataSet1.products, "red");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOrders f = new frmOrders(key);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy(this.guyDataSet1.products, "addidas");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy(this.guyDataSet1.products, "new balance");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy1(this.guyDataSet1.products, "black");
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy1(this.guyDataSet1.products, "blue");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy1(this.guyDataSet1.products, "pink");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy3(this.guyDataSet1.products, "men");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy3(this.guyDataSet1.products, "women");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy4(this.guyDataSet1.products, "sport");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy4(this.guyDataSet1.products, "elegant");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy4(this.guyDataSet1.products, "basketball");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy4(this.guyDataSet1.products, "soccer");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillBy4(this.guyDataSet1.products, "hiking");
        }

        private void productsDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (flag == 1)//came from supplierorder
            {
                int rowindex = productsDataGridView.CurrentCell.RowIndex;
                int id = Convert.ToInt32(productsDataGridView.Rows[rowindex].Cells[0].Value);//קוד מוצר
                items = new ProductsDB();
                items.Find(id);
                string myValue = Interaction.InputBox("  הכנס כמות רצויה אך קטנה מ- " + (items.GetCurrentRow().AmountOfProducts).ToString(), "Input Box", "הכנס כמות רצויה", 100, 100);
                if (Convert.ToInt32(myValue) <= (items.GetCurrentRow().AmountOfProducts))
                {
                    string processing = "processing";
                    string SQLadd = "INSERT INTO [ordersdetails] ( orderId, productId, amount, orderStatus) VALUES(" + key + "," + items.GetCurrentRow().ProductId + "," + Convert.ToInt32(myValue) + ",'" + processing + "')";
                    string path = System.IO.Directory.GetCurrentDirectory();
                    int x = path.IndexOf("\\bin");
                    path = path.Substring(0, x) + "\\bin\\Debug\\GuyProjectShoes.accdb";
                    string myConnectionStr = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Persist Security Info=True");
                    con = new OleDbConnection(myConnectionStr);
                    con.Open();
                    OleDbCommand SQLCommand = new OleDbCommand();
                    SQLCommand.CommandText = SQLadd;
                    SQLCommand.Connection = con;
                    int response1 = -1;
                    //עדכון נתונים במסד הנתונים
                    response1 = SQLCommand.ExecuteNonQuery();
                    if (response1 >= 1)
                        MessageBox.Show("נכנס להזמנה", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // *** Update Amount ***
                    String SQLupdate = "UPDATE products SET amountOfProducts = " + (items.GetCurrentRow().AmountOfProducts - Convert.ToInt32(myValue)) + " Where productId = " + id;

                    OleDbCommand SQLCommand2 = new OleDbCommand();
                    SQLCommand2.CommandText = SQLupdate;
                    SQLCommand2.Connection = con;



                    // Update Data

                    SQLCommand2.ExecuteNonQuery();



                    MessageBox.Show("Change Amount", "Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }
                else
                {
                    MessageBox.Show((items.GetCurrentRow().AmountOfProducts).ToString() + "  והכמות הקיימת היא רק " + myValue + " הכנסת ");
                }
            }
            else
            {
                int rowindex = productsDataGridView.CurrentCell.RowIndex;
                int id = Convert.ToInt32(productsDataGridView.Rows[rowindex].Cells[0].Value);//קוד מוצר
                items = new ProductsDB();
                items.Find(id);
                string myValue = Interaction.InputBox("  הכנס כמות רצויה אך קטנה מ- " + (items.GetCurrentRow().AmountOfProducts).ToString(), "Input Box", "הכנס כמות רצויה", 100, 100);
                if (Convert.ToInt32(myValue) <= (items.GetCurrentRow().AmountOfProducts))
                {
                    string SQLadd = "INSERT INTO salesdetails ( productId, saleId, amount) VALUES(" + items.GetCurrentRow().ProductId + "," + key + "," + Convert.ToInt32(myValue) + ")";
                    string path = System.IO.Directory.GetCurrentDirectory();
                    int x = path.IndexOf("\\bin");
                    path = path.Substring(0, x) + "\\bin\\Debug\\GuyProjectShoes.accdb";
                    string myConnectionStr = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Persist Security Info=True");
                    con = new OleDbConnection(myConnectionStr);
                    con.Open();
                    OleDbCommand SQLCommand = new OleDbCommand();
                    SQLCommand.CommandText = SQLadd;
                    SQLCommand.Connection = con;
                    int response1 = -1;
                    //עדכון נתונים במסד הנתונים
                    response1 = SQLCommand.ExecuteNonQuery();
                    if (response1 >= 1)
                        MessageBox.Show("נכנס למכירה", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // *** Update Amount ***
                    String SQLupdate = "UPDATE products SET amountOfProducts = " + (items.GetCurrentRow().AmountOfProducts - Convert.ToInt32(myValue)) + " Where productId = " + id;

                    OleDbCommand SQLCommand2 = new OleDbCommand();
                    SQLCommand2.CommandText = SQLupdate;
                    SQLCommand2.Connection = con;



                    // Update Data

                    SQLCommand2.ExecuteNonQuery();



                    MessageBox.Show("Change Amount", "Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }
                else
                {
                    MessageBox.Show((items.GetCurrentRow().AmountOfProducts).ToString() + "  והכמות הקיימת היא רק " + myValue + " הכנסת ");
                }
            }

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            frmOrderList f = new frmOrderList(key);
            f.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            frmOrders f = new frmOrders(key);
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
