using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis
{
    public partial class Giris_paneli : Form
    {
        public Giris_paneli()
        {
            InitializeComponent();
        }

      

        
        private void Giris_paneli_Load(object sender, EventArgs e)
        {
         
        }

        
        private void Giris_button_Click(object sender, EventArgs e)
        {
            Ana_panel nesne1 = new Ana_panel();
           
     
            if (kullanıcı_text.Text == "Akif" && sifre_text.Text == "1234")
            {
                
                nesne1.Show();
                this.Hide();
                
            }
            else if (kullanıcı_text.Text == "Mahmut" && sifre_text.Text == "1994") {
                nesne1.Show();
                this.Hide();
            }
             

            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris_paneli nesne2 = new Giris_paneli();
            DialogResult dialogResult= MessageBox.Show("Çıkış yapmak istediğinizden eminmisiniz", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                
            }
            else
            {
                
            }

        }
    }
}
