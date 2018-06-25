using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorldAdmin
{
    public sealed partial class frmMain : Form
    {
        private static readonly frmMain _Instance = new frmMain();
   
        public frmMain()
        {
            InitializeComponent();
            //FillGenre();
        }

        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }

        //private void updateTitle(string prBookStoreName)
        //{
        //    if(!string.IsNullOrEmpty(prBookStoreName))
        //    {
        //        Text = "Book Store = " + prBookStoreName;
        //    }
        //}


        public async void UpdateDisplay()
        {
            ddlGenre.DataSource = null;
            ddlGenre.DataSource = await ServiceClient.GetGenreNamesAsync();
        }

        //public string[] getGenre()
        //{
        //    string[] ArrayGenre = new string[lstGenreList.Items.Count];
        //    for (int i = 0; i < lstGenreList.Items.Count; i++)
        //    {
        //        ArrayGenre[i] = lstGenreList.Items[i].ToString();
        //    }
        //    return ArrayGenre;
        //}

        

        private void btnOK_Click(object sender, EventArgs e)
        {
            var selectedVal = ddlGenre.Text;
            
            try
            {
                this.Hide();
                frmBookShelf frmBookShelf = new frmBookShelf();
                frmBookShelf.Run(selectedVal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading BookList");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            UpdateDisplay();
       
        }

        public void Run()
        {
            this.ShowDialog();
        }
    }
}
