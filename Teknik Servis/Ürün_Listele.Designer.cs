namespace Teknik_Servis
{
    partial class Ürün_Listele
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
            this.dataGridUrunListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUrunListe
            // 
            this.dataGridUrunListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunListe.Location = new System.Drawing.Point(-1, -3);
            this.dataGridUrunListe.Name = "dataGridUrunListe";
            this.dataGridUrunListe.Size = new System.Drawing.Size(674, 410);
            this.dataGridUrunListe.TabIndex = 0;
            this.dataGridUrunListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUrunListe_CellContentClick);
            // 
            // Ürün_Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 405);
            this.Controls.Add(this.dataGridUrunListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Ürün_Listele";
            this.Text = "Ürün Listele";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ürün_Listele_FormClosing);
            this.Load += new System.EventHandler(this.ı);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUrunListe;
    }
}