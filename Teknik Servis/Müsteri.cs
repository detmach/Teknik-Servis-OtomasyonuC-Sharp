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
    public partial class Müsteri : Form
    {
        private static Müsteri _instance;
        public int ID;
        public string GuncelAd;
        public string GuncelSoyad;
        public string GuncelTel;
        public string GuncelMail;
        public string GuncelTarih;
        public string GuncelTc;
        public string GuncelAciklama;
        public Müsteri()
        {
            InitializeComponent();
        }
        public Müsteri instance {
            get {
                if (Müsteri._instance == null) {
                    Müsteri._instance = new Müsteri();
                }
                return Müsteri._instance;
            }
           
        }



        SqlConnection baglantı = new SqlConnection("Data Source=.;Initial Catalog=AnaPanel;Integrated Security=True");

        public void Listele()
        {
            try
            {
                baglantı.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter("select * from Musteri_Tablosu1", baglantı);
                adaptor.Fill(ds);

                MüsteriVeriler.DataSource = ds.Tables[0];
                MüsteriVeriler.Columns[0].HeaderText = "Sıra No";
                MüsteriVeriler.Columns[1].HeaderText = "İsim";
                MüsteriVeriler.Columns[2].HeaderText = "Soyisim";
                MüsteriVeriler.Columns[3].HeaderText = "Telefon Numarası";
                MüsteriVeriler.Columns[4].HeaderText = "Mail";
                MüsteriVeriler.Columns[5].HeaderText = "Kayıt Tarihi";
                MüsteriVeriler.Columns[6].HeaderText = "Tc No";
                MüsteriVeriler.Columns[7].HeaderText = "Açıklama";


            }
            catch (SqlException hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message,"hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglantı.Close();
            }
        }


        public void KayitEkle(String Müsteri_Ismi, String Müsteri_Sayadi, String Telefon, String email,String Tarih, String Tckn,String Aciklama)
        {
            try
            {
                baglantı.Open();
                SqlCommand ekle = new SqlCommand("insert into Musteri_Tablosu1(isim,soyisim,Telefon_No,Mail_Adresi,Kayit_Tarihi,Tckn,Aciklama)values('"+Müsteri_Ismi+"','"+Müsteri_Sayadi+"','"+Telefon+"','"+email+"','"+Tarih+"','"+Tckn+"','"+Aciklama+"')",baglantı);
                
                ekle.ExecuteNonQuery();

            }


            catch(SqlException ef)
            {
                MessageBox.Show("Hata Oluştu" + ef.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglantı.Close();
            }
        }

        public void KayitSil()
        {
            int satır = MüsteriVeriler.CurrentRow.Index;
            int id = Convert.ToInt32(MüsteriVeriler.Rows[satır].Cells[0].Value);
            try
            {
                baglantı.Open();
                SqlCommand sil = new SqlCommand("delete from Musteri_Tablosu1 where id=" + id, baglantı);
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MüsteriVeriler.Rows.RemoveAt(satır);
            }
            catch (SqlException hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglantı.Close();
            }
          
        }
        public void VeriAl()
        {
            try
            {
                baglantı.Open();
                SqlCommand sorgu = new SqlCommand("select * from Musteri_Tablosu1",baglantı);
                SqlDataReader oku = null;
                sorgu.ExecuteNonQuery();
                oku = sorgu.ExecuteReader();
                while (oku.Read())
                {
                    ID = Convert.ToInt32(oku["id"]);
                    GuncelAd = oku["isim"].ToString();
                    GuncelSoyad = oku["soyisim"].ToString();
                    GuncelTel = oku["Telefon_No"].ToString();
                    GuncelMail = oku["Mail_Adresi"].ToString();
                    GuncelTarih = oku["Kayit_Tarihi"].ToString();
                    GuncelTc = oku["Tckn"].ToString();
                    GuncelAciklama = oku["Aciklama"].ToString();

                }

            }
            catch(SqlException mesaj)
            {
                MessageBox.Show(mesaj.Message);
            }
            finally
            {
                baglantı.Close();
            }
        }

        public void güncelleme(int id,string Yeniad,string Yenisoyad,string Yenitel,string Yenimail,string Yenikayit,string Yenitc,string Yeniaciklama)
        {
            try
            {
                baglantı.Open();
                SqlCommand yguncelle = new SqlCommand("update Musteri_Tablosu1 set isim='"+Yeniad+"',soyisim='"+Yenisoyad+"',Telefon_No='"+Yenitel+"',Mail_Adresi='"+Yenimail+"',Kayit_Tarihi='"+Yenikayit+"',Tckn='"+Yenitc+"',Aciklama='"+Yeniaciklama+"'where id="+id+"'", baglantı);
                yguncelle.ExecuteNonQuery();
            }
            catch(SqlException exss)
            {
                MessageBox.Show(exss.Message);
            }
            finally
            {
                baglantı.Close();
            }
        }
        private void Müsteri_Load(object sender, EventArgs e)
        {
            Listele();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MüsteriVeriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
           KayitEkle(textisim.Text,textsoyisim.Text,texttel.Text,textmail.Text,texttarih.Text,texttckn.Text,textaciklama.Text);

           textisim.Text = " ";
           textsoyisim.Text = " ";
           texttel.Text = " ";
           textmail.Text = " ";
           texttarih.Text = " ";
           texttckn.Text = " ";
           textaciklama.Text = " ";
           Listele();
           
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textisim_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                KayitSil();
                Listele();
            }
            catch (SqlException)
            {
                MessageBox.Show("Kayıt Bulunmamaktadır");
            }
        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
         


            VeriAl();
            güncelle gn = new güncelle (ID,GuncelAd,GuncelSoyad,GuncelTel,GuncelMail,GuncelTarih,GuncelTc,GuncelAciklama);
            gn.Show();
        }

        private void Müsteri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Müsteri._instance = null;
        }

    }
}
