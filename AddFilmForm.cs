using PP_PO.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PP_PO
{
    public partial class AddFilmForm : Form
    {
        public Film NewFilm { get; private set; }
        private bool isEditing;

        public AddFilmForm()
        {
            InitializeComponent();
            isEditing = false;
            InitializeForm();
        }

        public AddFilmForm(Film filmToEdit, bool isEditing)
        {
            InitializeComponent();
            this.isEditing = isEditing;
            NewFilm = filmToEdit;
            InitializeForm();

            if (isEditing)
            {
                title.Text = NewFilm.Name;
                director.Text = NewFilm.Director;
                yearOfCreation.Text = NewFilm.YearOfCreation.ToString();
                textBoxGenre.Text = NewFilm.Genre.ToString();

                if (NewFilm is ActionFilm actionFilm)
                {
                    checkBoxActionFilm.Checked = true;
                    stuntCoordinator.Text = actionFilm.StuntCoordinator;
                    stuntCoordinator.Enabled = true;
                }
                else
                {
                    checkBoxActionFilm.Checked = false;
                    stuntCoordinator.Text = string.Empty;
                    stuntCoordinator.Enabled = false;
                }
            }
        }

        private void InitializeForm()
        {
            stuntCoordinator.Enabled = false;
            checkBoxActionFilm.CheckedChanged += CheckBoxActionFilm_CheckedChanged;
        }

        private void CheckBoxActionFilm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActionFilm.Checked)
            {
                stuntCoordinator.Enabled = true;
            }
            else
            {
                stuntCoordinator.Enabled = false;
                stuntCoordinator.Text = string.Empty;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(title.Text) ||
                    string.IsNullOrWhiteSpace(director.Text) ||
                    string.IsNullOrWhiteSpace(textBoxGenre.Text) ||
                    !int.TryParse(yearOfCreation.Text, out int year))
                {
                    MessageBox.Show("Please check data.");
                    return;
                }

                // Konwersja gatunku z tekstu na enum
                if (!Enum.TryParse<Genre>(textBoxGenre.Text, true, out Genre genre))
                {
                    MessageBox.Show("Please enter proper genre");
                    return;
                }

                if (!isEditing)
                {
                    int newId = GenerateNewId();

                    if (checkBoxActionFilm.Checked)
                    {
                        if (string.IsNullOrWhiteSpace(stuntCoordinator.Text))
                        {
                            MessageBox.Show("Please enter stunt coordinator.");
                            return;
                        }

                        NewFilm = new ActionFilm(
                            id: newId,
                            name: title.Text,
                            year: year,
                            director: director.Text,
                            genre: genre,
                            stuntCoordinator: stuntCoordinator.Text
                        );
                    }
                    else
                    {
                        NewFilm = new RegularFilm(
                            id: newId,
                            name: title.Text,
                            year: year,
                            director: director.Text,
                            genre: genre
                        );
                    }
                }
                else
                {
                    NewFilm.Name = title.Text;
                    NewFilm.Director = director.Text;
                    NewFilm.YearOfCreation = year;
                    NewFilm.Genre = genre;

                    if (checkBoxActionFilm.Checked)
                    {
                        if (string.IsNullOrWhiteSpace(stuntCoordinator.Text))
                        {
                            MessageBox.Show("Please enter stunt coordinator.");
                            return;
                        }

                        if (NewFilm is ActionFilm actionFilm)
                        {
                            actionFilm.StuntCoordinator = stuntCoordinator.Text;
                        }
                        else
                        {
                            NewFilm = new ActionFilm(
                                id: NewFilm.Id,
                                name: NewFilm.Name,
                                year: NewFilm.YearOfCreation,
                                director: NewFilm.Director,
                                genre: NewFilm.Genre,
                                stuntCoordinator: stuntCoordinator.Text
                            );
                        }
                    }
                    else
                    {
                        if (NewFilm is ActionFilm)
                        {
                            NewFilm = new RegularFilm(
                                id: NewFilm.Id,
                                name: NewFilm.Name,
                                year: NewFilm.YearOfCreation,
                                director: NewFilm.Director,
                                genre: NewFilm.Genre
                            );
                        }
                    }
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania:\n" + ex.Message);
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

        private void labelType_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
