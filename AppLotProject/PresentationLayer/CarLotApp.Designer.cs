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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarLotApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.makeApointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewAvailableCars = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonModel = new System.Windows.Forms.RadioButton();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.radioButtonMileage = new System.Windows.Forms.RadioButton();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSellCar = new System.Windows.Forms.Button();
            this.buttonLoanCar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCars)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SaddleBrown;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.addCarToolStripMenuItem,
            this.makeApointmentToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reportsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(800, 39);
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
            this.addCarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem1});
            this.addCarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 10, 30, 0);
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(95, 39);
            this.addCarToolStripMenuItem.Text = "Car";
            this.addCarToolStripMenuItem.Visible = false;
            // 
            // addCarToolStripMenuItem1
            // 
            this.addCarToolStripMenuItem1.Name = "addCarToolStripMenuItem1";
            this.addCarToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.addCarToolStripMenuItem1.Text = "Add car";
            // 
            // makeApointmentToolStripMenuItem
            // 
            this.makeApointmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeApointmentToolStripMenuItem.Name = "makeApointmentToolStripMenuItem";
            this.makeApointmentToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 10, 30, 0);
            this.makeApointmentToolStripMenuItem.Size = new System.Drawing.Size(136, 39);
            this.makeApointmentToolStripMenuItem.Text = "Test drive";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(30, 10, 30, 0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 39);
            this.toolStripMenuItem1.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.addEmployeeToolStripMenuItem.Text = "Add employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete employee";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 10, 30, 0);
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(124, 39);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(72, 39);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // dataGridViewAvailableCars
            // 
            this.dataGridViewAvailableCars.AllowUserToAddRows = false;
            this.dataGridViewAvailableCars.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Snow;
            this.dataGridViewAvailableCars.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAvailableCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAvailableCars.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dataGridViewAvailableCars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAvailableCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAvailableCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAvailableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAvailableCars.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAvailableCars.GridColor = System.Drawing.Color.SaddleBrown;
            this.dataGridViewAvailableCars.Location = new System.Drawing.Point(290, 111);
            this.dataGridViewAvailableCars.Name = "dataGridViewAvailableCars";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAvailableCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAvailableCars.Size = new System.Drawing.Size(485, 316);
            this.dataGridViewAvailableCars.TabIndex = 1;
            this.dataGridViewAvailableCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAvailableCars_CellClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 30);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(227, 22);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(457, 59);
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
            this.radioButtonModel.Click += new System.EventHandler(this.radioButtonModel_Click);
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
            this.radioButtonYear.Click += new System.EventHandler(this.radioButtonYear_Click);
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
            this.radioButtonMileage.Click += new System.EventHandler(this.radioButtonMileage_Click);
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
            this.radioButtonPrice.Click += new System.EventHandler(this.radioButtonPrice_Click);
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
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(9, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 63);
            this.panel2.TabIndex = 11;
            // 
            // buttonSellCar
            // 
            this.buttonSellCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSellCar.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonSellCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSellCar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSellCar.ForeColor = System.Drawing.Color.Snow;
            this.buttonSellCar.Location = new System.Drawing.Point(377, 433);
            this.buttonSellCar.Name = "buttonSellCar";
            this.buttonSellCar.Size = new System.Drawing.Size(75, 33);
            this.buttonSellCar.TabIndex = 12;
            this.buttonSellCar.Text = "Sell Car";
            this.buttonSellCar.UseVisualStyleBackColor = false;
            this.buttonSellCar.Visible = false;
            this.buttonSellCar.Click += new System.EventHandler(this.buttonSellCar_Click);
            // 
            // buttonLoanCar
            // 
            this.buttonLoanCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoanCar.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonLoanCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoanCar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoanCar.ForeColor = System.Drawing.Color.Snow;
            this.buttonLoanCar.Location = new System.Drawing.Point(625, 436);
            this.buttonLoanCar.Name = "buttonLoanCar";
            this.buttonLoanCar.Size = new System.Drawing.Size(96, 30);
            this.buttonLoanCar.TabIndex = 13;
            this.buttonLoanCar.Text = "Loan car";
            this.buttonLoanCar.UseVisualStyleBackColor = false;
            this.buttonLoanCar.Visible = false;
            this.buttonLoanCar.Click += new System.EventHandler(this.buttonLoanCar_Click);
            // 
            // CarLotApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.background__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.buttonLoanCar);
            this.Controls.Add(this.buttonSellCar);
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
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonModel;
        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.RadioButton radioButtonMileage;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSellCar;
        private System.Windows.Forms.Button buttonLoanCar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}