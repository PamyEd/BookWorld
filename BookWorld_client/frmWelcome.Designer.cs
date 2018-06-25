namespace BookWorld_client
{
    partial class frmWelcome
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
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookList
            // 
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvBookList.Location = new System.Drawing.Point(22, 63);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.RowHeadersVisible = false;
            this.dgvBookList.Size = new System.Drawing.Size(230, 149);
            this.dgvBookList.TabIndex = 0;
            this.dgvBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellContentClick);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(22, 25);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(230, 21);
            this.cbCategory.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Book Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Author Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Genre:";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.dgvBookList);
            this.Name = "Welcome";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
    }
}

