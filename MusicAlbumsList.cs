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
        private List<MusicAlbum> collectionOfAlbums = new List<MusicAlbum>();
        public MusicAlbumsList()
        {
            InitializeComponent();
            MusicAlbumGridView.AutoGenerateColumns = true;
        }

        private void UpdateDataGridView()
        {
            MusicAlbumGridView.DataSource = null;
            MusicAlbumGridView.DataSource = collectionOfAlbums;
        }

        private void addAlbum_Click(Object sender, EventArgs e)
        {
            AddAlbumForm addAlbumForm = new AddAlbumForm();
            if (addAlbumForm.ShowDialog() == DialogResult.OK)
            {
                collectionOfAlbums.Add(addAlbumForm.NewMusicAlbum);
                UpdateDataGridView();
            }
        }

    }
}
