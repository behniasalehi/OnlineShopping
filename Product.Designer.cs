namespace OnlineShopping
{
    partial class Product
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CategoryList = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.Counter = new System.Windows.Forms.NumericUpDown();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Counter)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // CategoryList
            // 
            // 
            // CategoryList.NestedRadGridView
            // 
            this.CategoryList.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CategoryList.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.CategoryList.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.CategoryList.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CategoryList.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CategoryList.EditorControl.Location = new System.Drawing.Point(0, 0);
            this.CategoryList.EditorControl.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            this.CategoryList.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CategoryList.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CategoryList.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CategoryList.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CategoryList.EditorControl.MasterTemplate.ShowColumnHeaders = false;
            this.CategoryList.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CategoryList.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.CategoryList.EditorControl.Name = "NestedRadGridView";
            this.CategoryList.EditorControl.ReadOnly = true;
            this.CategoryList.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryList.EditorControl.ShowGroupPanel = false;
            this.CategoryList.EditorControl.Size = new System.Drawing.Size(300, 187);
            this.CategoryList.EditorControl.TabIndex = 0;
            this.CategoryList.Location = new System.Drawing.Point(153, 36);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(209, 24);
            this.CategoryList.TabIndex = 2;
            this.CategoryList.TabStop = false;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(-9, 254);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(805, 193);
            this.dgvProduct.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Category : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name : ";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(153, 91);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 22);
            this.txtProductName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "UnitPrice : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Discount : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Image : ";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(153, 145);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 22);
            this.txtUnitPrice.TabIndex = 11;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(573, 42);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 22);
            this.txtDiscount.TabIndex = 12;
            // 
            // Counter
            // 
            this.Counter.Location = new System.Drawing.Point(153, 193);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(120, 22);
            this.Counter.TabIndex = 13;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.CategoryList);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Counter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CategoryList;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.NumericUpDown Counter;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}