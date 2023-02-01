﻿namespace PresentationLayer
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.btnRegisterX = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegisterX
            // 
            this.btnRegisterX.AutoSize = true;
            this.btnRegisterX.BackColor = System.Drawing.Color.Transparent;
            this.btnRegisterX.ForeColor = System.Drawing.Color.Snow;
            this.btnRegisterX.Location = new System.Drawing.Point(786, -1);
            this.btnRegisterX.Name = "btnRegisterX";
            this.btnRegisterX.Size = new System.Drawing.Size(14, 13);
            this.btnRegisterX.TabIndex = 0;
            this.btnRegisterX.Text = "X";
            this.btnRegisterX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRegisterX_MouseClick);
            this.btnRegisterX.MouseEnter += new System.EventHandler(this.btnRegisterX_MouseEnter);
            this.btnRegisterX.MouseLeave += new System.EventHandler(this.btnRegisterX_MouseLeave);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.DimGray;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(104, 123);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(179, 13);
            this.textBoxName.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.background_img1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnRegisterX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnRegisterX;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBox1;
    }
}