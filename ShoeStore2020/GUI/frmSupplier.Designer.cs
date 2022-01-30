namespace ShoeStore2020.GUI
{
    partial class frmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.supplierId = new System.Windows.Forms.Label();
            this.supplierName = new System.Windows.Forms.Label();
            this.contactName = new System.Windows.Forms.Label();
            this.contactMail = new System.Windows.Forms.Label();
            this.contactNumber = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtContactMail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new ShoeStore2020.GuyDataSet1TableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new ShoeStore2020.GuyDataSet1TableAdapters.TableAdapterManager();
            this.orders_detailsTableAdapter = new ShoeStore2020.GuyDataSet1TableAdapters.orders_detailsTableAdapter();
            this.orders_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newOrder = new ShoeStore2020.newOrder();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new ShoeStore2020.newOrderTableAdapters.ordersTableAdapter();
            this.tableAdapterManager1 = new ShoeStore2020.newOrderTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Location = new System.Drawing.Point(174, 154);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierId.TabIndex = 0;
            this.txtSupplierId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // supplierId
            // 
            this.supplierId.AutoSize = true;
            this.supplierId.BackColor = System.Drawing.SystemColors.HighlightText;
            this.supplierId.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierId.Location = new System.Drawing.Point(60, 154);
            this.supplierId.Name = "supplierId";
            this.supplierId.Size = new System.Drawing.Size(99, 23);
            this.supplierId.TabIndex = 1;
            this.supplierId.Text = "Supplier ID";
            this.supplierId.Click += new System.EventHandler(this.supplierId_Click);
            // 
            // supplierName
            // 
            this.supplierName.AutoSize = true;
            this.supplierName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.supplierName.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierName.Location = new System.Drawing.Point(34, 188);
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(125, 23);
            this.supplierName.TabIndex = 2;
            this.supplierName.Text = "Supplier Name";
            // 
            // contactName
            // 
            this.contactName.AutoSize = true;
            this.contactName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.contactName.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactName.Location = new System.Drawing.Point(39, 223);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(120, 23);
            this.contactName.TabIndex = 3;
            this.contactName.Text = "Contact Name";
            // 
            // contactMail
            // 
            this.contactMail.AutoSize = true;
            this.contactMail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.contactMail.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactMail.Location = new System.Drawing.Point(49, 264);
            this.contactMail.Name = "contactMail";
            this.contactMail.Size = new System.Drawing.Size(110, 23);
            this.contactMail.TabIndex = 4;
            this.contactMail.Text = "Contact Mail";
            // 
            // contactNumber
            // 
            this.contactNumber.AutoSize = true;
            this.contactNumber.BackColor = System.Drawing.SystemColors.HighlightText;
            this.contactNumber.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumber.Location = new System.Drawing.Point(21, 302);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(138, 23);
            this.contactNumber.TabIndex = 5;
            this.contactNumber.Text = "Contact Number";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(174, 188);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierName.TabIndex = 6;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(174, 226);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(100, 20);
            this.txtContactName.TabIndex = 7;
            // 
            // txtContactMail
            // 
            this.txtContactMail.Location = new System.Drawing.Point(174, 264);
            this.txtContactMail.Name = "txtContactMail";
            this.txtContactMail.Size = new System.Drawing.Size(100, 20);
            this.txtContactMail.TabIndex = 8;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(174, 305);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(100, 20);
            this.txtContactNumber.TabIndex = 9;
            this.txtContactNumber.TextChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.White;
            this.buttonRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRight.Location = new System.Drawing.Point(120, 33);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(27, 38);
            this.buttonRight.TabIndex = 22;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.White;
            this.buttonLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLeft.Location = new System.Drawing.Point(64, 33);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(27, 38);
            this.buttonLeft.TabIndex = 21;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNew.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonNew.Location = new System.Drawing.Point(50, 376);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 31);
            this.buttonNew.TabIndex = 23;
            this.buttonNew.Text = "New";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonUpdate.Location = new System.Drawing.Point(159, 376);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 31);
            this.buttonUpdate.TabIndex = 24;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(279, 376);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 31);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(393, 360);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 63);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "save changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(513, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 27;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.button3.Location = new System.Drawing.Point(613, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 34);
            this.button3.TabIndex = 29;
            this.button3.Text = "New Order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.orders_detailsTableAdapter = this.orders_detailsTableAdapter;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.sales_detalesTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.suppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShoeStore2020.GuyDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orders_detailsTableAdapter
            // 
            this.orders_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // newOrder
            // 
            this.newOrder.DataSetName = "newOrder";
            this.newOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "orders";
            this.ordersBindingSource1.DataSource = this.newOrder;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ordersTableAdapter = this.ordersTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = ShoeStore2020.newOrderTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 500);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtContactMail);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.contactMail);
            this.Controls.Add(this.contactName);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.supplierId);
            this.Controls.Add(this.txtSupplierId);
            this.DoubleBuffered = true;
            this.Name = "frmSupplier";
            this.Text = "frmSupplier";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label supplierId;
        private System.Windows.Forms.Label supplierName;
        private System.Windows.Forms.Label contactName;
        private System.Windows.Forms.Label contactMail;
        private System.Windows.Forms.Label contactNumber;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtContactMail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private GuyDataSet1TableAdapters.ordersTableAdapter ordersTableAdapter;
        private GuyDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private GuyDataSet1TableAdapters.orders_detailsTableAdapter orders_detailsTableAdapter;
        private System.Windows.Forms.BindingSource orders_detailsBindingSource;
        private newOrder newOrder;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private newOrderTableAdapters.ordersTableAdapter ordersTableAdapter1;
        private newOrderTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}