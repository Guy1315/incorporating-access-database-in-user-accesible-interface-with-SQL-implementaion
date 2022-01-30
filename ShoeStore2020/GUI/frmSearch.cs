using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStore2020.GUI
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guyProjectShoesDataSet);

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'guyDataSet1.suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter1.Fill(this.guyDataSet1.suppliers);
            // TODO: This line of code loads data into the 'guyProjectShoesDataSet.suppliers' table. You can move, or remove it, as needed.

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.suppliersTableAdapter1.FillBy(this.guyDataSet1.suppliers, textBox1.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.suppliersTableAdapter1.Fill(this.guyDataSet1.suppliers);
        }

        private void suppliersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
