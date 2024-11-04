namespace PP_PO
{
    partial class AddFilmForm
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
            stuntCoordinator = new TextBox();
            yearOfCreation = new TextBox();
            textBoxGenre = new TextBox();
            director = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            checkBoxActionFilm = new CheckBox();
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
            labelAuthor.Location = new Point(30, 229);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(102, 15);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "Stunt Coordinator";
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
            labelType.Location = new Point(34, 69);
            labelType.Name = "labelType";
            labelType.Size = new Size(49, 15);
            labelType.TabIndex = 8;
            labelType.Text = "Director";
            labelType.Click += labelType_Click;
            // 
            // title
            // 
            title.Location = new Point(150, 27);
            title.Name = "title";
            title.Size = new Size(200, 23);
            title.TabIndex = 1;
            // 
            // stuntCoordinator
            // 
            stuntCoordinator.Location = new Point(150, 229);
            stuntCoordinator.Name = "stuntCoordinator";
            stuntCoordinator.Size = new Size(200, 23);
            stuntCoordinator.TabIndex = 3;
            // 
            // yearOfCreation
            // 
            yearOfCreation.Location = new Point(150, 107);
            yearOfCreation.Name = "yearOfCreation";
            yearOfCreation.Size = new Size(200, 23);
            yearOfCreation.TabIndex = 5;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(150, 147);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(200, 23);
            textBoxGenre.TabIndex = 7;
            // 
            // director
            // 
            director.Location = new Point(150, 69);
            director.Name = "director";
            director.Size = new Size(200, 23);
            director.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(150, 270);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(275, 270);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // checkBoxActionFilm
            // 
            checkBoxActionFilm.AutoSize = true;
            checkBoxActionFilm.Location = new Point(150, 190);
            checkBoxActionFilm.Name = "checkBoxActionFilm";
            checkBoxActionFilm.Size = new Size(87, 19);
            checkBoxActionFilm.TabIndex = 12;
            checkBoxActionFilm.Text = "Action Film";
            checkBoxActionFilm.UseVisualStyleBackColor = true;
            // 
            // AddFilmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 327);
            Controls.Add(checkBoxActionFilm);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(director);
            Controls.Add(labelType);
            Controls.Add(textBoxGenre);
            Controls.Add(labelNumberOfPages);
            Controls.Add(yearOfCreation);
            Controls.Add(labelYearOfCreation);
            Controls.Add(stuntCoordinator);
            Controls.Add(labelAuthor);
            Controls.Add(title);
            Controls.Add(labelTitle);
            Name = "AddFilmForm";
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
        private System.Windows.Forms.TextBox stuntCoordinator;
        private System.Windows.Forms.TextBox yearOfCreation;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox director;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private CheckBox checkBoxActionFilm;
    }
}
