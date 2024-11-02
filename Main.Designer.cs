namespace PP_PO
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            albums = new Button();
            books = new Button();
            films = new Button();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1201, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Music Albums List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Books List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 112);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Films List";
            // 
            // albums
            // 
            albums.Location = new Point(12, 42);
            albums.Name = "albums";
            albums.Size = new Size(104, 23);
            albums.TabIndex = 4;
            albums.Text = "Check it out!";
            albums.UseVisualStyleBackColor = true;
            albums.Click += albums_Click;
            // 
            // books
            // 
            books.Location = new Point(12, 86);
            books.Name = "books";
            books.Size = new Size(104, 23);
            books.TabIndex = 5;
            books.Text = "Check it out!";
            books.UseVisualStyleBackColor = true;
            books.Click += books_Click;
            // 
            // films
            // 
            films.Location = new Point(12, 130);
            films.Name = "films";
            films.Size = new Size(104, 23);
            films.TabIndex = 6;
            films.Text = "Check it out!";
            films.UseVisualStyleBackColor = true;
            films.Click += films_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 930);
            Controls.Add(films);
            Controls.Add(books);
            Controls.Add(albums);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button albums;
        private Button books;
        private Button films;
    }
}
