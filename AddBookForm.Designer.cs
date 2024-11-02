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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelYearOfCreation = new System.Windows.Forms.Label();
            this.labelNumberOfPages = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxYearOfCreation = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfPages = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(30, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(31, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(150, 27);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(200, 23);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(30, 70);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(45, 15);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(150, 67);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(200, 23);
            this.textBoxAuthor.TabIndex = 3;
            // 
            // labelYearOfCreation
            // 
            this.labelYearOfCreation.AutoSize = true;
            this.labelYearOfCreation.Location = new System.Drawing.Point(30, 110);
            this.labelYearOfCreation.Name = "labelYearOfCreation";
            this.labelYearOfCreation.Size = new System.Drawing.Size(95, 15);
            this.labelYearOfCreation.TabIndex = 4;
            this.labelYearOfCreation.Text = "Year of Creation";
            // 
            // textBoxYearOfCreation
            // 
            this.textBoxYearOfCreation.Location = new System.Drawing.Point(150, 107);
            this.textBoxYearOfCreation.Name = "textBoxYearOfCreation";
            this.textBoxYearOfCreation.Size = new System.Drawing.Size(200, 23);
            this.textBoxYearOfCreation.TabIndex = 5;
            // 
            // labelNumberOfPages
            // 
            this.labelNumberOfPages.AutoSize = true;
            this.labelNumberOfPages.Location = new System.Drawing.Point(30, 150);
            this.labelNumberOfPages.Name = "labelNumberOfPages";
            this.labelNumberOfPages.Size = new System.Drawing.Size(100, 15);
            this.labelNumberOfPages.TabIndex = 6;
            this.labelNumberOfPages.Text = "Number of Pages";
            // 
            // textBoxNumberOfPages
            // 
            this.textBoxNumberOfPages.Location = new System.Drawing.Point(150, 147);
            this.textBoxNumberOfPages.Name = "textBoxNumberOfPages";
            this.textBoxNumberOfPages.Size = new System.Drawing.Size(200, 23);
            this.textBoxNumberOfPages.TabIndex = 7;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(30, 190);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(33, 15);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Type";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(150, 187);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(200, 23);
            this.textBoxType.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(150, 230);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(275, 230);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxNumberOfPages);
            this.Controls.Add(this.labelNumberOfPages);
            this.Controls.Add(this.textBoxYearOfCreation);
            this.Controls.Add(this.labelYearOfCreation);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "AddBookForm";
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelYearOfCreation;
        private System.Windows.Forms.Label labelNumberOfPages;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxYearOfCreation;
        private System.Windows.Forms.TextBox textBoxNumberOfPages;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
