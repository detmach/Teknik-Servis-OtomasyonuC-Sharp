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
    public partial class FormTeknisyen : Form
    {
        private static FormTeknisyen _instance;

        public FormTeknisyen()
        {
            InitializeComponent();
        }
        public FormTeknisyen instance
        {
            get
            {
                if (FormTeknisyen._instance == null)
                {
                    FormTeknisyen._instance = new FormTeknisyen();
                }
                return FormTeknisyen._instance;
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void FormTeknisyen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormTeknisyen_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormTeknisyen._instance = null;

        }
    }
}
