namespace PP_PO
{
    partial class AddBookForm
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
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxYearOfCreation = new TextBox();
            textBoxEBook = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            checkBoxIsEBook = new CheckBox();
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
            labelNumberOfPages.Location = new Point(30, 169);
            labelNumberOfPages.Name = "labelNumberOfPages";
            labelNumberOfPages.Size = new Size(64, 15);
            labelNumberOfPages.TabIndex = 6;
            labelNumberOfPages.Text = "File format";
            labelNumberOfPages.Click += labelNumberOfPages_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(150, 27);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(200, 23);
            textBoxTitle.TabIndex = 1;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(150, 67);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(200, 23);
            textBoxAuthor.TabIndex = 3;
            // 
            // textBoxYearOfCreation
            // 
            textBoxYearOfCreation.Location = new Point(150, 107);
            textBoxYearOfCreation.Name = "textBoxYearOfCreation";
            textBoxYearOfCreation.Size = new Size(200, 23);
            textBoxYearOfCreation.TabIndex = 5;
            // 
            // textBoxEBook
            // 
            textBoxEBook.Location = new Point(150, 161);
            textBoxEBook.Name = "textBoxEBook";
            textBoxEBook.Size = new Size(200, 23);
            textBoxEBook.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(150, 230);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(275, 230);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // checkBoxIsEBook
            // 
            checkBoxIsEBook.AutoSize = true;
            checkBoxIsEBook.Location = new Point(150, 136);
            checkBoxIsEBook.Name = "checkBoxIsEBook";
            checkBoxIsEBook.Size = new Size(75, 19);
            checkBoxIsEBook.TabIndex = 12;
            checkBoxIsEBook.Text = "Is Ebook?";
            checkBoxIsEBook.UseVisualStyleBackColor = true;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 281);
            Controls.Add(checkBoxIsEBook);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxEBook);
            Controls.Add(labelNumberOfPages);
            Controls.Add(textBoxYearOfCreation);
            Controls.Add(labelYearOfCreation);
            Controls.Add(textBoxAuthor);
            Controls.Add(labelAuthor);
            Controls.Add(textBoxTitle);
            Controls.Add(labelTitle);
            Name = "AddBookForm";
            Text = "Add Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelYearOfCreation;
        private System.Windows.Forms.Label labelNumberOfPages;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxYearOfCreation;
        private System.Windows.Forms.TextBox textBoxEBook;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private CheckBox checkBoxIsEBook;
    }
}
