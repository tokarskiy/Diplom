using System;

namespace LibraryHelper
{
    partial class UserFormViewBook
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.ageLimitBox = new System.Windows.Forms.NumericUpDown();
            this.yearBox = new System.Windows.Forms.NumericUpDown();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReturnedButton = new System.Windows.Forms.Button();
            this.NewOwnerButton = new System.Windows.Forms.Button();
            this.ownersBox = new System.Windows.Forms.ListView();
            this.StartDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OwnerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OwnerInfoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageLimitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(548, 175);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 29);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(432, 175);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(110, 29);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.codeBox);
            this.groupBox1.Controls.Add(this.ageLimitBox);
            this.groupBox1.Controls.Add(this.yearBox);
            this.groupBox1.Controls.Add(this.authorBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 157);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Age limit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Release year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(87, 14);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(167, 20);
            this.codeBox.TabIndex = 4;
            // 
            // ageLimitBox
            // 
            this.ageLimitBox.Location = new System.Drawing.Point(87, 123);
            this.ageLimitBox.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.ageLimitBox.Name = "ageLimitBox";
            this.ageLimitBox.Size = new System.Drawing.Size(66, 20);
            this.ageLimitBox.TabIndex = 3;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(87, 97);
            this.yearBox.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(66, 20);
            this.yearBox.TabIndex = 2;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(87, 66);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(167, 20);
            this.authorBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(87, 40);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(167, 20);
            this.nameBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OwnerInfoButton);
            this.groupBox2.Controls.Add(this.ReturnedButton);
            this.groupBox2.Controls.Add(this.NewOwnerButton);
            this.groupBox2.Controls.Add(this.ownersBox);
            this.groupBox2.Location = new System.Drawing.Point(278, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 157);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Owners";
            // 
            // ReturnedButton
            // 
            this.ReturnedButton.Location = new System.Drawing.Point(109, 125);
            this.ReturnedButton.Name = "ReturnedButton";
            this.ReturnedButton.Size = new System.Drawing.Size(171, 26);
            this.ReturnedButton.TabIndex = 16;
            this.ReturnedButton.Text = "Client has returned this book";
            this.ReturnedButton.UseVisualStyleBackColor = true;
            this.ReturnedButton.Click += new System.EventHandler(this.ReturnedButton_Click);
            // 
            // NewOwnerButton
            // 
            this.NewOwnerButton.Location = new System.Drawing.Point(6, 125);
            this.NewOwnerButton.Name = "NewOwnerButton";
            this.NewOwnerButton.Size = new System.Drawing.Size(97, 26);
            this.NewOwnerButton.TabIndex = 15;
            this.NewOwnerButton.Text = "New owner";
            this.NewOwnerButton.UseVisualStyleBackColor = true;
            this.NewOwnerButton.Click += new System.EventHandler(this.NewOwnerButton_Click);
            // 
            // ownersBox
            // 
            this.ownersBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StartDateColumn,
            this.EndDateColumn,
            this.OwnerColumn});
            this.ownersBox.GridLines = true;
            this.ownersBox.Location = new System.Drawing.Point(6, 19);
            this.ownersBox.Name = "ownersBox";
            this.ownersBox.Size = new System.Drawing.Size(368, 97);
            this.ownersBox.TabIndex = 0;
            this.ownersBox.UseCompatibleStateImageBehavior = false;
            this.ownersBox.View = System.Windows.Forms.View.Details;
            // 
            // StartDateColumn
            // 
            this.StartDateColumn.Text = "Start date";
            this.StartDateColumn.Width = 86;
            // 
            // EndDateColumn
            // 
            this.EndDateColumn.Text = "End date";
            this.EndDateColumn.Width = 92;
            // 
            // OwnerColumn
            // 
            this.OwnerColumn.Text = "Owner";
            this.OwnerColumn.Width = 184;
            // 
            // OwnerInfoButton
            // 
            this.OwnerInfoButton.Location = new System.Drawing.Point(283, 125);
            this.OwnerInfoButton.Name = "OwnerInfoButton";
            this.OwnerInfoButton.Size = new System.Drawing.Size(91, 26);
            this.OwnerInfoButton.TabIndex = 17;
            this.OwnerInfoButton.Text = "Owner info";
            this.OwnerInfoButton.UseVisualStyleBackColor = true;
            this.OwnerInfoButton.Click += new System.EventHandler(this.OwnerInfoButton_Click);
            // 
            // UserFormViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 212);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserFormViewBook";
            this.Text = "UserFormViewBook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageLimitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.NumericUpDown ageLimitBox;
        private System.Windows.Forms.NumericUpDown yearBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView ownersBox;
        private System.Windows.Forms.ColumnHeader StartDateColumn;
        private System.Windows.Forms.ColumnHeader EndDateColumn;
        private System.Windows.Forms.ColumnHeader OwnerColumn;
        private System.Windows.Forms.Button NewOwnerButton;
        private System.Windows.Forms.Button ReturnedButton;
        private System.Windows.Forms.Button OwnerInfoButton;
    }
}