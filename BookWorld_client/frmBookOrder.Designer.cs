namespace BookWorld_client
{
    partial class frmBookOrder
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
            this.pbBookImg = new System.Windows.Forms.PictureBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNameData = new System.Windows.Forms.Label();
            this.lbAuthorData = new System.Windows.Forms.Label();
            this.lbGenreData = new System.Windows.Forms.Label();
            this.lbDescData = new System.Windows.Forms.Label();
            this.lbPriceData = new System.Windows.Forms.Label();
            this.lbDiscountData = new System.Windows.Forms.Label();
            this.lbTotalData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBookImg
            // 
            this.pbBookImg.Location = new System.Drawing.Point(12, 12);
            this.pbBookImg.Name = "pbBookImg";
            this.pbBookImg.Size = new System.Drawing.Size(101, 105);
            this.pbBookImg.TabIndex = 0;
            this.pbBookImg.TabStop = false;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(119, 12);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(38, 13);
            this.lbBookName.TabIndex = 1;
            this.lbBookName.Text = "Name:";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(119, 44);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(41, 13);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.Text = "Author:";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(119, 72);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(39, 13);
            this.lbGenre.TabIndex = 3;
            this.lbGenre.Text = "Genre:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(119, 104);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(54, 13);
            this.lbType.TabIndex = 4;
            this.lbType.Text = "Condition:";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(9, 132);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(63, 13);
            this.lbDesc.TabIndex = 5;
            this.lbDesc.Text = "Description:";
            this.lbDesc.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(9, 165);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 13);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "Price:";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(9, 193);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(52, 13);
            this.lbDiscount.TabIndex = 7;
            this.lbDiscount.Text = "Discount:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "New",
            "Used"});
            this.cbType.Location = new System.Drawing.Point(179, 96);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(58, 21);
            this.cbType.TabIndex = 8;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(16, 225);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(74, 25);
            this.btnBuy.TabIndex = 9;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(99, 224);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(74, 25);
            this.btnGoBack.TabIndex = 10;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(184, 224);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 25);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(119, 193);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 13);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "Total:";
            // 
            // lbQty
            // 
            this.lbQty.AutoSize = true;
            this.lbQty.Location = new System.Drawing.Point(119, 165);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(26, 13);
            this.lbQty.TabIndex = 13;
            this.lbQty.Text = "Qty:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 14;
            // 
            // lbNameData
            // 
            this.lbNameData.AutoSize = true;
            this.lbNameData.Location = new System.Drawing.Point(161, 12);
            this.lbNameData.Name = "lbNameData";
            this.lbNameData.Size = new System.Drawing.Size(35, 13);
            this.lbNameData.TabIndex = 15;
            this.lbNameData.Text = "label1";
            // 
            // lbAuthorData
            // 
            this.lbAuthorData.AutoSize = true;
            this.lbAuthorData.Location = new System.Drawing.Point(161, 44);
            this.lbAuthorData.Name = "lbAuthorData";
            this.lbAuthorData.Size = new System.Drawing.Size(35, 13);
            this.lbAuthorData.TabIndex = 16;
            this.lbAuthorData.Text = "label2";
            // 
            // lbGenreData
            // 
            this.lbGenreData.AutoSize = true;
            this.lbGenreData.Location = new System.Drawing.Point(161, 72);
            this.lbGenreData.Name = "lbGenreData";
            this.lbGenreData.Size = new System.Drawing.Size(35, 13);
            this.lbGenreData.TabIndex = 17;
            this.lbGenreData.Text = "label3";
            // 
            // lbDescData
            // 
            this.lbDescData.AutoSize = true;
            this.lbDescData.Location = new System.Drawing.Point(68, 132);
            this.lbDescData.Name = "lbDescData";
            this.lbDescData.Size = new System.Drawing.Size(35, 13);
            this.lbDescData.TabIndex = 18;
            this.lbDescData.Text = "label4";
            // 
            // lbPriceData
            // 
            this.lbPriceData.AutoSize = true;
            this.lbPriceData.Location = new System.Drawing.Point(68, 165);
            this.lbPriceData.Name = "lbPriceData";
            this.lbPriceData.Size = new System.Drawing.Size(35, 13);
            this.lbPriceData.TabIndex = 19;
            this.lbPriceData.Text = "label5";
            // 
            // lbDiscountData
            // 
            this.lbDiscountData.AutoSize = true;
            this.lbDiscountData.Location = new System.Drawing.Point(68, 193);
            this.lbDiscountData.Name = "lbDiscountData";
            this.lbDiscountData.Size = new System.Drawing.Size(35, 13);
            this.lbDiscountData.TabIndex = 20;
            this.lbDiscountData.Text = "label6";
            // 
            // lbTotalData
            // 
            this.lbTotalData.AutoSize = true;
            this.lbTotalData.Location = new System.Drawing.Point(177, 193);
            this.lbTotalData.Name = "lbTotalData";
            this.lbTotalData.Size = new System.Drawing.Size(35, 13);
            this.lbTotalData.TabIndex = 21;
            this.lbTotalData.Text = "label7";
            // 
            // BookOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbTotalData);
            this.Controls.Add(this.lbDiscountData);
            this.Controls.Add(this.lbPriceData);
            this.Controls.Add(this.lbDescData);
            this.Controls.Add(this.lbGenreData);
            this.Controls.Add(this.lbAuthorData);
            this.Controls.Add(this.lbNameData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbQty);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.pbBookImg);
            this.Name = "BookOrder";
            this.Text = "BookOrder";
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBookImg;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNameData;
        private System.Windows.Forms.Label lbAuthorData;
        private System.Windows.Forms.Label lbGenreData;
        private System.Windows.Forms.Label lbDescData;
        private System.Windows.Forms.Label lbPriceData;
        private System.Windows.Forms.Label lbDiscountData;
        private System.Windows.Forms.Label lbTotalData;
    }
}