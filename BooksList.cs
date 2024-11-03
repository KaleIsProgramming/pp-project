using PP_PO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Serialization.Metadata;

namespace PP_PO
{
    public partial class BooksList : Form
    {
        private List<Book> collectionOfBooks = new List<Book>();
        public BooksList()
        {
            InitializeComponent();
            BooksGridView.AutoGenerateColumns = true;
            LoadFromFile();
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
                SaveToFile();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (BooksGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in BooksGridView.SelectedRows)
                {
                    Book selectedBook = (Book)row.DataBoundItem;

                    Book bookCopy = new Book
                    {
                        Title = selectedBook.Title,
                        Author = selectedBook.Author,
                        Type = selectedBook.Type,
                        YearOfCreation = selectedBook.YearOfCreation,
                        NumberOfPages = selectedBook.NumberOfPages
                    };

                    AddBookForm editBookForm = new AddBookForm(bookCopy, true);

                    if (editBookForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedBook.Title = editBookForm.NewBook.Title;
                        selectedBook.Author = editBookForm.NewBook.Author;
                        selectedBook.Type = editBookForm.NewBook.Type;
                        selectedBook.YearOfCreation = editBookForm.NewBook.YearOfCreation;
                        selectedBook.NumberOfPages = editBookForm.NewBook.NumberOfPages;
                    }
                }
                UpdateDataGridView();
                SaveToFile();
            }
            else
            {
                MessageBox.Show("Please select item for edit", "Not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                }

                UpdateDataGridView();
                SaveToFile();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadFromFile();
            UpdateDataGridView();
        }

        private void SaveToFile()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter() }
            };

            string jsonString = JsonSerializer.Serialize(collectionOfBooks, options);
            File.WriteAllText("books.json", jsonString);
        }

        private void LoadFromFile()
        {
            if (File.Exists("books.json"))
            {
                var options = new JsonSerializerOptions
                {
                    Converters = { new JsonStringEnumConverter() }
                };

                string jsonString = File.ReadAllText("books.json");
                collectionOfBooks = JsonSerializer.Deserialize<List<Book>>(jsonString, options) ?? new List<Book>();
                UpdateDataGridView();
            }
        }
    }


}
