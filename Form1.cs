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
            // Utwórz now¹ instancjê AddBookForm
            AddBookForm addBookForm = new AddBookForm();

            // Wyœwietl formularz jako okno modalne
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                // Jeœli u¿ytkownik klikn¹³ 'Save' i wszystko jest OK
                // Dodaj now¹ ksi¹¿kê do kolekcji
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
