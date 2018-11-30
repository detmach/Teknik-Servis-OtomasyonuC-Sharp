using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Teknik_Servis
{
    public partial class Ana_panel : Form
    {
        public Ana_panel()
        {
            InitializeComponent();
        }
    
  
        private void Ana_panel_Load(object sender, EventArgs e)
        {

        }


        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Giris_paneli nesne1 = new Giris_paneli();
            Ana_panel nesne3 = new Ana_panel();
            DialogResult dialogResult = MessageBox.Show("Çıkış yapmak istediğinizden eminmisiniz", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                this.Hide();
                nesne1.Show();
            }
        }

        private void buttonTeknisyen_Click(object sender, EventArgs e)
        {
            FormTeknisyen nesne4 = new FormTeknisyen();
            nesne4.Show();
        }
        private void butonMüsteri_Click(object sender, EventArgs e)
        {
            Müsteri m = new Müsteri();
            m.instance.Show();
        }

     
        
        private void buttonTeknisyen_Click_2(object sender, EventArgs e)
        {
            FormTeknisyen nesneTeknisyen = new FormTeknisyen();
            nesneTeknisyen.instance.Show();
        }

        private void buttonAyarlar_Click(object sender, EventArgs e)
        {
        
        }

        private void buttonArıza_Click(object sender, EventArgs e)
        {
            Arıza_Kaydı ariza = new Arıza_Kaydı();
            ariza.instance.Show();
        }
        public void Form_Closed(object sender, FormClosedEventArgs e)
        {
           

        }

        
        private void buttonMusteri_Click(object sender, EventArgs e)
        {
            Musteri_Listesi nesne6 = new Musteri_Listesi();

            Müsteri listenesne = new Müsteri();
            listenesne.Listele();
          
            nesne6.instance.Show();
            listenesne.Listele();
          
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Ürün_Listele nesne = new Ürün_Listele();
            nesne.instance.Show();
            
        }
        
        private void buttonUrun_Click(object sender, EventArgs e)
        {

            Ürünler eklenesne = new Ürünler();
            eklenesne.instance.Show();
        }
       
        private void buttonStok_Click(object sender, EventArgs e)
        {

            Kayıt_Listesi nesne8 = new Kayıt_Listesi();
            nesne8.instance.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Cihaz_Marka_Düzenle tıkla = new Cihaz_Marka_Düzenle();
            tıkla.instance.Show();
            
        }
       
        private void buttonYardım_Click(object sender, EventArgs e)
        {
            Bilgi nesne5 = new Bilgi();

            nesne5.instance.Show();
        }
    }
}
