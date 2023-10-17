using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOgren
{
    public partial class KelimeAna : Form
    {
        public KelimeAna()
        {
            InitializeComponent();
        }
        int sure = 90;
        int kelime = 0;
        string cevap;

        void getir()
        {
            List<EntityWord> Kelimeler = LogicWord.LLKelimeGetir();
            foreach (var item in Kelimeler)
            {
                TxtEN.Text = item.En;
                cevap = item.Tr;             
            }
        }
        private void KelimeAna_Load(object sender, EventArgs e)
        {
            getir();
            TxtTR.Focus();
            timer1.Start();
        }

        private void TxtTR_TextChanged(object sender, EventArgs e)
        {
            if (TxtTR.Text==cevap)
            {
                kelime++;
                LblKelime.Text = kelime.ToString();
                getir();
                TxtTR.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSüre.Text = sure.ToString();
            if (sure==0)
            {
                timer1.Stop();
                MessageBox.Show("Süre Doldu", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sure = 90;
                kelime = 0;               
            }
        }
    }
}
