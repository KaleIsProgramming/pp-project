namespace PP_PO
{
    partial class MusicAlbumsList
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
            MusicAlbumGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)MusicAlbumGridView).BeginInit();
            SuspendLayout();
            // 
            // Refresh
            // 
            Refresh.Location = new Point(13, 70);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(75, 23);
            Refresh.TabIndex = 10;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.Location = new Point(13, 12);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 9;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += addAlbum_Click;
            // 
            // Edit
            // 
            Edit.Location = new Point(13, 41);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 23);
            Edit.TabIndex = 8;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.Location = new Point(13, 99);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 7;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // MusicAlbumGridView
            // 
            MusicAlbumGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MusicAlbumGridView.Location = new Point(94, 12);
            MusicAlbumGridView.Name = "MusicAlbumGridView";
            MusicAlbumGridView.Size = new Size(666, 370);
            MusicAlbumGridView.TabIndex = 6;
            // 
            // MusicAlbumsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 396);
            Controls.Add(Refresh);
            Controls.Add(Add);
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(MusicAlbumGridView);
            Name = "MusicAlbumsList";
            Text = "Music Album List";
            ((System.ComponentModel.ISupportInitialize)MusicAlbumGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Refresh;
        private Button Add;
        private Button Edit;
        private Button Delete;
        private DataGridView MusicAlbumGridView;
    }
}