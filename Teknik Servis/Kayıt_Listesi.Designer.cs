namespace Teknik_Servis
{
    partial class Kayıt_Listesi
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
            this.dataGridViewKayıt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKayıt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKayıt
            // 
            this.dataGridViewKayıt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKayıt.Location = new System.Drawing.Point(2, 1);
            this.dataGridViewKayıt.Name = "dataGridViewKayıt";
            this.dataGridViewKayıt.Size = new System.Drawing.Size(1021, 414);
            this.dataGridViewKayıt.TabIndex = 0;
            this.dataGridViewKayıt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Kayıt_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 407);
            this.Controls.Add(this.dataGridViewKayıt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Kayıt_Listesi";
            this.Text = "Kayıt Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kayıt_Listesi_FormClosing);
            this.Load += new System.EventHandler(this.Kayıt_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKayıt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKayıt;
    }
}