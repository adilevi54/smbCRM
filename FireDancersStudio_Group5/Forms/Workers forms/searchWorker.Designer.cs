namespace FireDancersStudio_Group5
{
    partial class searchWorker
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
            this.serachWorker_button = new System.Windows.Forms.Button();
            this.ID_insert_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateWorker_button = new System.Windows.Forms.Button();
            this.deleteWorker_button = new System.Windows.Forms.Button();
            this.firstname_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastname_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.role_textBox = new System.Windows.Forms.TextBox();
            this.return_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serachWorker_button
            // 
            this.serachWorker_button.BackColor = System.Drawing.Color.RosyBrown;
            this.serachWorker_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.serachWorker_button.Location = new System.Drawing.Point(360, 139);
            this.serachWorker_button.Name = "serachWorker_button";
            this.serachWorker_button.Size = new System.Drawing.Size(75, 33);
            this.serachWorker_button.TabIndex = 0;
            this.serachWorker_button.Text = "חיפוש";
            this.serachWorker_button.UseVisualStyleBackColor = false;
            this.serachWorker_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID_insert_textBox
            // 
            this.ID_insert_textBox.Location = new System.Drawing.Point(285, 103);
            this.ID_insert_textBox.Name = "ID_insert_textBox";
            this.ID_insert_textBox.Size = new System.Drawing.Size(227, 20);
            this.ID_insert_textBox.TabIndex = 1;
            this.ID_insert_textBox.TextChanged += new System.EventHandler(this.ID_insert_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(312, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "הזן ת\"ז עובד לחיפוש";
            // 
            // updateWorker_button
            // 
            this.updateWorker_button.BackColor = System.Drawing.Color.RosyBrown;
            this.updateWorker_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateWorker_button.Location = new System.Drawing.Point(469, 403);
            this.updateWorker_button.Name = "updateWorker_button";
            this.updateWorker_button.Size = new System.Drawing.Size(75, 35);
            this.updateWorker_button.TabIndex = 3;
            this.updateWorker_button.Text = "עדכון";
            this.updateWorker_button.UseVisualStyleBackColor = false;
            this.updateWorker_button.Click += new System.EventHandler(this.updateWorker_button_Click);
            // 
            // deleteWorker_button
            // 
            this.deleteWorker_button.BackColor = System.Drawing.Color.RosyBrown;
            this.deleteWorker_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteWorker_button.Location = new System.Drawing.Point(262, 403);
            this.deleteWorker_button.Name = "deleteWorker_button";
            this.deleteWorker_button.Size = new System.Drawing.Size(75, 35);
            this.deleteWorker_button.TabIndex = 4;
            this.deleteWorker_button.Text = "מחק";
            this.deleteWorker_button.UseVisualStyleBackColor = false;
            this.deleteWorker_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // firstname_textBox
            // 
            this.firstname_textBox.Location = new System.Drawing.Point(285, 208);
            this.firstname_textBox.Name = "firstname_textBox";
            this.firstname_textBox.Size = new System.Drawing.Size(173, 20);
            this.firstname_textBox.TabIndex = 5;
            this.firstname_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(474, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "שם פרטי";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lastname_textBox
            // 
            this.lastname_textBox.Location = new System.Drawing.Point(285, 234);
            this.lastname_textBox.Name = "lastname_textBox";
            this.lastname_textBox.Size = new System.Drawing.Size(173, 20);
            this.lastname_textBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(464, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "שם משפחה";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(285, 260);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(173, 20);
            this.phone_textBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(479, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "טלפון";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(484, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "מייל";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(285, 286);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(173, 20);
            this.email_textBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(474, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "תפקיד";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // role_textBox
            // 
            this.role_textBox.Location = new System.Drawing.Point(285, 312);
            this.role_textBox.Name = "role_textBox";
            this.role_textBox.Size = new System.Drawing.Size(173, 20);
            this.role_textBox.TabIndex = 14;
            // 
            // return_button2
            // 
            this.return_button2.BackColor = System.Drawing.Color.RosyBrown;
            this.return_button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.return_button2.Location = new System.Drawing.Point(713, 26);
            this.return_button2.Name = "return_button2";
            this.return_button2.Size = new System.Drawing.Size(75, 35);
            this.return_button2.TabIndex = 15;
            this.return_button2.Text = "חזרה";
            this.return_button2.UseVisualStyleBackColor = false;
            this.return_button2.Click += new System.EventHandler(this.return_button2_Click);
            // 
            // searchWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.return_button2);
            this.Controls.Add(this.role_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstname_textBox);
            this.Controls.Add(this.deleteWorker_button);
            this.Controls.Add(this.updateWorker_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_insert_textBox);
            this.Controls.Add(this.serachWorker_button);
            this.Name = "searchWorker";
            this.Text = "searchWorker";
            this.Load += new System.EventHandler(this.searchWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button serachWorker_button;
        private System.Windows.Forms.TextBox ID_insert_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateWorker_button;
        private System.Windows.Forms.Button deleteWorker_button;
        private System.Windows.Forms.TextBox firstname_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastname_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox role_textBox;
        private System.Windows.Forms.Button return_button2;
    }
}