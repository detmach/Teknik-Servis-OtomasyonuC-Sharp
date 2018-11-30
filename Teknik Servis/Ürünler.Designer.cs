namespace Teknik_Servis
{
    partial class Ürünler
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
            this.dataGridÜrünler = new System.Windows.Forms.DataGridView();
            this.labelCihaz = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.comboBoxFirma = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridÜrünler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridÜrünler
            // 
            this.dataGridÜrünler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridÜrünler.Location = new System.Drawing.Point(-6, 215);
            this.dataGridÜrünler.Name = "dataGridÜrünler";
            this.dataGridÜrünler.Size = new System.Drawing.Size(617, 215);
            this.dataGridÜrünler.TabIndex = 2;
            this.dataGridÜrünler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridÜrünler_CellContentClick);
            // 
            // labelCihaz
            // 
            this.labelCihaz.AutoSize = true;
            this.labelCihaz.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCihaz.Location = new System.Drawing.Point(116, 26);
            this.labelCihaz.Name = "labelCihaz";
            this.labelCihaz.Size = new System.Drawing.Size(72, 16);
            this.labelCihaz.TabIndex = 3;
            this.labelCihaz.Text = "Cihaz İsmi";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelModel.Location = new System.Drawing.Point(116, 83);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(87, 16);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Cihaz Modeli";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(225, 76);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(134, 20);
            this.textBoxModel.TabIndex = 2;
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonSil.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Image = global::Teknik_Servis.Properties.Resources._002_delete_11;
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSil.Location = new System.Drawing.Point(320, 122);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(127, 87);
            this.buttonSil.TabIndex = 4;
            this.buttonSil.Text = "Sil";
            this.buttonSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Gold;
            this.buttonEkle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.Image = global::Teknik_Servis.Properties.Resources._15;
            this.buttonEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEkle.Location = new System.Drawing.Point(119, 122);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(125, 87);
            this.buttonEkle.TabIndex = 3;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // comboBoxFirma
            // 
            this.comboBoxFirma.FormattingEnabled = true;
            this.comboBoxFirma.Location = new System.Drawing.Point(225, 26);
            this.comboBoxFirma.Name = "comboBoxFirma";
            this.comboBoxFirma.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFirma.TabIndex = 1;
            this.comboBoxFirma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Ürünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(610, 426);
            this.Controls.Add(this.comboBoxFirma);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelCihaz);
            this.Controls.Add(this.dataGridÜrünler);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Ürünler";
            this.Text = "Ürünler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ürünler_FormClosing);
            this.Load += new System.EventHandler(this.Ürünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridÜrünler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.DataGridView dataGridÜrünler;
        private System.Windows.Forms.Label labelCihaz;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.ComboBox comboBoxFirma;
    }
}