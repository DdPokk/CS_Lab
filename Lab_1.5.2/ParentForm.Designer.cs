﻿namespace Lab_1._5._2
{
    partial class ParentForm
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
            this.ParentFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParentFormButton
            // 
            this.ParentFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParentFormButton.BackColor = System.Drawing.Color.White;
            this.ParentFormButton.Location = new System.Drawing.Point(12, 34);
            this.ParentFormButton.Name = "ParentFormButton";
            this.ParentFormButton.Size = new System.Drawing.Size(271, 73);
            this.ParentFormButton.TabIndex = 0;
            this.ParentFormButton.Text = "GREENPEACE";
            this.ParentFormButton.UseVisualStyleBackColor = false;
            this.ParentFormButton.Click += new System.EventHandler(this.ParentFormButton_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ParentFormButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParentForm";
            this.Text = "Parent Form";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button ParentFormButton;
    }
}

