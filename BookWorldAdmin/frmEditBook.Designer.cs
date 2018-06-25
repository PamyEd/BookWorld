namespace BookWorldAdmin
{
    partial class frmEditBook
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
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlPackage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAntique = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.tbItemLeft = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.ddlGenre = new System.Windows.Forms.ComboBox();
            this.lbItemLeft = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lbISBN = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lbAuthorName = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(55, 261);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(70, 20);
            this.txtWeight.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Weight:";
            // 
            // ddlPackage
            // 
            this.ddlPackage.FormattingEnabled = true;
            this.ddlPackage.Items.AddRange(new object[] {
            "Paperback",
            "Hardcover"});
            this.ddlPackage.Location = new System.Drawing.Point(209, 256);
            this.ddlPackage.Name = "ddlPackage";
            this.ddlPackage.Size = new System.Drawing.Size(70, 21);
            this.ddlPackage.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Package:";
            // 
            // cbAntique
            // 
            this.cbAntique.AutoSize = true;
            this.cbAntique.Location = new System.Drawing.Point(209, 238);
            this.cbAntique.Name = "cbAntique";
            this.cbAntique.Size = new System.Drawing.Size(15, 14);
            this.cbAntique.TabIndex = 45;
            this.cbAntique.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Anitique:";
            // 
            // ddlType
            // 
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Items.AddRange(new object[] {
            "New",
            "Used"});
            this.ddlType.Location = new System.Drawing.Point(55, 230);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(70, 21);
            this.ddlType.TabIndex = 43;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(16, 238);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(34, 13);
            this.lbType.TabIndex = 42;
            this.lbType.Text = "Type:";
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(205, 310);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(74, 25);
            this.btnCancelAdd.TabIndex = 41;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(115, 310);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 25);
            this.btnOK.TabIndex = 40;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(87, 136);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(192, 50);
            this.rtbDesc.TabIndex = 39;
            this.rtbDesc.Text = "";
            // 
            // tbItemLeft
            // 
            this.tbItemLeft.Location = new System.Drawing.Point(209, 201);
            this.tbItemLeft.Name = "tbItemLeft";
            this.tbItemLeft.Size = new System.Drawing.Size(70, 20);
            this.tbItemLeft.TabIndex = 38;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(55, 200);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(70, 20);
            this.tbPrice.TabIndex = 37;
            // 
            // ddlGenre
            // 
            this.ddlGenre.FormattingEnabled = true;
            this.ddlGenre.Location = new System.Drawing.Point(87, 107);
            this.ddlGenre.Name = "ddlGenre";
            this.ddlGenre.Size = new System.Drawing.Size(188, 21);
            this.ddlGenre.TabIndex = 36;
            // 
            // lbItemLeft
            // 
            this.lbItemLeft.AutoSize = true;
            this.lbItemLeft.Location = new System.Drawing.Point(136, 204);
            this.lbItemLeft.Name = "lbItemLeft";
            this.lbItemLeft.Size = new System.Drawing.Size(67, 13);
            this.lbItemLeft.TabIndex = 35;
            this.lbItemLeft.Text = "No. of Items:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(15, 201);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 13);
            this.lbPrice.TabIndex = 34;
            this.lbPrice.Text = "Price:";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(15, 136);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(63, 13);
            this.lbDesc.TabIndex = 33;
            this.lbDesc.Text = "Description:";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(15, 110);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(39, 13);
            this.lbGenre.TabIndex = 32;
            this.lbGenre.Text = "Genre:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(87, 75);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(190, 20);
            this.txtISBN.TabIndex = 31;
            // 
            // lbISBN
            // 
            this.lbISBN.AutoSize = true;
            this.lbISBN.Location = new System.Drawing.Point(15, 78);
            this.lbISBN.Name = "lbISBN";
            this.lbISBN.Size = new System.Drawing.Size(35, 13);
            this.lbISBN.TabIndex = 30;
            this.lbISBN.Text = "ISBN:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(87, 41);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(191, 20);
            this.txtAuthor.TabIndex = 29;
            // 
            // lbAuthorName
            // 
            this.lbAuthorName.AutoSize = true;
            this.lbAuthorName.Location = new System.Drawing.Point(15, 46);
            this.lbAuthorName.Name = "lbAuthorName";
            this.lbAuthorName.Size = new System.Drawing.Size(72, 13);
            this.lbAuthorName.TabIndex = 28;
            this.lbAuthorName.Text = "Author Name:";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(87, 7);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(192, 20);
            this.tbBookName.TabIndex = 27;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(15, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(66, 13);
            this.lbName.TabIndex = 26;
            this.lbName.Text = "Book Name:";
            // 
            // txtBookId
            // 
            this.txtBookId.Enabled = false;
            this.txtBookId.Location = new System.Drawing.Point(55, 313);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(41, 20);
            this.txtBookId.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Id:";
            // 
            // frmEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlPackage);
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
            this.Name = "frmEditBook";
            this.Text = "frmEditBook";
            this.Load += new System.EventHandler(this.frmEditBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlPackage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAntique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.TextBox tbItemLeft;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.ComboBox ddlGenre;
        private System.Windows.Forms.Label lbItemLeft;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lbISBN;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lbAuthorName;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label4;
    }
}