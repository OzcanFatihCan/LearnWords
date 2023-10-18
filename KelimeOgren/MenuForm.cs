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

        
        private void BtnKarisik_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 8;
            frm.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnIs_Click(object sender, EventArgs e)
        {
            Kelimeler frm = new Kelimeler();
            frm.kategori = 1;
            frm.Show();
        }
    }
}
