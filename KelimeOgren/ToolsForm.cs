using EntityLayer;
using LogicLayer;
using MaterialSkin;
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
    public partial class ToolsForm : MaterialForm
    {
      
        public ToolsForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);          
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey700, Primary.BlueGrey600, Accent.LightBlue200, TextShade.BLACK);
            
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
                    dataGridView1.Rows[rowIndex].Cells[2].Value = "Sohbet, Kafe & Restoran";
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

        void TabloGetir(string TabloAdi)
        {
            List<EntityWord> Tablolar = LogicWord.LLTabloKelimeGetir(TabloAdi);
            if (Tablolar != null)
            {
                foreach (var item in Tablolar)
                {
                    dataGridView2.Rows.Add(item.En, item.Tr);
                }
            }
            else
            {
                MessageBox.Show("İlgili tablonun içeriği şu an boş","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void CmbKelimeKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            if (CmbKelimeKategori.SelectedItem.ToString() == "İş Kelimeleri")
            {
                TabloGetir("JOBWORD");
            }
            if (CmbKelimeKategori.SelectedItem.ToString() == "His ve Duygu")
            {
                TabloGetir("EMOTEFEELWORD");
            }
            if (CmbKelimeKategori.SelectedItem.ToString() == "Gezi ve Seyehat")
            {
                TabloGetir("TRAVELWORD");
            }
            if (CmbKelimeKategori.SelectedItem.ToString() == "Fiiler")
            {
                TabloGetir("VERBWORD");
            }
            if (CmbKelimeKategori.SelectedItem.ToString() == "Sıfatlar")
            {
                TabloGetir("ADJECTIVEWORD");
            }
            if (CmbKelimeKategori.SelectedItem.ToString() == "Cihazlar")
            {
                TabloGetir("HOMEDEVICESWORD");
            }
            if (CmbKelimeKategori.SelectedItem.ToString() == "Sohbet, Kafe & Restoran")
            {
                TabloGetir("CHATCAFEWORD");
            }
            if (CmbKelimeKategori.SelectedItem.ToString() == "Karışık")
            {
                TabloGetir("MIXEDWORD");
            }
            if (CmbKelimeKategori.SelectedItem.ToString() == "Alışveriş")
            {
                TabloGetir("SHOPPINGWORD");
            }
            if (CmbKelimeKategori.SelectedItem.ToString() == "A1 Kelimeler")
            {
                TabloGetir("A1WORD");
            }
            if (CmbKelimeKategori.SelectedItem.ToString() == "A2 Kelimeler")
            {
                TabloGetir("A2LWORD");
            }
            if (CmbKelimeKategori.SelectedItem.ToString() == "B1 Kelimeler")
            {
                TabloGetir("B1WORD");
            }

        }
    }
}
