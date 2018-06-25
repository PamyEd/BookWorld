namespace BookWorldAdmin
{
    partial class frmBookShelf
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
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBook = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(297, 90);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(64, 26);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(297, 182);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(64, 25);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(297, 138);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 24);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Enabled = false;
            this.txtGenre.Location = new System.Drawing.Point(12, 32);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(265, 20);
            this.txtGenre.TabIndex = 6;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(297, 28);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(64, 26);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Books Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // lbBook
            // 
            this.lbBook.FormattingEnabled = true;
            this.lbBook.Location = new System.Drawing.Point(12, 77);
            this.lbBook.Name = "lbBook";
            this.lbBook.Size = new System.Drawing.Size(265, 147);
            this.lbBook.TabIndex = 13;
            // 
            // frmBookShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 247);
            this.Controls.Add(this.lbBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Name = "frmBookShelf";
            this.Text = "Book World Admin";
            this.Load += new System.EventHandler(this.frmBookShelf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbBook;
    }
}

