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
    public partial class Bilgi : Form
    {
        private static Bilgi _instance;

        public Bilgi()
        {
            InitializeComponent();
        }
        public Bilgi instance
        {
            get
            {
                if (Bilgi._instance == null)
                {
                    Bilgi._instance = new Bilgi();
                }
                return Bilgi._instance;
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Bilgi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bilgi._instance = null;

        }

        private void Bilgi_Load(object sender, EventArgs e)
        {

        }
    }
}
