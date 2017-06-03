namespace LibraryHelper
{
    partial class UserFormViewPerson
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChangeBirthDateButton = new System.Windows.Forms.Button();
            this.birthDateBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.middleNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveEmailButton = new System.Windows.Forms.Button();
            this.UpdateEmailButton = new System.Windows.Forms.Button();
            this.AddEmailButton = new System.Windows.Forms.Button();
            this.emailsBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RemovePhoneButton = new System.Windows.Forms.Button();
            this.UpdatePhoneButton = new System.Windows.Forms.Button();
            this.phonesBox = new System.Windows.Forms.ListBox();
            this.AddPhoneButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChangeBirthDateButton);
            this.groupBox1.Controls.Add(this.birthDateBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.middleNameBox);
            this.groupBox1.Controls.Add(this.lastNameBox);
            this.groupBox1.Controls.Add(this.firstNameBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal data";
            // 
            // ChangeBirthDateButton
            // 
            this.ChangeBirthDateButton.Location = new System.Drawing.Point(363, 106);
            this.ChangeBirthDateButton.Name = "ChangeBirthDateButton";
            this.ChangeBirthDateButton.Size = new System.Drawing.Size(24, 21);
            this.ChangeBirthDateButton.TabIndex = 7;
            this.ChangeBirthDateButton.Text = "...";
            this.ChangeBirthDateButton.UseVisualStyleBackColor = true;
            this.ChangeBirthDateButton.Click += new System.EventHandler(this.ChangeBirthDateButton_Click);
            // 
            // birthDateBox
            // 
            this.birthDateBox.Location = new System.Drawing.Point(116, 107);
            this.birthDateBox.Name = "birthDateBox";
            this.birthDateBox.Size = new System.Drawing.Size(249, 20);
            this.birthDateBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Middle name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First name";
            // 
            // middleNameBox
            // 
            this.middleNameBox.Location = new System.Drawing.Point(116, 80);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new System.Drawing.Size(271, 20);
            this.middleNameBox.TabIndex = 2;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(116, 54);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(271, 20);
            this.lastNameBox.TabIndex = 1;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(116, 28);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(271, 20);
            this.firstNameBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoveEmailButton);
            this.groupBox2.Controls.Add(this.UpdateEmailButton);
            this.groupBox2.Controls.Add(this.AddEmailButton);
            this.groupBox2.Controls.Add(this.emailsBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emails";
            // 
            // RemoveEmailButton
            // 
            this.RemoveEmailButton.Location = new System.Drawing.Point(125, 133);
            this.RemoveEmailButton.Name = "RemoveEmailButton";
            this.RemoveEmailButton.Size = new System.Drawing.Size(57, 23);
            this.RemoveEmailButton.TabIndex = 3;
            this.RemoveEmailButton.Text = "Remove";
            this.RemoveEmailButton.UseVisualStyleBackColor = true;
            this.RemoveEmailButton.Click += new System.EventHandler(this.RemoveEmailButton_Click);
            // 
            // UpdateEmailButton
            // 
            this.UpdateEmailButton.Location = new System.Drawing.Point(72, 133);
            this.UpdateEmailButton.Name = "UpdateEmailButton";
            this.UpdateEmailButton.Size = new System.Drawing.Size(57, 23);
            this.UpdateEmailButton.TabIndex = 2;
            this.UpdateEmailButton.Text = "Update";
            this.UpdateEmailButton.UseVisualStyleBackColor = true;
            this.UpdateEmailButton.Click += new System.EventHandler(this.UpdateEmailButton_Click);
            // 
            // AddEmailButton
            // 
            this.AddEmailButton.Location = new System.Drawing.Point(18, 133);
            this.AddEmailButton.Name = "AddEmailButton";
            this.AddEmailButton.Size = new System.Drawing.Size(57, 23);
            this.AddEmailButton.TabIndex = 1;
            this.AddEmailButton.Text = "Add";
            this.AddEmailButton.UseVisualStyleBackColor = true;
            this.AddEmailButton.Click += new System.EventHandler(this.AddEmailButton_Click);
            // 
            // emailsBox
            // 
            this.emailsBox.FormattingEnabled = true;
            this.emailsBox.Location = new System.Drawing.Point(19, 19);
            this.emailsBox.Name = "emailsBox";
            this.emailsBox.Size = new System.Drawing.Size(163, 108);
            this.emailsBox.TabIndex = 0;
            this.emailsBox.SelectedIndexChanged += new System.EventHandler(this.emailsBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RemovePhoneButton);
            this.groupBox3.Controls.Add(this.UpdatePhoneButton);
            this.groupBox3.Controls.Add(this.phonesBox);
            this.groupBox3.Controls.Add(this.AddPhoneButton);
            this.groupBox3.Location = new System.Drawing.Point(217, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 164);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phones";
            // 
            // RemovePhoneButton
            // 
            this.RemovePhoneButton.Location = new System.Drawing.Point(125, 133);
            this.RemovePhoneButton.Name = "RemovePhoneButton";
            this.RemovePhoneButton.Size = new System.Drawing.Size(57, 23);
            this.RemovePhoneButton.TabIndex = 6;
            this.RemovePhoneButton.Text = "Remove";
            this.RemovePhoneButton.UseVisualStyleBackColor = true;
            this.RemovePhoneButton.Click += new System.EventHandler(this.RemovePhoneButton_Click);
            // 
            // UpdatePhoneButton
            // 
            this.UpdatePhoneButton.Location = new System.Drawing.Point(72, 133);
            this.UpdatePhoneButton.Name = "UpdatePhoneButton";
            this.UpdatePhoneButton.Size = new System.Drawing.Size(57, 23);
            this.UpdatePhoneButton.TabIndex = 5;
            this.UpdatePhoneButton.Text = "Update";
            this.UpdatePhoneButton.UseVisualStyleBackColor = true;
            this.UpdatePhoneButton.Click += new System.EventHandler(this.UpdatePhoneButton_Click);
            // 
            // phonesBox
            // 
            this.phonesBox.FormattingEnabled = true;
            this.phonesBox.Location = new System.Drawing.Point(19, 19);
            this.phonesBox.Name = "phonesBox";
            this.phonesBox.Size = new System.Drawing.Size(163, 108);
            this.phonesBox.TabIndex = 1;
            this.phonesBox.SelectedIndexChanged += new System.EventHandler(this.phonesBox_SelectedIndexChanged);
            // 
            // AddPhoneButton
            // 
            this.AddPhoneButton.Location = new System.Drawing.Point(18, 133);
            this.AddPhoneButton.Name = "AddPhoneButton";
            this.AddPhoneButton.Size = new System.Drawing.Size(57, 23);
            this.AddPhoneButton.TabIndex = 4;
            this.AddPhoneButton.Text = "Add";
            this.AddPhoneButton.UseVisualStyleBackColor = true;
            this.AddPhoneButton.Click += new System.EventHandler(this.AddPhoneButton_Click);
            // 
            // CancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(308, 325);
            this.cancelButton.Name = "CancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 29);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(192, 325);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(110, 29);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // UserFormViewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 366);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserFormViewPerson";
            this.Text = "UserFormViewPerson";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox middleNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox emailsBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox phonesBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button RemoveEmailButton;
        private System.Windows.Forms.Button UpdateEmailButton;
        private System.Windows.Forms.Button AddEmailButton;
        private System.Windows.Forms.Button RemovePhoneButton;
        private System.Windows.Forms.Button UpdatePhoneButton;
        private System.Windows.Forms.Button AddPhoneButton;
        private System.Windows.Forms.Button ChangeBirthDateButton;
        private System.Windows.Forms.TextBox birthDateBox;
    }
}