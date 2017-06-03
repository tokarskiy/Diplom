namespace LibraryHelper
{
    partial class UserFormViewBooksList
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
            this.booksBox = new System.Windows.Forms.ListView();
            this.CodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AuthorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnabledColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // booksBox
            // 
            this.booksBox.AllowColumnReorder = true;
            this.booksBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodeColumn,
            this.NameColumn,
            this.AuthorColumn,
            this.EnabledColumn});
            this.booksBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.booksBox.FullRowSelect = true;
            this.booksBox.GridLines = true;
            this.booksBox.Location = new System.Drawing.Point(0, 0);
            this.booksBox.MultiSelect = false;
            this.booksBox.Name = "booksBox";
            this.booksBox.Size = new System.Drawing.Size(317, 323);
            this.booksBox.TabIndex = 0;
            this.booksBox.UseCompatibleStateImageBehavior = false;
            this.booksBox.View = System.Windows.Forms.View.Details;
            this.booksBox.DoubleClick += new System.EventHandler(this.booksBox_DoubleClick);
            // 
            // CodeColumn
            // 
            this.CodeColumn.Text = "Code";
            this.CodeColumn.Width = 53;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 99;
            // 
            // AuthorColumn
            // 
            this.AuthorColumn.Text = "Author";
            this.AuthorColumn.Width = 104;
            // 
            // EnabledColumn
            // 
            this.EnabledColumn.Text = "Available";
            // 
            // UserFormViewBooksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 323);
            this.Controls.Add(this.booksBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserFormViewBooksList";
            this.Text = "UserFormViewBooksList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView booksBox;
        private System.Windows.Forms.ColumnHeader CodeColumn;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader AuthorColumn;
        private System.Windows.Forms.ColumnHeader EnabledColumn;
    }
}