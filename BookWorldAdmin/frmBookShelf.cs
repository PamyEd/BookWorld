using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using BookWorldSelfhost;


namespace BookWorldAdmin
{
    public partial class frmBookShelf : Form
    {

      
        public frmBookShelf()
        {
            InitializeComponent();
        }

        public void Run(string prGenre)
        {
            Console.WriteLine(prGenre);
            UpdateForm(prGenre);
            this.ShowDialog();
            
        }


        //public void SetDetails(clsGenreList prGenre)
        //{
        //    _Genre = prGenre;
        //    txtGenre.Enabled = string.IsNullOrEmpty(_Genre.Name);
            
            
        //}

        public void UpdateForm(string Genre)
        {
            txtGenre.Text = Genre;
            FillGrid(Genre);
        }
        private void lvBookInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public async void FillGrid(string Genre)
        {
            //var list = new List<clsBook>();

            //var bindingList = new BindingList<clsBook>;
            //var source = new BindingSource(bindingList, null);
            //grid.DataSource = source;
            //string[] words;
            //string str = string.Empty;
            //DataTable dt = new DataTable();
            //List<BookWorldSelfhost.clsBook> lsttemp = await ServiceClient.GetBookNamesAsync(Genre);
            //foreach (var temp in lsttemp)
            //{
            //    str = temp.ToString();
            //    words = str.Split('');
            //    dt.Rows.Add(new Object[] { words[0], words[1], words[2] });
            //}





            //dgvBook.DataSource = null;
            //dgvBook.DataSource = await ServiceClient.GetBookNamesAsync(Genre);

            lbBook.DataSource = null;
            lbBook.DataSource = await ServiceClient.GetBookNamesAsync(Genre);

        }

        private void frmBookShelf_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading BookList");
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmAdminAddBook frmAdminAddBook = new frmAdminAddBook();
                frmAdminAddBook.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading BookList");
            }

        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int flg = 0;
                //foreach (DataGridViewRow row in dgvBook.Rows)
                //{
                //    if (Convert.ToBoolean(row.Cells[1].Value))
                //    {
                //        flg = 1;
                //    }
                //}
                    if (lbBook.SelectedIndex==-1)
                {
                    MessageBox.Show("Please Select an item!");
                }
                else
                {
                    string[] stringSeparators = new string[] { "  " };
                    this.Hide();
                    string BookSelected = lbBook.SelectedItem.ToString();
                    string[] Words = BookSelected.Split(stringSeparators, StringSplitOptions.None);
                    string BookName1 = Words[0];
                    string Id = await ServiceClient.GetBookIdAsync(BookName1);
                    frmEditBook frmEditBook = new frmEditBook();
                    frmEditBook.Run(Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading BookList");
            }
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            { 
                if (lbBook.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select an item!");
                }
                else
                {
                    string currentgenre = txtGenre.Text;
                    string[] stringSeparators = new string[] { "  " };
                    this.Hide();
                    string BookSelected = lbBook.SelectedItem.ToString();
                    string[] Words = BookSelected.Split(stringSeparators, StringSplitOptions.None);
                    string BookName1 = Words[0];
                    string Id = await ServiceClient.GetBookIdAsync(BookName1);
                    //frmEditBook frmEditBook = new frmEditBook();
                    //frmEditBook.Run(Id);
                    string DeleteResponse = string.Empty;

                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        DeleteResponse = await ServiceClient.DeleteBookAsync(Id);
                        this.Run(currentgenre);
                        this.ShowDialog();
                    }
                    else
                    {
                        
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading BookList");
            }
        }
    }
}
