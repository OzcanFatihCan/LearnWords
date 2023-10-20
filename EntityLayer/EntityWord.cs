using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityWord
    {
        private int id;
        private string en;
        private string tr;
        private int kategori;

        public int Id { get => id; set => id = value; }
        public string En { get => en; set => en = value; }
        public string Tr { get => tr; set => tr = value; }
        public int Kategori { get => kategori; set => kategori = value; }
      
    }
}
