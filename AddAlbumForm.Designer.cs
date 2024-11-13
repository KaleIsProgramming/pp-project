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
            genre = new TextBox();
            rpm = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            isVinyl = new CheckBox();
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
            labelNumberOfPages.Size = new Size(38, 15);
            labelNumberOfPages.TabIndex = 6;
            labelNumberOfPages.Text = "Genre";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(30, 240);
            labelType.Name = "labelType";
            labelType.Size = new Size(32, 15);
            labelType.TabIndex = 8;
            labelType.Text = "RPM";
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
            // genre
            // 
            genre.Location = new Point(150, 147);
            genre.Name = "genre";
            genre.Size = new Size(200, 23);
            genre.TabIndex = 7;
            // 
            // rpm
            // 
            rpm.Location = new Point(150, 237);
            rpm.Name = "rpm";
            rpm.Size = new Size(200, 23);
            rpm.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(150, 288);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(275, 288);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // isVinyl
            // 
            isVinyl.AutoSize = true;
            isVinyl.Location = new Point(150, 194);
            isVinyl.Name = "isVinyl";
            isVinyl.Size = new Size(68, 19);
            isVinyl.TabIndex = 12;
            isVinyl.Text = "Is Vinyl?";
            isVinyl.UseVisualStyleBackColor = true;
            // 
            // AddAlbumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 323);
            Controls.Add(isVinyl);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(rpm);
            Controls.Add(labelType);
            Controls.Add(genre);
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
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.TextBox rpm;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private CheckBox isVinyl;
    }
}
