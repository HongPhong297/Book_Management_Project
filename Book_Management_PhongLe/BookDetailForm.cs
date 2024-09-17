using Repositories;
using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Management_PhongLe
{
    public partial class BookDetailForm : Form
    {
        public Book SelectedBook { get; set; } = null;

        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            BookCategoryServices cat = new BookCategoryServices();
            
            //cboBookCaretoryID.DataSource = new BookManagementDbContext().BookCategories.ToList();
            cboBookCaretoryID.DataSource = cat.GetCateroty();
            // chon cot de hien thi
            cboBookCaretoryID.DisplayMember = "BookGenreType";
            // map BookGenreType -> BookCategoryId de xu ly sau
            cboBookCaretoryID.ValueMember = "BookCategoryId";

            // default value
            cboBookCaretoryID.SelectedValue = 3;


            if (SelectedBook != null)
            {
                //txtBookID.Text = SelectedBook.BookId.ToString();
                //txtBookName.Text = SelectedBook.BookName.ToString();
                //txtDescription.Text = SelectedBook.Description;
                //cboBookCaretoryID.SelectedValue = SelectedBook.BookCategoryId;
                lblHeader.Text = "Update selected book";
                txtBookID.Text = SelectedBook.BookId.ToString();
                txtBookID.Enabled = false;
                txtBookName.Text = SelectedBook.BookName;
                txtDescription.Text = SelectedBook.Description;
                cboBookCaretoryID.SelectedValue = SelectedBook.BookCategoryId;
                dtbPublicationDay.Value = SelectedBook.PublicationDate;
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();
                txtAuthor.Text = SelectedBook.Author;

            }
            else
            {
                lblHeader.Text = "Create a new book";
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool check_Null()
        {
            if (string.IsNullOrEmpty(txtBookID.Text) ||
                string.IsNullOrEmpty(txtBookName.Text) ||
                string.IsNullOrEmpty(txtDescription.Text) ||
                string.IsNullOrEmpty(txtQuantity.Text) ||
                string.IsNullOrEmpty(txtPrice.Text) ||
                string.IsNullOrEmpty(txtAuthor.Text) ||
                cboBookCaretoryID.SelectedValue == null)
            {
                return true;
            }

            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (check_Null())
            {
                MessageBox.Show("Please input full of data book", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Book book = new Book()
            {
                BookId = int.Parse(txtBookID.Text),
                BookName = txtBookName.Text,
                Description = txtDescription.Text,
                PublicationDate = dtbPublicationDay.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Price = double.Parse(txtPrice.Text),
                Author = txtAuthor.Text,
                BookCategoryId = int.Parse(cboBookCaretoryID.SelectedValue.ToString())

            };

            
            // gui xuoong databbase
            BookServices services = new BookServices();
            // check mode
            if (SelectedBook != null)
            {
                // update
                services.UpdateBookFromUI(book);
                Close();
            }
            else
            {
                // create new
                services.AddBookFromUI(book);
                if (services._checkdup == true)
                {
                    MessageBox.Show("Please select a other bookid", "Duplicate Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Close();
                }
            }

            
        }
    }
}
