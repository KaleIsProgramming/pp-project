using PP_PO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_PO
{
    public partial class BooksList : Form
    {
        private List<Book> collectionOfBooks = new List<Book>();
        public BooksList()
        {
            InitializeComponent();
            BooksGridView.AutoGenerateColumns = true;
        }

        private void UpdateDataGridView()
        {
            BooksGridView.DataSource = null;
            BooksGridView.DataSource = collectionOfBooks;
        }


        private void addBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();

            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                collectionOfBooks.Add(addBookForm.NewBook);
                UpdateDataGridView();
            }
        }
    }


}
