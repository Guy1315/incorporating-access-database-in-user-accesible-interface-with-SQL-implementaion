using ShoeStore2020.DB;

namespace ShoeStore2020.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Products = new System.Windows.Forms.Button();
            this.Suppliers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NewSale = new System.Windows.Forms.Button();
            this.ordertoday = new ShoeStore2020.ordertoday();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new ShoeStore2020.ordertodayTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new ShoeStore2020.ordertodayTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.arrivalDateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.arrivalDateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guyProjectShoesDataSet = new ShoeStore2020.GuyProjectShoesDataSet();
            this.orders_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orders_detailsTableAdapter = new ShoeStore2020.GuyProjectShoesDataSetTableAdapters.orders_detailsTableAdapter();
            this.tableAdapterManager1 = new ShoeStore2020.GuyProjectShoesDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ShowOrders = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ordertoday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guyProjectShoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_detailsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.Black;
            this.Products.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Products.BackgroundImage")));
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Products.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.Color.Silver;
            this.Products.Location = new System.Drawing.Point(55, 130);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(162, 68);
            this.Products.TabIndex = 0;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = false;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Suppliers
            // 
            this.Suppliers.BackColor = System.Drawing.Color.Black;
            this.Suppliers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Suppliers.BackgroundImage")));
            this.Suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Suppliers.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suppliers.ForeColor = System.Drawing.Color.Silver;
            this.Suppliers.Location = new System.Drawing.Point(55, 219);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(162, 66);
            this.Suppliers.TabIndex = 1;
            this.Suppliers.Text = "Suppliers";
            this.Suppliers.UseVisualStyleBackColor = false;
            this.Suppliers.Click += new System.EventHandler(this.Suppliers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(209, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "The ShoeGuy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_NewSale
            // 
            this.btn_NewSale.BackColor = System.Drawing.Color.Black;
            this.btn_NewSale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_NewSale.BackgroundImage")));
            this.btn_NewSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewSale.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewSale.ForeColor = System.Drawing.Color.Silver;
            this.btn_NewSale.Location = new System.Drawing.Point(55, 312);
            this.btn_NewSale.Name = "btn_NewSale";
            this.btn_NewSale.Size = new System.Drawing.Size(162, 67);
            this.btn_NewSale.TabIndex = 3;
            this.btn_NewSale.Text = "New Sale";
            this.btn_NewSale.UseVisualStyleBackColor = false;
            this.btn_NewSale.Click += new System.EventHandler(this.btn_NewSale_Click);
            // 
            // ordertoday
            // 
            this.ordertoday.DataSetName = "ordertoday";
            this.ordertoday.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.ordertoday;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ShoeStore2020.ordertodayTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrivalDateToolStripLabel,
            this.arrivalDateToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(564, 7);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(206, 25);
            this.fillToolStrip.TabIndex = 5;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // arrivalDateToolStripLabel
            // 
            this.arrivalDateToolStripLabel.Name = "arrivalDateToolStripLabel";
            this.arrivalDateToolStripLabel.Size = new System.Drawing.Size(66, 22);
            this.arrivalDateToolStripLabel.Text = "arrivalDate:";
            // 
            // arrivalDateToolStripTextBox
            // 
            this.arrivalDateToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.arrivalDateToolStripTextBox.Name = "arrivalDateToolStripTextBox";
            this.arrivalDateToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.arrivalDateToolStripTextBox.Click += new System.EventHandler(this.arrivalDateToolStripTextBox_Click);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(6, 38);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(761, 257);
            this.ordersDataGridView.TabIndex = 6;
            this.ordersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellContentClick);
            this.ordersDataGridView.Click += new System.EventHandler(this.ordersDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "orderId";
            this.dataGridViewTextBoxColumn1.HeaderText = "orderId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "supplierId";
            this.dataGridViewTextBoxColumn2.HeaderText = "supplierId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "orderDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "orderDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "arrivalDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "arrivalDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "productId";
            this.dataGridViewTextBoxColumn5.HeaderText = "productId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn6.HeaderText = "amount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "orderStatus";
            this.dataGridViewTextBoxColumn7.HeaderText = "orderStatus";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // guyProjectShoesDataSet
            // 
            this.guyProjectShoesDataSet.DataSetName = "GuyProjectShoesDataSet";
            this.guyProjectShoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orders_detailsBindingSource
            // 
            this.orders_detailsBindingSource.DataMember = "orders details";
            this.orders_detailsBindingSource.DataSource = this.guyProjectShoesDataSet;
            // 
            // orders_detailsTableAdapter
            // 
            this.orders_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.orders_detailsTableAdapter = this.orders_detailsTableAdapter;
            this.tableAdapterManager1.ordersTableAdapter = null;
            this.tableAdapterManager1.productsTableAdapter = null;
            this.tableAdapterManager1.sales_detalesTableAdapter = null;
            this.tableAdapterManager1.salesTableAdapter = null;
            this.tableAdapterManager1.suppliersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ShoeStore2020.GuyProjectShoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.fillToolStrip);
            this.groupBox1.Controls.Add(this.ordersDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(242, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 308);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ShowOrders
            // 
            this.btn_ShowOrders.BackColor = System.Drawing.Color.Black;
            this.btn_ShowOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ShowOrders.BackgroundImage")));
            this.btn_ShowOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ShowOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_ShowOrders.ForeColor = System.Drawing.Color.Silver;
            this.btn_ShowOrders.Location = new System.Drawing.Point(63, 424);
            this.btn_ShowOrders.Name = "btn_ShowOrders";
            this.btn_ShowOrders.Size = new System.Drawing.Size(142, 44);
            this.btn_ShowOrders.TabIndex = 8;
            this.btn_ShowOrders.Text = "Show Orders";
            this.btn_ShowOrders.UseVisualStyleBackColor = false;
            this.btn_ShowOrders.Click += new System.EventHandler(this.btn_ShowOrders_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, -202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 178);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1052, 572);
            this.Controls.Add(this.btn_ShowOrders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NewSale);
            this.Controls.Add(this.Suppliers);
            this.Controls.Add(this.Products);
            this.DoubleBuffered = true;
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordertoday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guyProjectShoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_detailsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private SalesDB Sales;

        #endregion
        private System.Windows.Forms.Button Suppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NewSale;
        private ordertoday ordertoday;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ordertodayTableAdapters.ordersTableAdapter ordersTableAdapter;
        private ordertodayTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel arrivalDateToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox arrivalDateToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private GuyProjectShoesDataSet guyProjectShoesDataSet;
        private System.Windows.Forms.BindingSource orders_detailsBindingSource;
        private GuyProjectShoesDataSetTableAdapters.orders_detailsTableAdapter orders_detailsTableAdapter;
        private GuyProjectShoesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ShowOrders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Products;
    }
}