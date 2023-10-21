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
    public partial class Kelimeler : Form
    {
        public Kelimeler()
        {
            InitializeComponent();
        }
        int sure = 90;
        int kelime = 0;
        string cevap;
        public int kategori;
        public string kullaniciad;
        
        void kelimegetir(int kategori)
        {
            if (kategori==1)
            {
                List<EntityWord> Kelimeler = LogicWord.LLISKelime(kategori);
                foreach (var item in Kelimeler)
                {
                    TxtEN.Text = item.En;
                    cevap = item.Tr;
                    label4.Text = "Kategori: İş Kelimeleri";
                }
                return;
            }
            if(kategori==2)
            {
                List<EntityWord> Kelimeler = LogicWord.LLDuyguHisKelime(kategori);
                foreach (var item in Kelimeler)
                {
                    TxtEN.Text = item.En;
                    cevap = item.Tr;
                    label4.Text = "Kategori: Duygu ve Hisler";
                }
                return;
            }
            if (kategori == 3)
            {
                List<EntityWord> Kelimeler = LogicWord.LLSeyahatGeziKelime(kategori);
                foreach (var item in Kelimeler)
                {
                    TxtEN.Text = item.En;
                    cevap = item.Tr;
                    label4.Text = "Kategori: Seyehat ve Gezi";
                }
                return;
            }
            if (kategori == 4)
            {
                List<EntityWord> Kelimeler = LogicWord.LLFiilKelime(kategori);
                foreach (var item in Kelimeler)
                {
                    TxtEN.Text = item.En;
                    cevap = item.Tr;
                    label4.Text = "Kategori: Fiiler";
                }
                return;
            }
            if (kategori == 5)
            {
                List<EntityWord> Kelimeler = LogicWord.LLSıfatKelime(kategori);
                foreach (var item in Kelimeler)
                {
                    TxtEN.Text = item.En;
                    cevap = item.Tr;
                    label4.Text = "Kategori: Sıfatlar";
                }
                return;
            }
            else
            {
                MessageBox.Show("Hazırlık aşamasındayız", "Yükleniyor...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void stat(int dogru)
        {
            EntityAccount ent = new EntityAccount();
            ent.Ad = kullaniciad;
            ent.Kategori = kategori;
            ent.Dogru = dogru;
            LogicAccount.LLStatEkle(ent);           
        }
        private void KelimeAna_Load(object sender, EventArgs e)
        {              
            BtnPas.Enabled=false;         
        }

        private void TxtTR_TextChanged(object sender, EventArgs e)
        {
            if (TxtTR.Text==cevap)
            {
                kelime++;
                LblKelime.Text = kelime.ToString();
                kelimegetir(kategori);
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
                BtnBaslat.Enabled = true;
                BtnPas.Enabled = false;
                TxtTR.Enabled = false;
                MessageBox.Show("Süre Doldu", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stat(kelime);
                sure = 90;
                kelime = 0;               
            }
        }

        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            BtnBaslat.Enabled = false;
            BtnPas.Enabled = true;
            TxtTR.Enabled = true;

            kelimegetir(kategori);
        }

        private void BtnPas_Click(object sender, EventArgs e)
        {
            kelimegetir(kategori);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MenuForm frm=new MenuForm();
            frm.Show();
            this.Close();
        }

        private void BtnStat_Click(object sender, EventArgs e)
        {
            AraclarForm frm=new AraclarForm();
            frm.Show();
        }
    }
}
