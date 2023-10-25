using EntityLayer;
using LogicLayer;
using MaterialSkin.Controls;
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
    public partial class AraclarForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public AraclarForm()
        {
            InitializeComponent();
            materialSkinManager=MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey600,MaterialSkin.Accent.DeepPurple700,
                MaterialSkin.TextShade.WHITE);
        }

        public void OpenTabPage(string tabPageName)
        {
            if (tabPageName == "Kelimeler")
            {
                materialTabControl1.SelectTab(tabPage2);
            }
            else if (tabPageName == "İstatistikler")
            {
                materialTabControl1.SelectTab(tabPage1);
            }
        }

        private void AraclarForm_Load(object sender, EventArgs e)
        {
         
            dataGridView1.Columns.Add("AdColumn", "Ad"); 
            dataGridView1.Columns.Add("DogruColumn", "Doğru"); 
            dataGridView1.Columns.Add("KategoriColumn", "Kategori");
            List<EntityAccount> Stat = LogicAccount.LLStatGetir();
            foreach (var item in Stat)
            {
                int rowIndex = dataGridView1.Rows.Add();                 
                dataGridView1.Rows[rowIndex].Cells[0].Value = item.Ad;         
                dataGridView1.Rows[rowIndex].Cells[1].Value = item.Dogru;               
               
                if (item.Kategori == 1)
                {
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "İş Kelimeleri";
                }
                if (item.Kategori == 2)
                {
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "His ve Duygular";
                }
                if (item.Kategori == 3)
                {
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "Gezi ve Seyehat";
                }
                if (item.Kategori == 4)
                {
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "Fiiler";
                }
                if (item.Kategori == 5)
                {
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "Sıfatlar";
                }
                if (item.Kategori == 6)
                {
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "Cihazlar";
                }
                if (item.Kategori == 7)
                {
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "Sohbet, Kafe";
                }
                if (item.Kategori == 8)
                {
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "Karışık";
                }
                if (item.Kategori == 9)
                {
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "Alışveriş";
                }
                if (item.Kategori == 10)
                {
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "A1 Kelimeler";
                }
                if (item.Kategori == 11)
                {
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "A2 Kelimeler";
                }
                if (item.Kategori == 12)
                {
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "B1 Kelimeler";
                }               
            }           
        }
    }
}
