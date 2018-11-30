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
    public partial class güncelle : Form
    {
        public string textisim = "", textsoyisim = "", texttel = "", textmail = "", texttarih = "", texttckn = "", textaciklama = "";
        public int Id;

        public güncelle()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        public güncelle(int id,string adi,string soyad, string tel,string mail,string tarih,string tc, string aciklama)
        {
            InitializeComponent();

            Id = id;
            textisim = adi;
            textsoyisim = soyad;
            texttel = tel;
            textmail = mail;
            texttarih = tarih;
            texttckn = tc;
            textaciklama = aciklama;




        }

        private void güncelle_Load(object sender, EventArgs e)
        {
          textAD.Text=textisim;
            textSOYAD.Text= textsoyisim;
           textTELE.Text=texttel;
            textMAİL.Text= textmail ;
           textKTarih.Text=texttarih ;
            textTC.Text=texttckn ;
            textACİKLAMA.Text= textaciklama ;

        }

       
    }
}
