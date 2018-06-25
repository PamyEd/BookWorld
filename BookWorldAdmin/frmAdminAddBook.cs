using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BookWorldSelfhost;

namespace BookWorldAdmin
{
    public partial class frmAdminAddBook : Form
    {
       
        private clsBook _Book = new clsBook();
        public frmAdminAddBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbGenre_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void Run()
        {
            this.ShowDialog();
        }

        private void frmAdminAddBook_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        public async void UpdateDisplay()
        {
            ddlGenre.DataSource = null;
            ddlGenre.DataSource = await ServiceClient.GetGenreNamesAsync();
        }

        protected async void NewData()
        {
            _Book.BookName = tbBookName.Text;
            _Book.AuthorName = txtAuthor.Text;
            _Book.ISBN = int.Parse(txtISBN.Text);
            _Book.BookDesc = rtbDesc.Text;
            _Book.Price = decimal.Parse(tbPrice.Text);
            _Book.BooksLeft = int.Parse(tbItemLeft.Text);
            _Book.LastUpdatedDate = DateTime.Now.ToString();
            _Book.Condition = ddlType.SelectedItem.ToString();
            string genreid = null;
            genreid = await ServiceClient.GetGenreIdAsync(ddlGenre.SelectedItem.ToString());
            _Book.GenreId = int.Parse(genreid);
            if(cbAntique.Checked)
            {
                _Book.Antique = true;
            }
            else
            {
                _Book.Antique = false;
            }
            _Book.Package = cbPackage.SelectedItem.ToString();
            //Console.WriteLine("Package {0}", cbPackage.SelectedItem.ToString());
            _Book.Weight = decimal.Parse(txtWeight.Text);
            string Response = string.Empty;
            //Console.WriteLine("Package here", _Book.Package);
            Response = await ServiceClient.InsertBookAsync(_Book);
            MessageBox.Show(Response);


        }

        protected async void CheckIfExist()
        {
            string result = await ServiceClient.GetBookNameAsync(_Book.BookName);
            if(result=="1")
            {
                MessageBox.Show("Book Already exist");
            }
        }

        protected async void InsertBook()
        {
            string Response = string.Empty;
            Console.WriteLine("Package here", _Book.Package);
            Response = await ServiceClient.InsertBookAsync(_Book);
            MessageBox.Show(Response);
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string genre = ddlGenre.SelectedItem.ToString();
                this.Hide();
                frmBookShelf frmBookShelf = new frmBookShelf();
                frmBookShelf.Run(genre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading BookList");
            }
        }

        public void RefreshPage()
        {
            tbBookName.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtISBN.Text = string.Empty;
            rtbDesc.Text = string.Empty;
            tbPrice.Text = string.Empty;
            tbItemLeft.Text = string.Empty;
            cbAntique.Checked = false;
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            try
            {
                NewData();

                //CheckIfExist();
                //InsertBook();
                RefreshPage();
                
            }
            catch(Exception ex)
            {

            }
        }

    }
}
