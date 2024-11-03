using System;
using System.Windows.Forms;
using PP_PO.Models; // Dodaj ten using, aby uzyskać dostęp do klasy Book

namespace PP_PO
{
    public partial class AddBookForm : Form
    {
        public Book NewBook { get; private set; }
        private bool isEditing;

        public AddBookForm()
        {
            InitializeComponent();
            NewBook = new Book();
            isEditing = false;
        }

        public AddBookForm(Book bookToEdit, bool isEditing)
        {
            InitializeComponent();
            this.isEditing = isEditing;
            NewBook = bookToEdit;

            if (isEditing)
            {
                textBoxTitle.Text = NewBook.Title;
                textBoxAuthor.Text = NewBook.Author;
                textBoxType.Text = NewBook.Type;
                textBoxYearOfCreation.Text = NewBook.YearOfCreation.ToString();
                textBoxNumberOfPages.Text = NewBook.NumberOfPages.ToString();
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Walidacja danych
                if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAuthor.Text) ||
                    string.IsNullOrWhiteSpace(textBoxType.Text) ||
                    !int.TryParse(textBoxYearOfCreation.Text, out int yearOfCreation) ||
                    !int.TryParse(textBoxNumberOfPages.Text, out int numberOfPages))
                {
                    MessageBox.Show("Please enter valid data in all fields.");
                    return;
                }

                NewBook.Title = textBoxTitle.Text;
                NewBook.Author = textBoxAuthor.Text;
                NewBook.Type = textBoxType.Text;
                NewBook.YearOfCreation = yearOfCreation;
                NewBook.NumberOfPages = numberOfPages;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the book:\n" + ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
