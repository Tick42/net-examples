﻿
namespace WindowsFormsChildAppsDemo
{
    partial class ChildForm
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
            this.redColorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redColorBtn
            // 
            this.redColorBtn.Location = new System.Drawing.Point(328, 176);
            this.redColorBtn.Name = "redColorBtn";
            this.redColorBtn.Size = new System.Drawing.Size(171, 58);
            this.redColorBtn.TabIndex = 0;
            this.redColorBtn.Text = "Fill the background with Red color";
            this.redColorBtn.UseVisualStyleBackColor = true;
            this.redColorBtn.Click += new System.EventHandler(this.redColorBtn_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.redColorBtn);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redColorBtn;
    }
}