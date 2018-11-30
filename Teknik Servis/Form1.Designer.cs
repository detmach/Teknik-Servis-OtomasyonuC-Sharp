namespace Teknik_Servis
{
    partial class Giris_paneli
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifre_text = new System.Windows.Forms.TextBox();
            this.kullanıcı_text = new System.Windows.Forms.TextBox();
            this.Giris_button = new System.Windows.Forms.Button();
            this.Cikis_button = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // sifre_text
            // 
            this.sifre_text.Location = new System.Drawing.Point(298, 152);
            this.sifre_text.Margin = new System.Windows.Forms.Padding(4);
            this.sifre_text.Name = "sifre_text";
            this.sifre_text.PasswordChar = '*';
            this.sifre_text.Size = new System.Drawing.Size(132, 23);
            this.sifre_text.TabIndex = 2;
            // 
            // kullanıcı_text
            // 
            this.kullanıcı_text.Location = new System.Drawing.Point(298, 96);
            this.kullanıcı_text.Margin = new System.Windows.Forms.Padding(4);
            this.kullanıcı_text.Name = "kullanıcı_text";
            this.kullanıcı_text.Size = new System.Drawing.Size(132, 23);
            this.kullanıcı_text.TabIndex = 1;
            // 
            // Giris_button
            // 
            this.Giris_button.BackColor = System.Drawing.Color.Lime;
            this.Giris_button.Image = global::Teknik_Servis.Properties.Resources._001_login;
            this.Giris_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Giris_button.Location = new System.Drawing.Point(241, 242);
            this.Giris_button.Margin = new System.Windows.Forms.Padding(4);
            this.Giris_button.Name = "Giris_button";
            this.Giris_button.Size = new System.Drawing.Size(114, 93);
            this.Giris_button.TabIndex = 3;
            this.Giris_button.Text = "Giriş";
            this.Giris_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Giris_button.UseVisualStyleBackColor = false;
            this.Giris_button.Click += new System.EventHandler(this.Giris_button_Click);
            // 
            // Cikis_button
            // 
            this.Cikis_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cikis_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cikis_button.Image = global::Teknik_Servis.Properties.Resources._002_logout;
            this.Cikis_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cikis_button.Location = new System.Drawing.Point(401, 242);
            this.Cikis_button.Margin = new System.Windows.Forms.Padding(4);
            this.Cikis_button.Name = "Cikis_button";
            this.Cikis_button.Size = new System.Drawing.Size(116, 93);
            this.Cikis_button.TabIndex = 4;
            this.Cikis_button.Text = "Çıkış";
            this.Cikis_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cikis_button.UseVisualStyleBackColor = false;
            this.Cikis_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Teknik_Servis.Properties.Resources.door_key;
            this.pictureBox3.Location = new System.Drawing.Point(27, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Teknik_Servis.Properties.Resources._002_password;
            this.pictureBox1.Location = new System.Drawing.Point(459, 152);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 42);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Teknik_Servis.Properties.Resources._001_id1;
            this.pictureBox2.Location = new System.Drawing.Point(459, 87);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 42);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(703, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Teknik Servis Otomasyonuna Girmek İçin Lütfen Kullanıcı Adınızı Ve Şifrenizi Yazı" +
    "nız.\r\n\r\n";
            // 
            // Giris_paneli
            // 
            this.AcceptButton = this.Giris_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.CancelButton = this.Cikis_button;
            this.ClientSize = new System.Drawing.Size(713, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Cikis_button);
            this.Controls.Add(this.kullanıcı_text);
            this.Controls.Add(this.sifre_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Giris_button);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Giris_paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Paneli";
            this.Load += new System.EventHandler(this.Giris_paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Giris_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cikis_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox sifre_text;
        public System.Windows.Forms.TextBox kullanıcı_text;
    }
}

