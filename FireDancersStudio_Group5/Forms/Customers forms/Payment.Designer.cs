namespace FireDancersStudio_Group5.Forms.Customers_forms
{
    partial class Payment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ownPackages_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newPackages_dataGridView = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Package_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classes_limit_per_week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCard_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ownPackages_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPackages_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ownPackages_dataGridView
            // 
            this.ownPackages_dataGridView.AllowUserToAddRows = false;
            this.ownPackages_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ownPackages_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownPackages_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.ownPackages_dataGridView.Location = new System.Drawing.Point(647, 147);
            this.ownPackages_dataGridView.Name = "ownPackages_dataGridView";
            this.ownPackages_dataGridView.ReadOnly = true;
            this.ownPackages_dataGridView.RowHeadersVisible = false;
            this.ownPackages_dataGridView.RowHeadersWidth = 51;
            this.ownPackages_dataGridView.Size = new System.Drawing.Size(104, 163);
            this.ownPackages_dataGridView.TabIndex = 2;
            this.ownPackages_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Package Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // newPackages_dataGridView
            // 
            this.newPackages_dataGridView.AllowUserToAddRows = false;
            this.newPackages_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newPackages_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newPackages_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Package_Name,
            this.classes_limit_per_week,
            this.Payment_Cycle,
            this.Price});
            this.newPackages_dataGridView.Location = new System.Drawing.Point(33, 147);
            this.newPackages_dataGridView.Name = "newPackages_dataGridView";
            this.newPackages_dataGridView.ReadOnly = true;
            this.newPackages_dataGridView.RowHeadersVisible = false;
            this.newPackages_dataGridView.RowHeadersWidth = 51;
            this.newPackages_dataGridView.Size = new System.Drawing.Size(520, 163);
            this.newPackages_dataGridView.TabIndex = 3;
            this.newPackages_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.newPackages_dataGridView_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Width = 125;
            // 
            // Package_Name
            // 
            this.Package_Name.HeaderText = "Package Name";
            this.Package_Name.MinimumWidth = 6;
            this.Package_Name.Name = "Package_Name";
            this.Package_Name.ReadOnly = true;
            this.Package_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Package_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Package_Name.Width = 125;
            // 
            // classes_limit_per_week
            // 
            this.classes_limit_per_week.HeaderText = "Classes Limit Per Week";
            this.classes_limit_per_week.MinimumWidth = 6;
            this.classes_limit_per_week.Name = "classes_limit_per_week";
            this.classes_limit_per_week.ReadOnly = true;
            this.classes_limit_per_week.Width = 125;
            // 
            // Payment_Cycle
            // 
            this.Payment_Cycle.HeaderText = "Payment Cycle";
            this.Payment_Cycle.MinimumWidth = 6;
            this.Payment_Cycle.Name = "Payment_Cycle";
            this.Payment_Cycle.ReadOnly = true;
            this.Payment_Cycle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Payment_Cycle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Payment_Cycle.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price.Width = 125;
            // 
            // creditCard_textBox
            // 
            this.creditCard_textBox.Location = new System.Drawing.Point(318, 337);
            this.creditCard_textBox.Name = "creditCard_textBox";
            this.creditCard_textBox.Size = new System.Drawing.Size(308, 20);
            this.creditCard_textBox.TabIndex = 5;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(318, 385);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(308, 20);
            this.email_textBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(478, 21);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(81, 21);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 61;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(574, 22);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 21);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 60;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(398, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 59;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(688, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 62;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.creditCard_textBox);
            this.Controls.Add(this.newPackages_dataGridView);
            this.Controls.Add(this.ownPackages_dataGridView);
            this.Name = "Payment";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.ownPackages_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPackages_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView ownPackages_dataGridView;
        private System.Windows.Forms.DataGridView newPackages_dataGridView;
        private System.Windows.Forms.TextBox creditCard_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn classes_limit_per_week;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}