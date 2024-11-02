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
    public partial class AddFilmForm : Form
    {
        public Film NewFilm { get; private set; }
        public AddFilmForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(title.Text) ||
                   string.IsNullOrWhiteSpace(author.Text)||
                   string.IsNullOrWhiteSpace(director.Text)||
                   !int.TryParse(duration.Text, out int filmDuration)||
                   !int.TryParse(yearOfCreation.Text,out int filmYearOfCreation))
                {
                    MessageBox.Show("Please enter valid data in all fields.");
                    return;
                }

                NewFilm = new Film
                {
                    Author = author.Text,
                    Title = title.Text,
                    Director = director.Text,
                    Duration = filmDuration,
                    YearOfCreation = filmYearOfCreation,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the film:\n" + ex.Message);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void labelType_Click(object sender, EventArgs e)
        {

        }
    }
}
