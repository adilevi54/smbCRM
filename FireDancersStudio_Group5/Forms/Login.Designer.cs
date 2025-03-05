namespace FireDancersStudio_Group5
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.enter_pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enter_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // enter_pictureBox
            // 
            this.enter_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enter_pictureBox.Image")));
            this.enter_pictureBox.Location = new System.Drawing.Point(511, 323);
            this.enter_pictureBox.Name = "enter_pictureBox";
            this.enter_pictureBox.Size = new System.Drawing.Size(98, 33);
            this.enter_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enter_pictureBox.TabIndex = 16;
            this.enter_pictureBox.TabStop = false;
            this.enter_pictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            this.enter_pictureBox.Resize += new System.EventHandler(this.Login_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ID_textBox
            // 
            this.ID_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ID_textBox.Location = new System.Drawing.Point(511, 138);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(107, 13);
            this.ID_textBox.TabIndex = 18;
            this.ID_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_textBox.TextChanged += new System.EventHandler(this.ID_textBox_TextChanged);
            // 
            // Password_textBox
            // 
            this.Password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Password_textBox.Location = new System.Drawing.Point(511, 193);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(107, 13);
            this.Password_textBox.TabIndex = 19;
            this.Password_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password_textBox.TextChanged += new System.EventHandler(this.Password_textBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 393);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enter_pictureBox);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enter_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.PictureBox enter_pictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}