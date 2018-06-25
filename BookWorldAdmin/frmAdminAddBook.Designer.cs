namespace BookWorldAdmin
{
    partial class frmAdminAddBook
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.lbAuthorName = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lbISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbItemLeft = new System.Windows.Forms.Label();
            this.ddlGenre = new System.Windows.Forms.ComboBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbItemLeft = new System.Windows.Forms.TextBox();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.lbType = new System.Windows.Forms.Label();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAntique = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPackage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(8, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(66, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Book Name:";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(80, 10);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(192, 20);
            this.tbBookName.TabIndex = 1;
            // 
            // lbAuthorName
            // 
            this.lbAuthorName.AutoSize = true;
            this.lbAuthorName.Location = new System.Drawing.Point(8, 49);
            this.lbAuthorName.Name = "lbAuthorName";
            this.lbAuthorName.Size = new System.Drawing.Size(72, 13);
            this.lbAuthorName.TabIndex = 2;
            this.lbAuthorName.Text = "Author Name:";
            this.lbAuthorName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(80, 44);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(191, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // lbISBN
            // 
            this.lbISBN.AutoSize = true;
            this.lbISBN.Location = new System.Drawing.Point(8, 81);
            this.lbISBN.Name = "lbISBN";
            this.lbISBN.Size = new System.Drawing.Size(35, 13);
            this.lbISBN.TabIndex = 4;
            this.lbISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(80, 78);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(190, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(8, 113);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(39, 13);
            this.lbGenre.TabIndex = 6;
            this.lbGenre.Text = "Genre:";
            this.lbGenre.Click += new System.EventHandler(this.lbGenre_Click);
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(8, 139);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(63, 13);
            this.lbDesc.TabIndex = 7;
            this.lbDesc.Text = "Description:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(8, 204);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 13);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Price:";
            // 
            // lbItemLeft
            // 
            this.lbItemLeft.AutoSize = true;
            this.lbItemLeft.Location = new System.Drawing.Point(129, 207);
            this.lbItemLeft.Name = "lbItemLeft";
            this.lbItemLeft.Size = new System.Drawing.Size(67, 13);
            this.lbItemLeft.TabIndex = 9;
            this.lbItemLeft.Text = "No. of Items:";
            this.lbItemLeft.Click += new System.EventHandler(this.label4_Click);
            // 
            // ddlGenre
            // 
            this.ddlGenre.FormattingEnabled = true;
            this.ddlGenre.Location = new System.Drawing.Point(80, 110);
            this.ddlGenre.Name = "ddlGenre";
            this.ddlGenre.Size = new System.Drawing.Size(188, 21);
            this.ddlGenre.TabIndex = 10;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(48, 203);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(70, 20);
            this.tbPrice.TabIndex = 13;
            // 
            // tbItemLeft
            // 
            this.tbItemLeft.Location = new System.Drawing.Point(202, 204);
            this.tbItemLeft.Name = "tbItemLeft";
            this.tbItemLeft.Size = new System.Drawing.Size(70, 20);
            this.tbItemLeft.TabIndex = 14;
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(80, 139);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(192, 50);
            this.rtbDesc.TabIndex = 15;
            this.rtbDesc.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(108, 313);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 25);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(198, 313);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(74, 25);
            this.btnCancelAdd.TabIndex = 17;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(9, 241);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(34, 13);
            this.lbType.TabIndex = 18;
            this.lbType.Text = "Type:";
            // 
            // ddlType
            // 
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Items.AddRange(new object[] {
            "New",
            "Used"});
            this.ddlType.Location = new System.Drawing.Point(48, 233);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(70, 21);
            this.ddlType.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Anitique:";
            // 
            // cbAntique
            // 
            this.cbAntique.AutoSize = true;
            this.cbAntique.Location = new System.Drawing.Point(202, 241);
            this.cbAntique.Name = "cbAntique";
            this.cbAntique.Size = new System.Drawing.Size(15, 14);
            this.cbAntique.TabIndex = 21;
            this.cbAntique.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Package:";
            // 
            // cbPackage
            // 
            this.cbPackage.FormattingEnabled = true;
            this.cbPackage.Items.AddRange(new object[] {
            "Paperback",
            "Hardcover"});
            this.cbPackage.Location = new System.Drawing.Point(202, 259);
            this.cbPackage.Name = "cbPackage";
            this.cbPackage.Size = new System.Drawing.Size(70, 21);
            this.cbPackage.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(48, 264);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(70, 20);
            this.txtWeight.TabIndex = 25;
            // 
            // frmAdminAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 350);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPackage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAntique);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.tbItemLeft);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.ddlGenre);
            this.Controls.Add(this.lbItemLeft);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lbISBN);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lbAuthorName);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.lbName);
            this.Name = "frmAdminAddBook";
            this.Text = "AdminAddBook";
            this.Load += new System.EventHandler(this.frmAdminAddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label lbAuthorName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lbISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbItemLeft;
        private System.Windows.Forms.ComboBox ddlGenre;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbItemLeft;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox ddlType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAntique;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPackage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeight;
    }
}