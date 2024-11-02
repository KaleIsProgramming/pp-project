using PP_PO.Models;

namespace PP_PO
{
    public partial class Form1 : Form
    {
        private List<Media> collectionOfMedia = new List<Media>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Utw�rz now� instancj� AddBookForm
            AddBookForm addBookForm = new AddBookForm();

            // Wy�wietl formularz jako okno modalne
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                // Je�li u�ytkownik klikn�� 'Save' i wszystko jest OK
                // Dodaj now� ksi��k� do kolekcji
                collectionOfMedia.Add(addBookForm.NewBook);

                // Zaktualizuj DataGridView
                UpdateDataGridView();
            }
        }

        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = collectionOfMedia;
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
    }
}
