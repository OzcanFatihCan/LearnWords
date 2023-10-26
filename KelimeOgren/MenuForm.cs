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
        private WordsForm kelimeForm = null;

        void Kelimeler(int sayi)
        {
            if (kelimeForm == null || kelimeForm.IsDisposed)
            {
                kelimeForm = new WordsForm();
                kelimeForm.kategori = sayi;
                kelimeForm.kullaniciad = kullanici;
                this.Close();
                kelimeForm.Show();           
            }
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
    }
}
