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

        public static List<EntityWord> LLDuyguHisKelime(int sayi)
        {
            if (!string.IsNullOrEmpty(sayi.ToString()))
            {
                return DALWord.DuyguHisKelimeGetir(sayi);
            }
            else
            {
                return null;
            }
        }

        public static List<EntityWord> LLSeyahatGeziKelime(int sayi)
        {
            if (!string.IsNullOrEmpty(sayi.ToString()))
            {
                return DALWord.SeyahatGeziKelimeGetir(sayi);
            }
            else
            {
                return null;
            }
        }
        public static List<EntityWord> LLFiilKelime(int sayi)
        {
            if (!string.IsNullOrEmpty(sayi.ToString()))
            {
                return DALWord.FiilKelimeGetir(sayi);
            }
            else
            {
                return null;
            }
        }

        public static List<EntityWord> LLSıfatKelime(int sayi)
        {
            if (!string.IsNullOrEmpty(sayi.ToString()))
            {
                return DALWord.SıfatKelimeGetir(sayi);
            }
            else
            {
                return null;
            }
        }

        public static List<EntityWord> LLCihazKelime(int sayi)
        {
            if (!string.IsNullOrEmpty(sayi.ToString()))
            {
                return DALWord.CihazKelimeGetir(sayi);
            }
            else
            {
                return null;
            }
        }
    }
}
