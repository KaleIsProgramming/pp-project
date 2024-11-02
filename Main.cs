using PP_PO.Models;

namespace PP_PO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void albums_Click(object sender, EventArgs e)
        {
            MusicAlbumsList AlbumListForm = new MusicAlbumsList();
            AlbumListForm.ShowDialog();
        }

        private void books_Click(object sender, EventArgs e)
        {
            BooksList NewBooksList = new BooksList();
            NewBooksList.ShowDialog();
        }

        private void films_Click(object sender, EventArgs e)
        {
            FilmList NewFilmList = new FilmList();
            NewFilmList.ShowDialog();
        }
    }
}
