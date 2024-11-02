using System;
using System.Windows.Forms;
using PP_PO.Models; // Dodaj ten using, aby uzyskać dostęp do klasy Book

namespace PP_PO
{
    public partial class AddBookForm : Form
    {
        public Book NewBook { get; private set; }

        public AddBookForm()
        {
            InitializeComponent();
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

                // Tworzenie nowej książki
                NewBook = new Book
                {
                    Title = textBoxTitle.Text,
                    Author = textBoxAuthor.Text,
                    YearOfCreation = yearOfCreation,
                    NumberOfPages = numberOfPages,
                    Type = textBoxType.Text
                };
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
