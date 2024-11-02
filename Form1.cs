using PP_PO.Models;

namespace PP_PO
{
    public partial class Form1 : Form
    {
        private List<Book> collectionOfBooks = new List<Book>();
        private List<Film> collectionOfFilms = new List<Film>();
        private List<MusicAlbum> collectionOfAlbums = new List<MusicAlbum>();
        public Form1()
        {
            InitializeComponent();
            booksGridView.AutoGenerateColumns = true;
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Utwórz now¹ instancjê AddBookForm
            AddBookForm addBookForm = new AddBookForm();

            // Wyœwietl formularz jako okno modalne
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                // Jeœli u¿ytkownik klikn¹³ 'Save' i wszystko jest OK
                // Dodaj now¹ ksi¹¿kê do kolekcji
                collectionOfBooks.Add(addBookForm.NewBook);

                // Zaktualizuj DataGridView
                UpdateDataGridView();
            }
        }

        private void addFilmToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            AddFilmForm addFilmForm = new AddFilmForm();
            if(addFilmForm.ShowDialog() == DialogResult.OK)
            {
                collectionOfFilms.Add(addFilmForm.NewFilm);
                UpdateDataGridView();
            }
        }

        private void UpdateDataGridView()
        {
            booksGridView.DataSource = null;
            booksGridView.DataSource = collectionOfBooks;
            filmsGridView.DataSource = null;
            filmsGridView.DataSource = collectionOfFilms;
            albumsGridView.DataSource = null;
            albumsGridView.DataSource = collectionOfAlbums;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
