namespace Teknik_Servis
{
    partial class Musteri_Listesi
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
            this.Musteri_Liste = new System.Windows.Forms.DataGridView();
            this.buttonVeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Musteri_Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // Musteri_Liste
            // 
            this.Musteri_Liste.AllowUserToAddRows = false;
            this.Musteri_Liste.AllowUserToDeleteRows = false;
            this.Musteri_Liste.BackgroundColor = System.Drawing.Color.Cyan;
            this.Musteri_Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Musteri_Liste.GridColor = System.Drawing.Color.Black;
            this.Musteri_Liste.Location = new System.Drawing.Point(-4, 0);
            this.Musteri_Liste.Name = "Musteri_Liste";
            this.Musteri_Liste.ReadOnly = true;
            this.Musteri_Liste.Size = new System.Drawing.Size(924, 462);
            this.Musteri_Liste.TabIndex = 0;
            this.Musteri_Liste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonVeri
            // 
            this.buttonVeri.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonVeri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVeri.Location = new System.Drawing.Point(-4, 0);
            this.buttonVeri.Name = "buttonVeri";
            this.buttonVeri.Size = new System.Drawing.Size(154, 32);
            this.buttonVeri.TabIndex = 1;
            this.buttonVeri.Text = "Veri Gönder";
            this.buttonVeri.UseVisualStyleBackColor = false;
            this.buttonVeri.Click += new System.EventHandler(this.buttonVeri_Click);
            // 
            // Musteri_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 457);
            this.Controls.Add(this.buttonVeri);
            this.Controls.Add(this.Musteri_Liste);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Musteri_Listesi";
            this.Text = "Musteri Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Musteri_Listesi_FormClosing);
            this.Load += new System.EventHandler(this.Musteri_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Musteri_Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Musteri_Liste;
        private System.Windows.Forms.Button buttonVeri;
    }
}