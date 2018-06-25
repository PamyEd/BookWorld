namespace BookWorldAdmin
{
    partial class frmMain
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
            this.lbGenre = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlGenre = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstGenreList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(15, 28);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(39, 13);
            this.lbGenre.TabIndex = 0;
            this.lbGenre.Text = "Genre:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(184, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Existing Genres";
            // 
            // ddlGenre
            // 
            this.ddlGenre.FormattingEnabled = true;
            this.ddlGenre.Location = new System.Drawing.Point(67, 26);
            this.ddlGenre.Name = "ddlGenre";
            this.ddlGenre.Size = new System.Drawing.Size(188, 21);
            this.ddlGenre.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(106, 62);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 28);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lstGenreList
            // 
            this.lstGenreList.FormattingEnabled = true;
            this.lstGenreList.Location = new System.Drawing.Point(18, 123);
            this.lstGenreList.Name = "lstGenreList";
            this.lstGenreList.Size = new System.Drawing.Size(237, 95);
            this.lstGenreList.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 230);
            this.Controls.Add(this.lstGenreList);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ddlGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbGenre);
            this.Name = "frmMain";
            this.Text = "Genre";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private void InitializeComponent()
        //{
        //    System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Fiction");
        //    System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Non Fiction");
        //    this.lbGenre = new System.Windows.Forms.Label();
        //    this.btnCancel = new System.Windows.Forms.Button();
        //    this.lvGenre = new System.Windows.Forms.ListView();
        //    this.label1 = new System.Windows.Forms.Label();
        //    this.cbGenre = new System.Windows.Forms.ComboBox();
        //    this.btnOK = new System.Windows.Forms.Button();
        //    this.SuspendLayout();
        //    // 
        //    // lbGenre
        //    // 
        //    this.lbGenre.AutoSize = true;
        //    this.lbGenre.Location = new System.Drawing.Point(15, 28);
        //    this.lbGenre.Name = "lbGenre";
        //    this.lbGenre.Size = new System.Drawing.Size(39, 13);
        //    this.lbGenre.TabIndex = 0;
        //    this.lbGenre.Text = "Genre:";
        //    // 
        //    // btnCancel
        //    // 
        //    this.btnCancel.Location = new System.Drawing.Point(184, 62);
        //    this.btnCancel.Name = "btnCancel";
        //    this.btnCancel.Size = new System.Drawing.Size(72, 28);
        //    this.btnCancel.TabIndex = 5;
        //    this.btnCancel.Text = "Close";
        //    this.btnCancel.UseVisualStyleBackColor = true;
        //    // 
        //    // lvGenre
        //    // 
        //    this.lvGenre.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
        //    listViewItem3,
        //    listViewItem4});
        //    this.lvGenre.Location = new System.Drawing.Point(18, 118);
        //    this.lvGenre.Name = "lvGenre";
        //    this.lvGenre.Size = new System.Drawing.Size(238, 100);
        //    this.lvGenre.TabIndex = 6;
        //    this.lvGenre.UseCompatibleStateImageBehavior = false;
        //    // 
        //    // label1
        //    // 
        //    this.label1.AutoSize = true;
        //    this.label1.Location = new System.Drawing.Point(18, 93);
        //    this.label1.Name = "label1";
        //    this.label1.Size = new System.Drawing.Size(80, 13);
        //    this.label1.TabIndex = 7;
        //    this.label1.Text = "Existing Genres";
        //    // 
        //    // cbGenre
        //    // 
        //    this.cbGenre.FormattingEnabled = true;
        //    this.cbGenre.Location = new System.Drawing.Point(67, 26);
        //    this.cbGenre.Name = "cbGenre";
        //    this.cbGenre.Size = new System.Drawing.Size(188, 21);
        //    this.cbGenre.TabIndex = 8;
        //    // 
        //    // btnOK
        //    // 
        //    this.btnOK.Location = new System.Drawing.Point(106, 62);
        //    this.btnOK.Name = "btnOK";
        //    this.btnOK.Size = new System.Drawing.Size(72, 28);
        //    this.btnOK.TabIndex = 9;
        //    this.btnOK.Text = "OK";
        //    this.btnOK.UseVisualStyleBackColor = true;
        //    // 
        //    // frmCategory
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(274, 230);
        //    this.Controls.Add(this.btnOK);
        //    this.Controls.Add(this.cbGenre);
        //    this.Controls.Add(this.label1);
        //    this.Controls.Add(this.lvGenre);
        //    this.Controls.Add(this.btnCancel);
        //    this.Controls.Add(this.lbGenre);
        //    this.Name = "frmCategory";
        //    this.Text = "Genre";
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}

        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlGenre;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lstGenreList;
    }
}