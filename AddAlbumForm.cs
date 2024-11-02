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
    public partial class AddAlbumForm : Form
    {
        public MusicAlbum NewMusicAlbum { get; private set; }
        public AddAlbumForm()
        {
            InitializeComponent();
        }

        private void buttonSave_click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(title.Text) ||
                    string.IsNullOrWhiteSpace(author.Text) ||
                    string.IsNullOrWhiteSpace(producer.Text) ||
                    !int.TryParse(numOfSongs.Text, out int numberOfSongs) ||
                    !int.TryParse(yearOfCreation.Text, out int albumYearOfCreation))
                {
                    MessageBox.Show("Please enter valid data in all fields.");
                    return;
                }

                NewMusicAlbum = new MusicAlbum
                {
                    Title = title.Text,
                    Author = author.Text,
                    Producer = producer.Text,
                    NumOfSongs = numberOfSongs,
                    YearOfCreation = albumYearOfCreation
                };
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred while saving the film:\n" + ex.Message);
            }

                
            DialogResult = DialogResult.OK;
            Close();
        }   

        private void buttonCancel_click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
