namespace BookWorldAdmin
{
    partial class frmAdminOrderHistory
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
            this.dgvOrderHistory = new System.Windows.Forms.DataGridView();
            this.btnOKHistory = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderHistory
            // 
            this.dgvOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column8,
            this.Column4,
            this.Column5});
            this.dgvOrderHistory.Location = new System.Drawing.Point(11, 38);
            this.dgvOrderHistory.Name = "dgvOrderHistory";
            this.dgvOrderHistory.RowHeadersVisible = false;
            this.dgvOrderHistory.Size = new System.Drawing.Size(448, 151);
            this.dgvOrderHistory.TabIndex = 0;
            // 
            // btnOKHistory
            // 
            this.btnOKHistory.Location = new System.Drawing.Point(381, 212);
            this.btnOKHistory.Name = "btnOKHistory";
            this.btnOKHistory.Size = new System.Drawing.Size(78, 26);
            this.btnOKHistory.TabIndex = 1;
            this.btnOKHistory.Text = "OK";
            this.btnOKHistory.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "OrderNo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 35;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BookId";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 35;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Qty";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 35;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Price";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 35;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Discount";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 35;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 35;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order History";
            // 
            // AdminOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOKHistory);
            this.Controls.Add(this.dgvOrderHistory);
            this.Name = "AdminOrderHistory";
            this.Text = "Order History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderHistory;
        private System.Windows.Forms.Button btnOKHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
    }
}