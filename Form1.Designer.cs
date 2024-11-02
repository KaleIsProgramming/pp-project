namespace PP_PO
{
    partial class Form1
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            addBookToolStripMenuItem = new ToolStripMenuItem();
            addFilmToolStripMenuItem = new ToolStripMenuItem();
            addMusicToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            booksGridView = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            filmsGridView = new DataGridView();
            albumsGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)albumsGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, addToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(664, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBookToolStripMenuItem, addFilmToolStripMenuItem, addMusicToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(41, 20);
            addToolStripMenuItem.Text = "Add";
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(145, 22);
            addBookToolStripMenuItem.Text = "Book";
            addBookToolStripMenuItem.Click += addBookToolStripMenuItem_Click;
            // 
            // addFilmToolStripMenuItem
            // 
            addFilmToolStripMenuItem.Name = "addFilmToolStripMenuItem";
            addFilmToolStripMenuItem.Size = new Size(145, 22);
            addFilmToolStripMenuItem.Text = "Film";
            addFilmToolStripMenuItem.Click += addFilmToolStripMenuItem_Click;
            // 
            // addMusicToolStripMenuItem
            // 
            addMusicToolStripMenuItem.Name = "addMusicToolStripMenuItem";
            addMusicToolStripMenuItem.Size = new Size(145, 22);
            addMusicToolStripMenuItem.Text = "Music Album";
            addMusicToolStripMenuItem.Click += addAlbumToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // booksGridView
            // 
            booksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksGridView.Location = new Point(93, 54);
            booksGridView.Name = "booksGridView";
            booksGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            booksGridView.Size = new Size(556, 382);
            booksGridView.TabIndex = 1;
            booksGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 83);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 112);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 54);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // filmsGridView
            // 
            filmsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filmsGridView.Location = new Point(93, 442);
            filmsGridView.Name = "filmsGridView";
            filmsGridView.Size = new Size(556, 382);
            filmsGridView.StandardTab = true;
            filmsGridView.TabIndex = 5;
            // 
            // albumsGridView
            // 
            albumsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            albumsGridView.Location = new Point(93, 830);
            albumsGridView.Name = "albumsGridView";
            albumsGridView.Size = new Size(556, 382);
            albumsGridView.TabIndex = 6;
            albumsGridView.CellContentClick += dataGridView3_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 509);
            Controls.Add(albumsGridView);
            Controls.Add(filmsGridView);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(booksGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)booksGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)albumsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem addFilmToolStripMenuItem;
        private ToolStripMenuItem addMusicToolStripMenuItem;
        private DataGridView booksGridView;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView filmsGridView;
        private DataGridView albumsGridView;
    }
}
