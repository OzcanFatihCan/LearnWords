using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityAccount
    {
        private string ad;
        private int dogru;
        private int kategori;
        private double basari;

        public string Ad { get => ad; set => ad = value; }
        public int Dogru { get => dogru; set => dogru = value; }
        public int Kategori { get => kategori; set => kategori = value; }
        public double Basari { get => basari; set => basari = value; }
    }
}
