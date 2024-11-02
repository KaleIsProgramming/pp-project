namespace PP_PO
{
    partial class AddAlbumForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Oczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">Prawda, jeśli zarządzane zasoby powinny zostać usunięte; w przeciwnym razie fałsz.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta Windows Forms

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie modyfikuj
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelAuthor = new Label();
            labelYearOfCreation = new Label();
            labelNumberOfPages = new Label();
            labelType = new Label();
            title = new TextBox();
            author = new TextBox();
            yearOfCreation = new TextBox();
            numOfSongs = new TextBox();
            producer = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(30, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(29, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(30, 70);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(44, 15);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "Author";
            // 
            // labelYearOfCreation
            // 
            labelYearOfCreation.AutoSize = true;
            labelYearOfCreation.Location = new Point(30, 110);
            labelYearOfCreation.Name = "labelYearOfCreation";
            labelYearOfCreation.Size = new Size(91, 15);
            labelYearOfCreation.TabIndex = 4;
            labelYearOfCreation.Text = "Year of Creation";
            // 
            // labelNumberOfPages
            // 
            labelNumberOfPages.AutoSize = true;
            labelNumberOfPages.Location = new Point(30, 150);
            labelNumberOfPages.Name = "labelNumberOfPages";
            labelNumberOfPages.Size = new Size(99, 15);
            labelNumberOfPages.TabIndex = 6;
            labelNumberOfPages.Text = "Number of songs";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(30, 190);
            labelType.Name = "labelType";
            labelType.Size = new Size(55, 15);
            labelType.TabIndex = 8;
            labelType.Text = "Producer";
            // 
            // title
            // 
            title.Location = new Point(150, 27);
            title.Name = "title";
            title.Size = new Size(200, 23);
            title.TabIndex = 1;
            // 
            // author
            // 
            author.Location = new Point(150, 67);
            author.Name = "author";
            author.Size = new Size(200, 23);
            author.TabIndex = 3;
            // 
            // yearOfCreation
            // 
            yearOfCreation.Location = new Point(150, 107);
            yearOfCreation.Name = "yearOfCreation";
            yearOfCreation.Size = new Size(200, 23);
            yearOfCreation.TabIndex = 5;
            // 
            // numOfSongs
            // 
            numOfSongs.Location = new Point(150, 147);
            numOfSongs.Name = "numOfSongs";
            numOfSongs.Size = new Size(200, 23);
            numOfSongs.TabIndex = 7;
            // 
            // producer
            // 
            producer.Location = new Point(150, 187);
            producer.Name = "producer";
            producer.Size = new Size(200, 23);
            producer.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(150, 230);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(275, 230);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_click;
            // 
            // AddAlbumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 281);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(producer);
            Controls.Add(labelType);
            Controls.Add(numOfSongs);
            Controls.Add(labelNumberOfPages);
            Controls.Add(yearOfCreation);
            Controls.Add(labelYearOfCreation);
            Controls.Add(author);
            Controls.Add(labelAuthor);
            Controls.Add(title);
            Controls.Add(labelTitle);
            Name = "AddAlbumForm";
            Text = "Add Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelYearOfCreation;
        private System.Windows.Forms.Label labelNumberOfPages;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox yearOfCreation;
        private System.Windows.Forms.TextBox numOfSongs;
        private System.Windows.Forms.TextBox producer;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
