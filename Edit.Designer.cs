namespace OnlineShopping
{
    partial class Edit
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
            this.txtEditId = new System.Windows.Forms.TextBox();
            this.txtCategoryNameEdit = new System.Windows.Forms.TextBox();
            this.txtDescriptionsEdit = new System.Windows.Forms.TextBox();
            this.btnSubmitEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEditId
            // 
            this.txtEditId.Enabled = false;
            this.txtEditId.Location = new System.Drawing.Point(73, 29);
            this.txtEditId.Name = "txtEditId";
            this.txtEditId.ReadOnly = true;
            this.txtEditId.Size = new System.Drawing.Size(100, 22);
            this.txtEditId.TabIndex = 0;
            // 
            // txtCategoryNameEdit
            // 
            this.txtCategoryNameEdit.Location = new System.Drawing.Point(73, 67);
            this.txtCategoryNameEdit.Name = "txtCategoryNameEdit";
            this.txtCategoryNameEdit.Size = new System.Drawing.Size(325, 22);
            this.txtCategoryNameEdit.TabIndex = 1;
            // 
            // txtDescriptionsEdit
            // 
            this.txtDescriptionsEdit.Location = new System.Drawing.Point(417, 67);
            this.txtDescriptionsEdit.Name = "txtDescriptionsEdit";
            this.txtDescriptionsEdit.Size = new System.Drawing.Size(325, 22);
            this.txtDescriptionsEdit.TabIndex = 2;
            // 
            // btnSubmitEdit
            // 
            this.btnSubmitEdit.Location = new System.Drawing.Point(73, 139);
            this.btnSubmitEdit.Name = "btnSubmitEdit";
            this.btnSubmitEdit.Size = new System.Drawing.Size(100, 31);
            this.btnSubmitEdit.TabIndex = 3;
            this.btnSubmitEdit.Text = "Submit";
            this.btnSubmitEdit.UseVisualStyleBackColor = true;
            this.btnSubmitEdit.Click += new System.EventHandler(this.BtnSubmitEdit_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitEdit);
            this.Controls.Add(this.txtDescriptionsEdit);
            this.Controls.Add(this.txtCategoryNameEdit);
            this.Controls.Add(this.txtEditId);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmitEdit;
        public System.Windows.Forms.TextBox txtEditId;
        public System.Windows.Forms.TextBox txtCategoryNameEdit;
        public System.Windows.Forms.TextBox txtDescriptionsEdit;
    }
}