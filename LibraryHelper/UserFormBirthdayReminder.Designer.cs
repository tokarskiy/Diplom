namespace LibraryHelper
{
    partial class UserFormBirthdayReminder
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
            this.EmployeesBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EmployeesBox
            // 
            this.EmployeesBox.FormattingEnabled = true;
            this.EmployeesBox.Location = new System.Drawing.Point(12, 12);
            this.EmployeesBox.Name = "EmployeesBox";
            this.EmployeesBox.Size = new System.Drawing.Size(201, 238);
            this.EmployeesBox.TabIndex = 0;
            // 
            // UserFormBirthdayReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 262);
            this.Controls.Add(this.EmployeesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserFormBirthdayReminder";
            this.Text = "Birhday reminder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesBox;
    }
}