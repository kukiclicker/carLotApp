namespace PresentationLayer
{
    partial class DeleteEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmployeeIDForDeletion = new System.Windows.Forms.TextBox();
            this.buttonDeleteEmp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(178, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEmployeeIDForDeletion
            // 
            this.textBoxEmployeeIDForDeletion.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmployeeIDForDeletion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmployeeIDForDeletion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeIDForDeletion.Location = new System.Drawing.Point(149, 90);
            this.textBoxEmployeeIDForDeletion.Name = "textBoxEmployeeIDForDeletion";
            this.textBoxEmployeeIDForDeletion.Size = new System.Drawing.Size(202, 25);
            this.textBoxEmployeeIDForDeletion.TabIndex = 1;
            // 
            // buttonDeleteEmp
            // 
            this.buttonDeleteEmp.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonDeleteEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteEmp.ForeColor = System.Drawing.Color.Snow;
            this.buttonDeleteEmp.Location = new System.Drawing.Point(375, 90);
            this.buttonDeleteEmp.Name = "buttonDeleteEmp";
            this.buttonDeleteEmp.Size = new System.Drawing.Size(104, 25);
            this.buttonDeleteEmp.TabIndex = 2;
            this.buttonDeleteEmp.Text = "Delete";
            this.buttonDeleteEmp.UseVisualStyleBackColor = false;
            this.buttonDeleteEmp.Click += new System.EventHandler(this.buttonDeleteEmp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(46, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.background_img1;
            this.ClientSize = new System.Drawing.Size(511, 159);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDeleteEmp);
            this.Controls.Add(this.textBoxEmployeeIDForDeletion);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car lot app - Delete Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployeeIDForDeletion;
        private System.Windows.Forms.Button buttonDeleteEmp;
        private System.Windows.Forms.Label label2;
    }
}