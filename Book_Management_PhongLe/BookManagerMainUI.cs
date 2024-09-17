using Microsoft.Extensions.Logging.Abstractions;
using Repositories;
using Repositories.Entities;
using Services;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Book_Management_PhongLe
{
    public partial class BookManagerMainUI : Form
    {


        private BookServices services = new BookServices();
        private Book selectedBook = null;
        public BookManagerMainUI()
        {
            InitializeComponent();
        }

        private void FillDataGrip()
        {
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = services.GetAllBook();
        }

        private void BookManagerMainUI_Load(object sender, EventArgs e)
        {

            FillDataGrip();
            //dgvBookList.DataSource = null;
            //dgvBookList.DataSource = services.GetAllBook();
            //List<Book> arr = db.Books.ToList();
            //dgvBookList.DataSource = arr;
            //dgvBookList.Columns["BookCategory"].Visible = false;



        }



        private void btnCreate_Click(object sender, EventArgs e)
        {

            //Application.Run(new BookDetailForm());
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog();
            //f.Show();


            // f5 luooi

            FillDataGrip();



        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {


            if (dgvBookList.SelectedRows.Count == 1)
            {
                // lấy cuốn sách đầu tiên
                //BookServices services = new BookServices();
                selectedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;

                //BookDetailForm f = new BookDetailForm();
                //f.SelectedBook = selected;
                //f.ShowDialog();
                if (selectedBook != null)
                {
                    MessageBox.Show("Đã chọn thành công", "Sách được chọn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }



            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (selectedBook != null)
            {
                BookDetailForm f = new BookDetailForm();
                f.SelectedBook = selectedBook;
                f.ShowDialog();
                // f5
                FillDataGrip();
            }
            else
            {
                MessageBox.Show("Please select a book first.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedBook = null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchText = txtBookName.Text;

            //List<Book> arr = db.Books.ToList();
            var books = services.GetAllBook();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = books.Where(book => (book.BookName.ToLower().IndexOf(txtBookName.Text, StringComparison.OrdinalIgnoreCase) >= 0 && txtBookName.Text != "") || (book.Description.ToLower().IndexOf(txtBookDescription.Text, StringComparison.OrdinalIgnoreCase) >= 0 && txtBookDescription.Text != "")).ToList();


        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận khi người dùng nhấn nút Quit
            DialogResult result = MessageBox.Show(
                "Are you sure you want to quit the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Kiểm tra kết quả từ hộp thoại xác nhận
            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn Yes, thoát ứng dụng
                Application.Exit();
            }
            // Nếu người dùng chọn No, không làm gì cả
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            List<Book> arr = services.GetAllBook();
            dgvBookList.DataSource = arr;
            dgvBookList.Columns["BookCategory"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBook != null)
            {
                DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this book",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    services.RemoveBookFromUI(selectedBook);
                    // f5
                    FillDataGrip();
                    selectedBook = null;
                }
                 
            }
            else
            {
                MessageBox.Show("Please select a book first.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}
    }
}
