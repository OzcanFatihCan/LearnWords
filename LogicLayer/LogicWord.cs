using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LogicWord
    {
        public static List<EntityWord> LLISKelime(int sayi)
        {
            if (!string.IsNullOrEmpty(sayi.ToString()))
            {
                return DALWord.IsKelimeGetir(sayi);
            }
            else
            {
                return null;
            }
        }

    }
}
