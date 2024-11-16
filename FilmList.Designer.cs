namespace PP_PO
{
    partial class FilmList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Refresh = new Button();
            Add = new Button();
            Edit = new Button();
            Delete = new Button();
            FilmGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)FilmGridView).BeginInit();
            SuspendLayout();
            // 
            // Refresh
            // 
            Refresh.Location = new Point(18, 70);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(75, 23);
            Refresh.TabIndex = 10;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Add
            // 
            Add.Location = new Point(18, 12);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 9;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += addFilm_Click;
            // 
            // Edit
            // 
            Edit.Location = new Point(18, 41);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 23);
            Edit.TabIndex = 8;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(18, 99);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 7;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // FilmGridView
            // 
            FilmGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FilmGridView.Location = new Point(99, 12);
            FilmGridView.Name = "FilmGridView";
            FilmGridView.Size = new Size(632, 370);
            FilmGridView.TabIndex = 6;
            FilmGridView.CellContentClick += DataGridView_CellEnterClick;
            FilmGridView.CellDoubleClick += DataGridViewFilms_CellDoubleClick;
            // 
            // FilmList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 399);
            Controls.Add(Refresh);
            Controls.Add(Add);
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(FilmGridView);
            Name = "FilmList";
            Text = "Film List";
            ((System.ComponentModel.ISupportInitialize)FilmGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Refresh;
        private Button Add;
        private Button Edit;
        private Button Delete;
        private DataGridView FilmGridView;
    }
}