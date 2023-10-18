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

        
       

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnIs_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 1;
            frm.Show();
            this.Hide();
        }

        private void BtnHisDuygu_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 2;
            frm.Show();
            this.Hide();

        }

        private void BtnGeziSeyehat_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 3;
            frm.Show();
            this.Hide();

        }

        private void BtnFiil_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 4;
            frm.Show();
            this.Hide();

        }

        private void BtnSifat_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 5;
            frm.Show();
            this.Hide();

        }

        private void BtnCihaz_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 6;
            frm.Show();
            this.Hide();

        }

        private void BtnKafe_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 7;
            frm.Show();
            this.Hide();

        }

        private void BtnKarisik_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 8;
            frm.Show();
            this.Hide();

        }

        private void BtnAlisveris_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 9;
            frm.Show();
            this.Hide();

        }

        private void BtnA1_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 10;
            frm.Show();
            this.Hide();

        }

        private void BtnA2_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 11;
            frm.Show();
            this.Hide();

        }

        private void BtnB1_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 12;
            frm.Show();
            this.Hide();

        }
    }
}
