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
    
    public partial class Musteri_Listesi : Form
    {
        private static Musteri_Listesi _instance;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        public Musteri_Listesi()
        {
            InitializeComponent();
        }
        public Musteri_Listesi instance
        {
            get
            {
                if (Musteri_Listesi._instance == null)
                {
                    Musteri_Listesi._instance = new Musteri_Listesi();
                }
                return Musteri_Listesi._instance;
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

                Musteri_Liste.DataSource = ds.Tables[0];
                Musteri_Liste.Columns[0].HeaderText = "Sıra No";
                Musteri_Liste.Columns[1].HeaderText = "İsim";
                Musteri_Liste.Columns[2].HeaderText = "Soyisim";
                Musteri_Liste.Columns[3].HeaderText = "Telefon Numarası";
                Musteri_Liste.Columns[4].HeaderText = "Mail";
                Musteri_Liste.Columns[5].HeaderText = "Kayıt Tarihi";
                Musteri_Liste.Columns[6].HeaderText = "Tc No";
                Musteri_Liste.Columns[7].HeaderText = "Açıklama";


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

        public void dondur() {
            int satır = Musteri_Liste.CurrentRow.Index;
            String isim = Convert.ToString(Musteri_Liste.Rows[satır].Cells[1].Value);
            String soyad = Convert.ToString(Musteri_Liste.Rows[satır].Cells[2].Value);
            Arıza_Kaydı.ad = isim;
            Arıza_Kaydı.soyad = soyad;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Musteri_Listesi_Load(object sender, EventArgs e)
        {
            this.Musteri_Liste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Listele();
        }

        private void buttonVeri_Click(object sender, EventArgs e)
        {
            dondur();
            this.Close();
            
            
        }

        private void Musteri_Listesi_FormClosing(object sender, FormClosingEventArgs e)
        {
           Musteri_Listesi._instance = null;
        }
    }
}
