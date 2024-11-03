using System;
using System.Linq;
using System.Windows.Forms;
using PP_PO.Models;

namespace PP_PO
{
    public partial class AddBookForm : Form
    {
        public Book NewBook { get; private set; }
        private bool isEditing;

        public AddBookForm()
        {
            InitializeComponent();
            isEditing = false;
            InitializeForm();
        }

        public AddBookForm(Book bookToEdit, bool isEditing)
        {
            InitializeComponent();
            this.isEditing = isEditing;
            NewBook = bookToEdit;
            InitializeForm();

            if (isEditing)
            {
                textBoxTitle.Text = NewBook.Name;
                textBoxAuthor.Text = NewBook.Author;
                textBoxYearOfCreation.Text = NewBook.YearOfCreation.ToString();

                if (NewBook is EBook ebook)
                {
                    checkBoxIsEBook.Checked = true;
                    textBoxEBook.Text = ebook.FileFormat;
                    textBoxEBook.Enabled = true;
                }
                else
                {
                    checkBoxIsEBook.Checked = false;
                    textBoxEBook.Text = string.Empty;
                    textBoxEBook.Enabled = false;
                }
            }
        }

        private void InitializeForm()
        {
            textBoxEBook.Enabled = false;

            checkBoxIsEBook.CheckedChanged += CheckBoxIsEBook_CheckedChanged;
        }

        private void CheckBoxIsEBook_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsEBook.Checked)
            {
                textBoxEBook.Enabled = true;
            }
            else
            {
                textBoxEBook.Enabled = false;
                textBoxEBook.Text = string.Empty;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAuthor.Text) ||
                    !int.TryParse(textBoxYearOfCreation.Text, out int year))
                {
                    MessageBox.Show("Please enter valid values.");
                    return;
                }

                if (!isEditing)
                {
                    int newId = GenerateNewId();

                    if (checkBoxIsEBook.Checked)
                    {
                        if (string.IsNullOrWhiteSpace(textBoxEBook.Text))
                        {
                            MessageBox.Show("Please enter EBook format.");
                            return;
                        }

                        NewBook = new EBook(
                            id: newId,
                            name: textBoxTitle.Text,
                            year: year,
                            author: textBoxAuthor.Text,
                            fileFormat: textBoxEBook.Text
                        );
                    }
                    else
                    {
                        NewBook = new Book(
                            id: newId,
                            name: textBoxTitle.Text,
                            year: year,
                            author: textBoxAuthor.Text
                        );
                    }
                }
                else
                {
                    NewBook.Name = textBoxTitle.Text;
                    NewBook.Author = textBoxAuthor.Text;
                    NewBook.YearOfCreation = year;

                    if (checkBoxIsEBook.Checked)
                    {
                        if (string.IsNullOrWhiteSpace(textBoxEBook.Text))
                        {
                            MessageBox.Show("Please enter EBook format.");
                            return;
                        }

                        if (NewBook is EBook ebook)
                        {
                            ebook.FileFormat = textBoxEBook.Text;
                        }
                        else
                        {
                            NewBook = new EBook(
                                id: NewBook.Id,
                                name: NewBook.Name,
                                year: NewBook.YearOfCreation,
                                author: NewBook.Author,
                                fileFormat: textBoxEBook.Text
                            );
                        }
                    }
                    else
                    {
                        if (NewBook is EBook)
                        {
                            NewBook = new Book(
                                id: NewBook.Id,
                                name: NewBook.Name,
                                year: NewBook.YearOfCreation,
                                author: NewBook.Author
                            );
                        }
                    }
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while saving:\n" + ex.Message);
            }
        }

        private int GenerateNewId()
        {
            var mediaList = MediaDataAccess.LoadMediaList();
            if (mediaList.Any())
            {
                return mediaList.Max(m => m.Id) + 1;
            }
            else
            {
                return 1;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void labelNumberOfPages_Click(object sender, EventArgs e)
        {

        }
    }
}
