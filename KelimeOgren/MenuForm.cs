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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        public string kullanici;
        
        void Kelimeler(int sayi)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = sayi;
            frm.kullaniciad = kullanici;
            frm.Show();
            this.Hide();            
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnIs_Click(object sender, EventArgs e)
        {
            Kelimeler(1);
        }

        private void BtnHisDuygu_Click(object sender, EventArgs e)
        {
            Kelimeler(2);
        }

        private void BtnGeziSeyehat_Click(object sender, EventArgs e)
        {
            Kelimeler(3);
        }

        private void BtnFiil_Click(object sender, EventArgs e)
        {
            Kelimeler(4);
        }

        private void BtnSifat_Click(object sender, EventArgs e)
        {
            Kelimeler(5);
        }

        private void BtnCihaz_Click(object sender, EventArgs e)
        {
            Kelimeler(6);
        }

        private void BtnKafe_Click(object sender, EventArgs e)
        {
            Kelimeler(7);
        }

        private void BtnKarisik_Click(object sender, EventArgs e)
        {
            Kelimeler(8);
        }

        private void BtnAlisveris_Click(object sender, EventArgs e)
        {
            Kelimeler(9);
        }

        private void BtnA1_Click(object sender, EventArgs e)
        {
            Kelimeler(10);
        }

        private void BtnA2_Click(object sender, EventArgs e)
        {
            Kelimeler(11);
        }

        private void BtnB1_Click(object sender, EventArgs e)
        {
            Kelimeler(12);
        }
    }
}
