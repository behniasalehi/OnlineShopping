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
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList.EditorControl.MasterTemplate)).BeginInit();
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
            // MasterTemplate
            // 
            this.CategoryList.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CategoryList.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.CategoryList.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.CategoryList.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CategoryList.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CategoryList.EditorControl.Location = new System.Drawing.Point(0, 0);
            this.CategoryList.EditorControl.Margin = new System.Windows.Forms.Padding(4);
            // 
            // MasterTemplate
            // 
            this.CategoryList.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CategoryList.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CategoryList.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CategoryList.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CategoryList.EditorControl.MasterTemplate.ShowColumnHeaders = false;
            this.CategoryList.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CategoryList.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.CategoryList.EditorControl.Name = "MasterTemplate";
            this.CategoryList.EditorControl.ReadOnly = true;
            this.CategoryList.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryList.EditorControl.ShowGroupPanel = false;
            this.CategoryList.EditorControl.Size = new System.Drawing.Size(300, 187);
            this.CategoryList.EditorControl.TabIndex = 0;
            this.CategoryList.Location = new System.Drawing.Point(555, 45);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(209, 24);
            this.CategoryList.TabIndex = 2;
            this.CategoryList.TabStop = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoryList);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CategoryList;
    }
}