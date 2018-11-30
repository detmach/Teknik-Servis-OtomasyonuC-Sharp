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
    public partial class Arıza_Kaydı : Form
    {
        private static Arıza_Kaydı _instance;
        public static String ad;
        public static String soyad;

        public Arıza_Kaydı()
        {
            InitializeComponent();
        }
        public Arıza_Kaydı instance
        {
            get
            {
                if (Arıza_Kaydı._instance == null)
                {
                    Arıza_Kaydı._instance = new Arıza_Kaydı();
                }
                return Arıza_Kaydı._instance;
            }

        }

        SqlConnection baglantı = new SqlConnection("Data Source=.;Initial Catalog=AnaPanel;Integrated Security=True");

        DateTime Tarih1;
        DateTime Tarih2;

        public void KayitEkle(String Müsteri_Ismi, String Müsteri_Sayadi,  String Serino, String Malzeme, String Arıza, String Fiyat, String Aciklama)
        {
            try
            {
                baglantı.Open();
                String selicideger = Convert.ToDateTime(dateTimePicker2.Text).ToShortDateString();
                String selicideger1 = Convert.ToDateTime(dateTimePicker2.Text).ToShortDateString();
                String ekleme = "insert into ArızaTablo(Musteri_Adı,Musteri_Soyadı,Cihaz_ismi,Cihaz_modeli,Seri_No,Garanti_Durumu,Cinsiyet,Gtarih,Ctarih,Malzeme,Arıza_Tipi,Fiyat,Aciklama)values('" + Müsteri_Ismi + "','" + Müsteri_Sayadi + "','" + comboBoxCisim.Text + "','" + comboBoxModel.Text + "','" + Serino + "','" + comboBoxGaranti.Text + "','" + comboBoxCinsiyet.Text + "','" + selicideger + "','" + selicideger1 + "','" + Malzeme + "','" + Arıza + "','" + Fiyat + "','" + Aciklama + "')";
               SqlCommand ekle = new SqlCommand(ekleme, baglantı);                
                ekle.ExecuteNonQuery();
                baglantı.Close();
          
               

            }


            catch (SqlException ef)
            {
                MessageBox.Show("Hata Oluştu" + ef.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglantı.Close();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }


        private void Arıza_Kaydı_Load(object sender, EventArgs e)
        {
            comboBoxGaranti.Items.Add("Garanti Var");

            comboBoxGaranti.Items.Add("Garanti Yok");
            comboBoxCinsiyet.Items.Add("Bay");

            comboBoxCinsiyet.Items.Add("Bayan");
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-3FJEJ5B;Initial Catalog=AnaPanel;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM firmalar";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxCisim.Items.Add(dr["firma"]);
            }
            baglanti.Close();
        }

        public String returnId(String firma_adi)
        {
            String a = firma_adi;
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("select id from firmalar where firma='" + a + "'", baglantı);
            int valuee = (int)ekle.ExecuteScalar();
            string value = valuee.ToString();
            ekle.ExecuteNonQuery();
            baglantı.Close();
            return value;
        }
        private void buttonGelisEkle_Click(object sender, EventArgs e)
        {
            Tarih1 = dateTimePicker1.Value;
            GelisTarih.Text = Tarih1.ToString();

        }

        private void buttonGelisEkle2_Click(object sender, EventArgs e)
        {
            Tarih2 = dateTimePicker2.Value;
            CikisTarih.Text = Tarih2.ToString();
        }
        public void doldur(String id) {
            comboBoxModel.Items.Clear();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-3FJEJ5B;Initial Catalog=AnaPanel;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT Cihaz_Modeli FROM Cihazlar where firma_id='" + id + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxModel.Items.Add(dr["Cihaz_Modeli"]);
            }
            baglanti.Close();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String deger = returnId(comboBoxCisim.Text);
            doldur(deger);
        }

        private void buttonKayıt_Click(object sender, EventArgs e)
        {
            KayitEkle(textBoxAdı.Text, textBoxSoyadı.Text, textBoxSeri.Text, textBoxMalzeme.Text, textBoxArıza.Text, textBoxBirim.Text, textBoxAciklama.Text);


            textBoxAdı.Text = " ";
            textBoxSoyadı.Text = " ";
            textBoxSeri.Text = " ";
            textBoxMalzeme.Text = " ";
            textBoxArıza.Text = " ";
            textBoxBirim.Text = " ";
            textBoxAciklama.Text = " ";

           
      
        }

  

   

        private void comboBoxGaranti_SelectedIndexChanged(object sender, EventArgs e)
        {
      

           
        }

        private void comboBoxCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            

        }
      

        private void buttonAra_Click(object sender, EventArgs e)
        {
            Musteri_Listesi musteri = new Musteri_Listesi();
            musteri.Show();
            musteri.FormClosed += new FormClosedEventHandler(Form_Closed);
            
           
        }

       public void Form_Closed(object sender, FormClosedEventArgs e)
        {
            textBoxAdı.Text = ad;
            textBoxSoyadı.Text = soyad;
            
        }

       private void Arıza_Kaydı_FormClosing(object sender, FormClosingEventArgs e)
       {
           Arıza_Kaydı._instance = null;
       }

    }
}
