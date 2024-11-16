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
    public partial class MusicAlbumsList : Form
    {
        private List<Media> mediaList = new List<Media>();
        private List<MusicAlbum> collectionOfAlbums = new List<MusicAlbum>();
        public MusicAlbumsList()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadFromFile();
        }

        private void UpdateDataGridView()
        {
            MusicAlbumGridView.DataSource = null;
            MusicAlbumGridView.DataSource = new BindingList<MusicAlbum>(collectionOfAlbums);
        }

        private void addAlbum_Click(object sender, EventArgs e)
        {
            AddAlbumForm addAlbumForm = new AddAlbumForm();

            if (addAlbumForm.ShowDialog() == DialogResult.OK)
            {
                MusicAlbum newAlbum = addAlbumForm.NewAlbum;
                mediaList.Add(newAlbum);
                collectionOfAlbums.Add(newAlbum);
                MediaDataAccess.SaveMediaList(mediaList);
                UpdateDataGridView();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (MusicAlbumGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in MusicAlbumGridView.SelectedRows)
                {
                    MusicAlbum selectedAlbum = (MusicAlbum)row.DataBoundItem;

                    AddAlbumForm editAlbumForm = new AddAlbumForm(selectedAlbum, true);

                    if (editAlbumForm.ShowDialog() == DialogResult.OK)
                    {
                        MusicAlbum editedAlbum = editAlbumForm.NewAlbum;

                        int index = mediaList.IndexOf(selectedAlbum);
                        if (index >= 0)
                        {
                            mediaList[index] = editedAlbum;
                        }

                        int albumIndex = collectionOfAlbums.IndexOf(selectedAlbum);
                        if (albumIndex >= 0)
                        {
                            collectionOfAlbums[albumIndex] = editedAlbum;
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
            if (MusicAlbumGridView.SelectedRows.Count > 0)
            {
                List<MusicAlbum>AlbumsToRemove = new List<MusicAlbum>();
                foreach (DataGridViewRow row in MusicAlbumGridView.SelectedRows)
                {
                    MusicAlbum selectedFilm = (MusicAlbum)row.DataBoundItem;
                    AlbumsToRemove.Add(selectedFilm);
                }
                foreach (MusicAlbum album in AlbumsToRemove)
                {
                    collectionOfAlbums.Remove(album);
                    mediaList.Remove(album);
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
            collectionOfAlbums = mediaList.OfType<MusicAlbum>().ToList();
            UpdateDataGridView();
        }

        private void SetupDataGridView()
        {
            MusicAlbumGridView.AutoGenerateColumns = false;
            MusicAlbumGridView.Columns.Clear();

            MusicAlbumGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Title"
            });
            MusicAlbumGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Director",
                HeaderText = "Director"
            });
            MusicAlbumGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "YearOfCreation",
                HeaderText = "Year of creation"
            });

            MusicAlbumGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Genre",
                HeaderText = "Genre"
            });

            MusicAlbumGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RPM",
                HeaderText = "RPM"
            });

            MusicAlbumGridView.CellFormatting += AlbumGridView_CellFormatting;
        }

        private void AlbumGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (MusicAlbumGridView.Columns[e.ColumnIndex].DataPropertyName == "RPM")
            {
                var book = MusicAlbumGridView.Rows[e.RowIndex].DataBoundItem as MusicAlbum;
                if (book is VinylRecord vinyl)
                {
                    e.Value = vinyl.RPM;
                }
                else
                {
                    e.Value = string.Empty;
                }
            }
        }

        private void DataGridViewAlbums_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MusicAlbum selectedAlbum = collectionOfAlbums[e.RowIndex];

                selectedAlbum.DisplayInfo();
            }
        }
    }
}
