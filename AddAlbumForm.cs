using PP_PO.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PP_PO
{
    public partial class AddAlbumForm : Form
    {
        public MusicAlbum NewAlbum { get; private set; }
        private bool isEditing;

        public AddAlbumForm()
        {
            InitializeComponent();
            isEditing = false;
            InitializeForm();
        }

        public AddAlbumForm(MusicAlbum albumToEdit, bool isEditing)
        {
            InitializeComponent();
            this.isEditing = isEditing;
            NewAlbum = albumToEdit;
            InitializeForm();

            if (isEditing)
            {
                title.Text = NewAlbum.Name;
                author.Text = NewAlbum.Artist;
                yearOfCreation.Text = NewAlbum.YearOfCreation.ToString();
                genre.Text = NewAlbum.Genre.ToString();

                if (NewAlbum is VinylRecord vinylRecord)
                {
                    isVinyl.Checked = true;
                    rpm.Text = vinylRecord.RPM.ToString();
                    rpm.Enabled = true;
                }
                else
                {
                    isVinyl.Checked = false;
                    rpm.Text = string.Empty;
                    rpm.Enabled = false;
                }
            }
        }

        private void InitializeForm()
        {
            rpm.Enabled = false;
            isVinyl.CheckedChanged += CheckBoxVinyl_CheckedChanged;
        }

        private void CheckBoxVinyl_CheckedChanged(object sender, EventArgs e)
        {
            if (isVinyl.Checked)
            {
                rpm.Enabled = true;
            }
            else
            {
                rpm.Enabled = false;
                rpm.Text = string.Empty;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(title.Text) ||
                    string.IsNullOrWhiteSpace(author.Text) ||
                    string.IsNullOrWhiteSpace(genre.Text) ||
                    !int.TryParse(yearOfCreation.Text, out int year))
                {
                    MessageBox.Show("Please check data.");
                    return;
                }

                // Konwersja gatunku z tekstu na enum
                if (!Enum.TryParse<Genre>(genre.Text, true, out Genre selectedGenre))
                {
                    MessageBox.Show("Please enter proper genre");
                    return;
                }

                if (!isEditing)
                {
                    int newId = GenerateNewId();

                    if (isVinyl.Checked)
                    {
                        if (!int.TryParse(rpm.Text, out int roundsPerMinute))
                        {
                            MessageBox.Show("Please enter rpm.");
                            return;
                        }

                        NewAlbum = new VinylRecord(
                            id: newId,
                            name: title.Text,
                            year: year,
                            artist: author.Text,
                            genre: selectedGenre,
                            rpm: roundsPerMinute
                        );
                    }
                    else
                    {
                        NewAlbum = new MusicAlbum(
                            id: newId,
                            name: title.Text,
                            year: year,
                            artist: author.Text,
                            genre: selectedGenre
                        );
                    }
                }
                else
                {
                    NewAlbum.Name = title.Text;
                    NewAlbum.Artist = author.Text;
                    NewAlbum.YearOfCreation = year;
                    NewAlbum.Genre = selectedGenre;

                    if (isVinyl.Checked)
                    {
                        if (!int.TryParse(rpm.Text, out int roundsPerMinute))
                        {
                            MessageBox.Show("Please enter rpm.");
                            return;
                        }

                        if (NewAlbum is VinylRecord vinylRecord)
                        {
                            vinylRecord.RPM = roundsPerMinute;
                        }
                        else
                        {
                            NewAlbum = new VinylRecord(
                                id: NewAlbum.Id,
                                name: NewAlbum.Name,
                                year: NewAlbum.YearOfCreation,
                                artist: NewAlbum.Artist,
                                genre: NewAlbum.Genre,
                                rpm: roundsPerMinute
                            );
                        }
                    }
                    else
                    {
                        if (NewAlbum is VinylRecord)
                        {
                            NewAlbum = new MusicAlbum(
                                id: NewAlbum.Id,
                                name: NewAlbum.Name,
                                year: NewAlbum.YearOfCreation,
                                artist: NewAlbum.Artist,
                                genre: NewAlbum.Genre
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
