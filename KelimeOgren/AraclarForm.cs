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

        private void AraclarForm_Load(object sender, EventArgs e)
        {
            List<EntityAccount> Stat = LogicAccount.LLStatGetir();
            dataGridView1.DataSource= Stat;
        }
    }
}
