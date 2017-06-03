namespace LibraryHelper
{
    partial class UserFormChoosePerson
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
            this.personsBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.NewClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personsBox
            // 
            this.personsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personsBox.FormattingEnabled = true;
            this.personsBox.Location = new System.Drawing.Point(12, 12);
            this.personsBox.Name = "personsBox";
            this.personsBox.Size = new System.Drawing.Size(239, 21);
            this.personsBox.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(141, 39);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(110, 29);
            this.OKButton.TabIndex = 13;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // NewClientButton
            // 
            this.NewClientButton.Location = new System.Drawing.Point(12, 39);
            this.NewClientButton.Name = "NewClientButton";
            this.NewClientButton.Size = new System.Drawing.Size(110, 29);
            this.NewClientButton.TabIndex = 14;
            this.NewClientButton.Text = "New Client";
            this.NewClientButton.UseVisualStyleBackColor = true;
            this.NewClientButton.Click += new System.EventHandler(this.NewClientButton_Click);
            // 
            // UserFormChoosePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 76);
            this.Controls.Add(this.NewClientButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.personsBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserFormChoosePerson";
            this.Text = "UserFormChoosePerson";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox personsBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button NewClientButton;
    }
}