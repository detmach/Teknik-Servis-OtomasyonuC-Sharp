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
    public partial class Ürün_Listele : Form
    {
        private static Ürün_Listele _instance;

        public Ürün_Listele()
        {
            InitializeComponent();
        }
        public Ürün_Listele instance
        {
            get
            {
                if (Ürün_Listele._instance == null)
                {
                    Ürün_Listele._instance = new Ürün_Listele();
                }
                return Ürün_Listele._instance;
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
                SqlDataAdapter adaptor = new SqlDataAdapter("select * from Cihazlar", baglantı);
                adaptor.Fill(ds);

                dataGridUrunListe.DataSource = ds.Tables[0];
                dataGridUrunListe.Columns[0].HeaderText = "Sıra No";
                dataGridUrunListe.Columns[1].HeaderText = "Ürünün Markası";
                dataGridUrunListe.Columns[2].HeaderText = "Ürünün Modeli";
             


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

            
            private void dataGridUrunListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ürün_Listele_Load(object sender, EventArgs e)
        {
             this.dataGridUrunListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Listele();
        }

        private void ı(object sender, EventArgs e)
        {
            this.dataGridUrunListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Listele();
        }

        private void Ürün_Listele_FormClosing(object sender, FormClosingEventArgs e)
        {
           Ürün_Listele._instance = null;
        }
    }
}
