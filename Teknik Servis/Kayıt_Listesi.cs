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
    public partial class Kayıt_Listesi : Form
    {
        private static Kayıt_Listesi _instance;

        public Kayıt_Listesi()
        {
            InitializeComponent();
        }
        public Kayıt_Listesi instance
        {
            get
            {
                if (Kayıt_Listesi._instance == null)
                {
                    Kayıt_Listesi._instance = new Kayıt_Listesi();
                }
                return Kayıt_Listesi._instance;
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        SqlConnection baglantı = new SqlConnection("Data Source=.;Initial Catalog=AnaPanel;Integrated Security=True");
        public void Listele()
        {
            try
            {
                baglantı.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter("select * from ArızaTablo", baglantı);
                adaptor.Fill(ds);

                dataGridViewKayıt.DataSource = ds.Tables[0];
                dataGridViewKayıt.Columns[0].HeaderText = "Sıra No";
                dataGridViewKayıt.Columns[1].HeaderText = "İsim";
                dataGridViewKayıt.Columns[2].HeaderText = "Soyisim";
                dataGridViewKayıt.Columns[3].HeaderText = "Cihazın İsmi";
                dataGridViewKayıt.Columns[4].HeaderText = "Cihazın Modeli";
                dataGridViewKayıt.Columns[5].HeaderText = "Seri No";
                dataGridViewKayıt.Columns[6].HeaderText = "Garanti Durumu";
                dataGridViewKayıt.Columns[7].HeaderText = "Cinsiyet";
                dataGridViewKayıt.Columns[8].HeaderText = "Geliş Tarihi";
                dataGridViewKayıt.Columns[9].HeaderText = "Çıkış Tarihi";
                dataGridViewKayıt.Columns[10].HeaderText = "Kullanılan Malzeme";
                dataGridViewKayıt.Columns[11].HeaderText = "Arıza Tipi";
                dataGridViewKayıt.Columns[12].HeaderText = "Fiyat";
                dataGridViewKayıt.Columns[13].HeaderText = "Açıklama";
              


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Kayıt_Listesi_Load(object sender, EventArgs e)
        {
            this.dataGridViewKayıt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Listele();
        }

        private void Kayıt_Listesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kayıt_Listesi._instance = null;

        }
    }
}
