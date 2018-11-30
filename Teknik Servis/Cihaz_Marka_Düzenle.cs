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
    public partial class Cihaz_Marka_Düzenle : Form
    {
        private static Cihaz_Marka_Düzenle _instance;
        public Cihaz_Marka_Düzenle()
        {
            InitializeComponent();
        }
        public Cihaz_Marka_Düzenle instance
        {
            get
            {
                if (Cihaz_Marka_Düzenle._instance == null)
                {
                    Cihaz_Marka_Düzenle._instance = new Cihaz_Marka_Düzenle();
                }
                return Cihaz_Marka_Düzenle._instance;
            }

        }
        SqlConnection baglantı = new SqlConnection("Data Source=.;Initial Catalog=AnaPanel;Integrated Security=True");
        public void Listele()
        {
            try
            {
                baglantı.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter("select * from firmalar", baglantı);
                adaptor.Fill(ds);

               ListeleData.DataSource = ds.Tables[0];
               ListeleData.Columns[0].HeaderText = "Sıra Numarası";
                ListeleData.Columns[1].HeaderText = "Cihaz Markası";
                
             



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


        public void KayitSil()
        {
            int satır = ListeleData.CurrentRow.Index;
            int id = Convert.ToInt32(ListeleData.Rows[satır].Cells[0].Value);
            try
            {
                baglantı.Open();
                SqlCommand sil = new SqlCommand("delete from firmalar where id=" + id, baglantı);
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
               ListeleData.Rows.RemoveAt(satır);
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        public void KayitEkle(String firma)
        {
            try
            {
                baglantı.Open();
                SqlCommand ekle = new SqlCommand("insert into firmalar(firma)values('" + firma + "')", baglantı);

                ekle.ExecuteNonQuery();

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

        private void Cihaz_Marka_Düzenle_Load(object sender, EventArgs e)
        {
            this.ListeleData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Listele();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitSil();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitEkle(textBox1.Text);
            textBox1.Text = "";
            Listele();
        }

        private void Cihaz_Marka_Düzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cihaz_Marka_Düzenle._instance = null;
        }
    }
}
