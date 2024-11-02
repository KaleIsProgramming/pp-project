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
        private List<Film> collectionOfFilms = new List<Film>();
        public FilmList()
        {
            InitializeComponent();
            FilmGridView.AutoGenerateColumns = true;
        }

        private void UpdateDataGridView()
        {
            FilmGridView.DataSource = null;
            FilmGridView.DataSource = collectionOfFilms;
        }

        private void addFilm_Click(Object sender, EventArgs e)
        {
            AddFilmForm addFilmForm = new AddFilmForm();
            if (addFilmForm.ShowDialog() == DialogResult.OK)
            {
                collectionOfFilms.Add(addFilmForm.NewFilm);
                UpdateDataGridView();
            }
        }
    }
}
