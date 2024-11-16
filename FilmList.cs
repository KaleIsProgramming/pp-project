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
    public partial class FilmList : Form
    {
        private List<Media> mediaList = new List<Media>();
        private List<Film> collectionOfFilms = new List<Film>();
        public FilmList()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadFromFile();
        }

        private void UpdateDataGridView()
        {
            FilmGridView.DataSource = null;
            FilmGridView.DataSource = new BindingList<Film>(collectionOfFilms);
        }

        private void addFilm_Click(object sender, EventArgs e)
        {
            AddFilmForm addFilmForm = new AddFilmForm();

            if (addFilmForm.ShowDialog() == DialogResult.OK)
            {
                Film newFilm = addFilmForm.NewFilm;
                mediaList.Add(newFilm);
                collectionOfFilms.Add(newFilm);
                MediaDataAccess.SaveMediaList(mediaList);
                UpdateDataGridView();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (FilmGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in FilmGridView.SelectedRows)
                {
                    Film selectedFilm = (Film)row.DataBoundItem;

                    AddFilmForm editFilmForm = new AddFilmForm(selectedFilm, true);

                    if (editFilmForm.ShowDialog() == DialogResult.OK)
                    {
                        Film editedFilm = editFilmForm.NewFilm;

                        int index = mediaList.IndexOf(selectedFilm);
                        if (index >= 0)
                        {
                            mediaList[index] = editedFilm;
                        }

                        int filmIndex = collectionOfFilms.IndexOf(selectedFilm);
                        if (filmIndex >= 0)
                        {
                            collectionOfFilms[filmIndex] = editedFilm;
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
            if (FilmGridView.SelectedRows.Count > 0)
            {
                List<Film> filmsToRemove = new List<Film>();
                foreach (DataGridViewRow row in FilmGridView.SelectedRows)
                {
                    Film selectedFilm = (Film)row.DataBoundItem;
                    filmsToRemove.Add(selectedFilm);
                }
                foreach (Film film in filmsToRemove)
                {
                    collectionOfFilms.Remove(film);
                    mediaList.Remove(film);
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
            collectionOfFilms = mediaList.OfType<Film>().ToList();
            UpdateDataGridView();
        }

        private void SetupDataGridView()
        {
            FilmGridView.AutoGenerateColumns = false;
            FilmGridView.Columns.Clear();

            FilmGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Title"
            });
            FilmGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Director",
                HeaderText = "Director"
            });
            FilmGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "YearOfCreation",
                HeaderText = "Year of creation"
            });

            FilmGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Genre",
                HeaderText = "Genre"
            });

            FilmGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StuntCoordinator",
                HeaderText = "Stunt coordinator"
            });

            FilmGridView.CellFormatting += FilmGridView_CellFormatting;
        }

        private void FilmGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (FilmGridView.Columns[e.ColumnIndex].DataPropertyName == "StuntCoordinator")
            {
                var book = FilmGridView.Rows[e.RowIndex].DataBoundItem as Film;
                if (book is ActionFilm actionFilm)
                {
                    e.Value = actionFilm.StuntCoordinator;
                }
                else
                {
                    e.Value = string.Empty;
                }
            }
        }

        private void DataGridViewFilms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Film selectedFilm = collectionOfFilms[e.RowIndex];

                selectedFilm.DisplayInfo();
            }
        }

        private void DataGridView_CellEnterClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Film selectedFilm = collectionOfFilms[e.RowIndex];

                selectedFilm.Play();
            }
        }
    }
}
