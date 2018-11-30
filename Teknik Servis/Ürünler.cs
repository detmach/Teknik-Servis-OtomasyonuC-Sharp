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
    public partial class Ürünler : Form
    {
        private static Ürünler _instance;
        public Ürünler()
        {
            InitializeComponent();
        }
        public Ürünler instance
        {
            get
            {
                if (Ürünler._instance == null)
                {
                    Ürünler._instance = new Ürünler();
                }
                return Ürünler._instance;
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-3FJEJ5B;Initial Catalog=AnaPanel;Integrated Security=True");

        public String returnId(String firma_adi) {
            String a=firma_adi;
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("select id from firmalar where firma='"+a+"'", baglantı);
            int valuee =(int)ekle.ExecuteScalar();
            string value = valuee.ToString();
            ekle.ExecuteNonQuery();
            baglantı.Close();
            return value;
        }
        
        public void KayitEkle(String Cihaz_Ismi, String Cihaz_Modeli)
        {
            try
            {
                String value = returnId(Cihaz_Ismi);
                baglantı.Open();
                SqlCommand ekle = new SqlCommand("insert into Cihazlar(firma_id,Cihaz_Modeli)values('"+value+"','"+Cihaz_Modeli+"')",baglantı);
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
        public void KayitSil()
        {
            int satır = dataGridÜrünler.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridÜrünler.Rows[satır].Cells[0].Value);
            try
            {
                baglantı.Open();
                SqlCommand sil = new SqlCommand("delete from Cihazlar where id=" + id, baglantı);
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridÜrünler.Rows.RemoveAt(satır);
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
        public void Listele()
        {
            try
            {
                baglantı.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter("select * from Cihazlar", baglantı);
                adaptor.Fill(ds);

                dataGridÜrünler.DataSource = ds.Tables[0];
                dataGridÜrünler.Columns[0].HeaderText = "Sıra No";
                dataGridÜrünler.Columns[1].HeaderText = "Ürünün Markası";
                dataGridÜrünler.Columns[2].HeaderText = "Ürünün Modeli";
             


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


        private void dataGridÜrünler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ürünler_Load(object sender, EventArgs e)
        {

            this.dataGridÜrünler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Listele();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=AnaPanel;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM firmalar";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {



                comboBoxFirma.Items.Add(dr["firma"]);
            }
            baglanti.Close();
            
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            KayitEkle(comboBoxFirma.Text,textBoxModel.Text );

            comboBoxFirma.Text = "";
            textBoxModel.Text = " ";
        
            Listele();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Ürünler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ürünler._instance = null;
        }
        }
    }

