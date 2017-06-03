namespace LibraryHelper
{
    partial class UserFormViewDebtors
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
            this.infoBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewClientButton = new System.Windows.Forms.Button();
            this.BookInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.infoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoBox.FullRowSelect = true;
            this.infoBox.GridLines = true;
            this.infoBox.Location = new System.Drawing.Point(0, 0);
            this.infoBox.MultiSelect = false;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(600, 262);
            this.infoBox.TabIndex = 0;
            this.infoBox.UseCompatibleStateImageBehavior = false;
            this.infoBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book name";
            this.columnHeader1.Width = 286;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Client name";
            this.columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Start date";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Responsible employee";
            this.columnHeader4.Width = 158;
            // 
            // ViewClientButton
            // 
            this.ViewClientButton.Location = new System.Drawing.Point(0, 263);
            this.ViewClientButton.Name = "ViewClientButton";
            this.ViewClientButton.Size = new System.Drawing.Size(122, 35);
            this.ViewClientButton.TabIndex = 1;
            this.ViewClientButton.Text = "Client info";
            this.ViewClientButton.UseVisualStyleBackColor = true;
            this.ViewClientButton.Click += new System.EventHandler(this.ViewClientButton_Click);
            // 
            // BookInfoButton
            // 
            this.BookInfoButton.Location = new System.Drawing.Point(122, 263);
            this.BookInfoButton.Name = "BookInfoButton";
            this.BookInfoButton.Size = new System.Drawing.Size(122, 35);
            this.BookInfoButton.TabIndex = 2;
            this.BookInfoButton.Text = "Book info";
            this.BookInfoButton.UseVisualStyleBackColor = true;
            this.BookInfoButton.Click += new System.EventHandler(this.BookInfoButton_Click);
            // 
            // UserFormViewDebtors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 299);
            this.Controls.Add(this.BookInfoButton);
            this.Controls.Add(this.ViewClientButton);
            this.Controls.Add(this.infoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserFormViewDebtors";
            this.Text = "UserFormViewDebtors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView infoBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ViewClientButton;
        private System.Windows.Forms.Button BookInfoButton;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}