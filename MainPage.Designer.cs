namespace OnlineShopping
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.Category = new System.Windows.Forms.ToolStripButton();
            this.Product = new System.Windows.Forms.ToolStripButton();
            this.tlsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsMenu
            // 
            this.tlsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Category,
            this.Product});
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(74, 450);
            this.tlsMenu.TabIndex = 0;
            this.tlsMenu.Text = "tlsMenu";
            // 
            // Category
            // 
            this.Category.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Category.Image = ((System.Drawing.Image)(resources.GetObject("Category.Image")));
            this.Category.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(71, 24);
            this.Category.Text = "Category";
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // Product
            // 
            this.Product.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Product.Image = ((System.Drawing.Image)(resources.GetObject("Product.Image")));
            this.Product.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(71, 24);
            this.Product.Text = "Product";
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlsMenu);
            this.IsMdiContainer = true;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.ToolStripButton Category;
        private System.Windows.Forms.ToolStripButton Product;
    }
}