namespace LibraryHelper
{
    partial class UserFormViewPersonsList
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
            this.personsBox = new System.Windows.Forms.ListBox();
            this.ShowEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personsBox
            // 
            this.personsBox.FormattingEnabled = true;
            this.personsBox.Location = new System.Drawing.Point(12, 12);
            this.personsBox.Name = "personsBox";
            this.personsBox.Size = new System.Drawing.Size(208, 225);
            this.personsBox.TabIndex = 0;
            this.personsBox.DoubleClick += new System.EventHandler(this.personsBox_DoubleClick);
            // 
            // ShowEmployeeButton
            // 
            this.ShowEmployeeButton.Location = new System.Drawing.Point(226, 12);
            this.ShowEmployeeButton.Name = "ShowEmployeeButton";
            this.ShowEmployeeButton.Size = new System.Drawing.Size(111, 33);
            this.ShowEmployeeButton.TabIndex = 1;
            this.ShowEmployeeButton.Text = "Show";
            this.ShowEmployeeButton.UseVisualStyleBackColor = true;
            this.ShowEmployeeButton.Click += new System.EventHandler(this.ShowEmployeeButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(226, 204);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(111, 33);
            this.DeleteEmployeeButton.TabIndex = 2;
            this.DeleteEmployeeButton.Text = "Delete";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // UserFormViewPersonsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 249);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.ShowEmployeeButton);
            this.Controls.Add(this.personsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserFormViewPersonsList";
            this.Text = "UserFormViewEmployeeList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox personsBox;
        private System.Windows.Forms.Button ShowEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
    }
}