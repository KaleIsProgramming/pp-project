namespace PP_PO
{
    partial class BooksList
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
            BooksGridView = new DataGridView();
            Delete = new Button();
            Edit = new Button();
            Add = new Button();
            Refresh = new Button();
            Return = new Button();
            ((System.ComponentModel.ISupportInitialize)BooksGridView).BeginInit();
            SuspendLayout();
            // 
            // BooksGridView
            // 
            BooksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BooksGridView.Location = new Point(93, 12);
            BooksGridView.Name = "BooksGridView";
            BooksGridView.Size = new Size(622, 370);
            BooksGridView.TabIndex = 0;
            // 
            // Delete
            // 
            Delete.Location = new Point(12, 99);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 1;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            Edit.Location = new Point(12, 41);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 23);
            Edit.TabIndex = 2;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.Location = new Point(12, 12);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 3;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += addBook_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(12, 70);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(75, 23);
            Refresh.TabIndex = 4;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            Return.Location = new Point(12, 128);
            Return.Name = "Return";
            Return.Size = new Size(75, 23);
            Return.TabIndex = 5;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = true;
            // 
            // BooksList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 434);
            Controls.Add(Return);
            Controls.Add(Refresh);
            Controls.Add(Add);
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(BooksGridView);
            Name = "BooksList";
            Text = "BooksList";
            ((System.ComponentModel.ISupportInitialize)BooksGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView BooksGridView;
        private Button Delete;
        private Button Edit;
        private Button Add;
        private Button Refresh;
        private Button Return;
    }
}