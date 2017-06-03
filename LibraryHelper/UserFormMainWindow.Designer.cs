namespace LibraryHelper
{
    partial class UserFormMainWindow
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.databaseNameLabel = new System.Windows.Forms.Label();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.BooksButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.DeptorsButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.databaseNameBox = new System.Windows.Forms.TextBox();
            this.BirthdaysButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(46, 18);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(58, 13);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User name";
            // 
            // databaseNameLabel
            // 
            this.databaseNameLabel.AutoSize = true;
            this.databaseNameLabel.Location = new System.Drawing.Point(362, 18);
            this.databaseNameLabel.Name = "databaseNameLabel";
            this.databaseNameLabel.Size = new System.Drawing.Size(82, 13);
            this.databaseNameLabel.TabIndex = 2;
            this.databaseNameLabel.Text = "Database name";
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Location = new System.Drawing.Point(38, 91);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(111, 33);
            this.EmployeesButton.TabIndex = 3;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(469, 52);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(111, 33);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // BooksButton
            // 
            this.BooksButton.Location = new System.Drawing.Point(155, 91);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(111, 33);
            this.BooksButton.TabIndex = 5;
            this.BooksButton.Text = "Books";
            this.BooksButton.UseVisualStyleBackColor = true;
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(155, 52);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(111, 33);
            this.AddBookButton.TabIndex = 6;
            this.AddBookButton.Text = "Add book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // DeptorsButton
            // 
            this.DeptorsButton.Location = new System.Drawing.Point(272, 52);
            this.DeptorsButton.Name = "DeptorsButton";
            this.DeptorsButton.Size = new System.Drawing.Size(111, 33);
            this.DeptorsButton.TabIndex = 7;
            this.DeptorsButton.Text = "Debtors";
            this.DeptorsButton.UseVisualStyleBackColor = true;
            this.DeptorsButton.Click += new System.EventHandler(this.DeptorsButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.Location = new System.Drawing.Point(38, 52);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(111, 33);
            this.ClientsButton.TabIndex = 8;
            this.ClientsButton.Text = "Clients";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // userNameBox
            // 
            this.userNameBox.Enabled = false;
            this.userNameBox.Location = new System.Drawing.Point(110, 15);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(130, 20);
            this.userNameBox.TabIndex = 9;
            // 
            // databaseNameBox
            // 
            this.databaseNameBox.Enabled = false;
            this.databaseNameBox.Location = new System.Drawing.Point(450, 15);
            this.databaseNameBox.Name = "databaseNameBox";
            this.databaseNameBox.Size = new System.Drawing.Size(130, 20);
            this.databaseNameBox.TabIndex = 10;
            // 
            // BirthdaysButton
            // 
            this.BirthdaysButton.Location = new System.Drawing.Point(272, 91);
            this.BirthdaysButton.Name = "BirthdaysButton";
            this.BirthdaysButton.Size = new System.Drawing.Size(111, 33);
            this.BirthdaysButton.TabIndex = 11;
            this.BirthdaysButton.Text = "Birthdays";
            this.BirthdaysButton.UseVisualStyleBackColor = true;
            this.BirthdaysButton.Click += new System.EventHandler(this.BirthdaysButton_Click);
            // 
            // UserFormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 139);
            this.Controls.Add(this.BirthdaysButton);
            this.Controls.Add(this.databaseNameBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.ClientsButton);
            this.Controls.Add(this.DeptorsButton);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.BooksButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.EmployeesButton);
            this.Controls.Add(this.databaseNameLabel);
            this.Controls.Add(this.userNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserFormMainWindow";
            this.Text = "Main menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label databaseNameLabel;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button BooksButton;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button DeptorsButton;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox databaseNameBox;
        private System.Windows.Forms.Button BirthdaysButton;
    }
}

