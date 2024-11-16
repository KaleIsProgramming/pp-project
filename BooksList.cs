using PP_PO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PP_PO
{
    public partial class BooksList : Form
    {
        private List<Media> mediaList = new List<Media>();
        private List<Book> collectionOfBooks = new List<Book>();

        public BooksList()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadFromFile();
        }

        private void UpdateDataGridView()
        {
            BooksGridView.DataSource = null;
            BooksGridView.DataSource = new BindingList<Book>(collectionOfBooks);
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();

            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                Book newBook = addBookForm.NewBook;
                mediaList.Add(newBook);
                collectionOfBooks.Add(newBook);
                MediaDataAccess.SaveMediaList(mediaList);
                UpdateDataGridView();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (BooksGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in BooksGridView.SelectedRows)
                {
                    Book selectedBook = (Book)row.DataBoundItem;

                    AddBookForm editBookForm = new AddBookForm(selectedBook, true);

                    if (editBookForm.ShowDialog() == DialogResult.OK)
                    {
                        Book editedBook = editBookForm.NewBook;

                        int index = mediaList.IndexOf(selectedBook);
                        if (index >= 0)
                        {
                            mediaList[index] = editedBook;
                        }

                        int bookIndex = collectionOfBooks.IndexOf(selectedBook);
                        if (bookIndex >= 0)
                        {
                            collectionOfBooks[bookIndex] = editedBook;
                        }
                    }
                }
                MediaDataAccess.SaveMediaList(mediaList);
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Please select element for edition", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (BooksGridView.SelectedRows.Count > 0)
            {
                List<Book> booksToRemove = new List<Book>();
                foreach (DataGridViewRow row in BooksGridView.SelectedRows)
                {
                    Book selectedBook = (Book)row.DataBoundItem;
                    booksToRemove.Add(selectedBook);
                }
                foreach (Book book in booksToRemove)
                {
                    collectionOfBooks.Remove(book);
                    mediaList.Remove(book);
                }

                MediaDataAccess.SaveMediaList(mediaList);
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Please select element for deletion", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadFromFile();
            UpdateDataGridView();
        }

        private void LoadFromFile()
        {
            mediaList = MediaDataAccess.LoadMediaList();
            collectionOfBooks = mediaList.OfType<Book>().ToList();
            UpdateDataGridView();
        }

        private void SetupDataGridView()
        {
            BooksGridView.AutoGenerateColumns = false;
            BooksGridView.Columns.Clear();

            BooksGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Title"
            });
            BooksGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Author",
                HeaderText = "Author"
            });
            BooksGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "YearOfCreation",
                HeaderText = "Year of creation"
            });

            BooksGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FileFormat",
                HeaderText = "File format"
            });

            BooksGridView.CellFormatting += BooksGridView_CellFormatting;
        }

        private void BooksGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (BooksGridView.Columns[e.ColumnIndex].DataPropertyName == "FileFormat")
            {
                var book = BooksGridView.Rows[e.RowIndex].DataBoundItem as Book;
                if (book is EBook ebook)
                {
                    e.Value = ebook.FileFormat;
                }
                else
                {
                    e.Value = string.Empty;
                }
            }
        }
        private void DataGridViewBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                Book selectedBook = collectionOfBooks[e.RowIndex];

                selectedBook.DisplayInfo();
            }
        }
    }
}
