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
    public partial class frmEditBook : Form
    {

        private clsBook _Book = new clsBook();
        public frmEditBook()
        {
            InitializeComponent();
        }

        public void Run(string BookId)
        {
            UpdateDisplay(BookId);
            this.ShowDialog();
        }

        private void frmEditBook_Load(object sender, EventArgs e)
        {
            
        }

        public async void UpdateDisplay(string prBookId)
        {
            _Book = await ServiceClient.GetBooksDetailsAsync(prBookId);

            txtBookId.Text = _Book.BookId.ToString();
            tbBookName.Text = _Book.BookName;
            txtAuthor.Text = _Book.AuthorName;
            txtISBN.Text = _Book.ISBN.ToString();
            rtbDesc.Text = _Book.BookDesc;
            tbPrice.Text = _Book.Price.ToString();
            tbItemLeft.Text = _Book.BooksLeft.ToString();
            ddlType.SelectedItem = _Book.Condition;
            
            ddlGenre.DataSource = null;
            ddlGenre.DataSource = await ServiceClient.GetGenreNamesAsync();
            string genre = await ServiceClient.GetGenreNameAsync(_Book.GenreId.ToString());
            ddlGenre.Text = genre;
            
            cbAntique.Checked = bool.Parse(_Book.Antique.ToString());
            if (_Book.Package == "Paperback")
            {
                ddlPackage.SelectedIndex = 0; 
            }
            else
            {
                ddlPackage.SelectedIndex = 1;
            }
            txtWeight.Text = _Book.Weight.ToString();
            
        }

        protected async void NewData()
        {
            _Book.BookId = int.Parse(txtBookId.Text);
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
            if (cbAntique.Checked)
            {
                _Book.Antique = true;
            }
            else
            {
                _Book.Antique = false;
            }
            _Book.Package = ddlPackage.SelectedItem.ToString();
            //Console.WriteLine("Package {0}", cbPackage.SelectedItem.ToString());
            _Book.Weight = decimal.Parse(txtWeight.Text);
            string Response = string.Empty;
            //Console.WriteLine("Package here", _Book.Package);
            Response = await ServiceClient.UpdateBookAsync(_Book);
            MessageBox.Show(Response);


        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            try
            {
                NewData();
                string genre = ddlGenre.SelectedItem.ToString();
                //CheckIfExist();
                //InsertBook();
                this.Hide();
                frmBookShelf frmBookShelf = new frmBookShelf();
                frmBookShelf.Run(genre);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in updating BookList");
            }
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            string genre = ddlGenre.SelectedItem.ToString();
            this.Hide();
            frmBookShelf frmBookShelf = new frmBookShelf();
            frmBookShelf.Run(genre);
        }
    }
}
