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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            EntityAccount ent=new EntityAccount();
            ent.Ad = TxtAd.Text;
            int result= LogicAccount.LLStatEkle(ent);
            if (result > 0)
            {
                MenuForm frm = new MenuForm();
                frm.kullanici = TxtAd.Text;
                frm.Show();
                this.Hide();
            }
            else if (result == 0)
            {
                MessageBox.Show("Lütfen isim giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lütfen isim giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
    }
}
