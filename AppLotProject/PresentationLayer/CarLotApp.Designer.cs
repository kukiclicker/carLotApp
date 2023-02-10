namespace PresentationLayer
{
    partial class CarLotApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarLotApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeApointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewAvailableCars = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonModel = new System.Windows.Forms.RadioButton();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.radioButtonMileage = new System.Windows.Forms.RadioButton();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCars)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SaddleBrown;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.addCarToolStripMenuItem,
            this.makeApointmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripMainMenu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.homeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 10, 30, 0);
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(126, 39);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 10, 30, 0);
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(127, 39);
            this.addCarToolStripMenuItem.Text = "Add Car";
            // 
            // makeApointmentToolStripMenuItem
            // 
            this.makeApointmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeApointmentToolStripMenuItem.Name = "makeApointmentToolStripMenuItem";
            this.makeApointmentToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 10, 30, 0);
            this.makeApointmentToolStripMenuItem.Size = new System.Drawing.Size(136, 39);
            this.makeApointmentToolStripMenuItem.Text = "Test drive";
            // 
            // dataGridViewAvailableCars
            // 
            this.dataGridViewAvailableCars.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dataGridViewAvailableCars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAvailableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableCars.Location = new System.Drawing.Point(278, 111);
            this.dataGridViewAvailableCars.Name = "dataGridViewAvailableCars";
            this.dataGridViewAvailableCars.Size = new System.Drawing.Size(497, 316);
            this.dataGridViewAvailableCars.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search cars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(449, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available cars";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(7, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sort cars:";
            // 
            // radioButtonModel
            // 
            this.radioButtonModel.AutoSize = true;
            this.radioButtonModel.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonModel.ForeColor = System.Drawing.Color.Snow;
            this.radioButtonModel.Location = new System.Drawing.Point(11, 40);
            this.radioButtonModel.Name = "radioButtonModel";
            this.radioButtonModel.Size = new System.Drawing.Size(75, 19);
            this.radioButtonModel.TabIndex = 6;
            this.radioButtonModel.TabStop = true;
            this.radioButtonModel.Text = "by Model";
            this.radioButtonModel.UseVisualStyleBackColor = false;
            this.radioButtonModel.CheckedChanged += new System.EventHandler(this.radioButtonModel_CheckedChanged);
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYear.ForeColor = System.Drawing.Color.Snow;
            this.radioButtonYear.Location = new System.Drawing.Point(11, 75);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(63, 19);
            this.radioButtonYear.TabIndex = 7;
            this.radioButtonYear.TabStop = true;
            this.radioButtonYear.Text = "by Year";
            this.radioButtonYear.UseVisualStyleBackColor = false;
            // 
            // radioButtonMileage
            // 
            this.radioButtonMileage.AutoSize = true;
            this.radioButtonMileage.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMileage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMileage.ForeColor = System.Drawing.Color.Snow;
            this.radioButtonMileage.Location = new System.Drawing.Point(11, 109);
            this.radioButtonMileage.Name = "radioButtonMileage";
            this.radioButtonMileage.Size = new System.Drawing.Size(83, 19);
            this.radioButtonMileage.TabIndex = 8;
            this.radioButtonMileage.TabStop = true;
            this.radioButtonMileage.Text = "by Mileage";
            this.radioButtonMileage.UseVisualStyleBackColor = false;
            // 
            // radioButtonPrice
            // 
            this.radioButtonPrice.AutoSize = true;
            this.radioButtonPrice.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrice.ForeColor = System.Drawing.Color.Snow;
            this.radioButtonPrice.Location = new System.Drawing.Point(11, 146);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(67, 19);
            this.radioButtonPrice.TabIndex = 9;
            this.radioButtonPrice.TabStop = true;
            this.radioButtonPrice.Text = "by Price";
            this.radioButtonPrice.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButtonPrice);
            this.panel1.Controls.Add(this.radioButtonMileage);
            this.panel1.Controls.Add(this.radioButtonYear);
            this.panel1.Controls.Add(this.radioButtonModel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(10, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 195);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(9, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 63);
            this.panel2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(377, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sell Car";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SaddleBrown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(625, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Test Drive";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CarLotApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.background__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAvailableCars);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CarLotApp";
            this.Text = "Car lot ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarLotApp_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCars)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeApointmentToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewAvailableCars;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonModel;
        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.RadioButton radioButtonMileage;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}