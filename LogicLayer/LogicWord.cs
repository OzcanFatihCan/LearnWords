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

        public static List<EntityWord> LLSohbetKafeKelime(int sayi)
        {
            if (!string.IsNullOrEmpty(sayi.ToString()))
            {
                return DALWord.SohbetKafeKelimeGetir(sayi);
            }
            else
            {
                return null;
            }
        }
        public static List<EntityWord> LLTabloKelimeGetir(string tabloAdi)
        {
            if (!string.IsNullOrEmpty(tabloAdi))
            {
                return DALWord.TabloKelimeGetir(tabloAdi);
            }
            else
            {
                return null;
            }
        }

        public static List<EntityWord> LLKelimeAra(string tabloAdi, string arananKelime)
        {
            if (!string.IsNullOrEmpty(tabloAdi))
            {
                return DALWord.KelimeAra(tabloAdi,arananKelime);
            }
            else
            {
                return null;
            }
        }

        public static List<EntityWord> LLAlisverisKelime(int sayi)
        {
            if (!string.IsNullOrEmpty(sayi.ToString()))
            {
                return DALWord.AlisverisKelimeGetir(sayi);
            }
            else
            {
                return null;
            }
        }

        public static int LLKelimeEkle(string tabloAdi, EntityWord ent)
        {
            if (!string.IsNullOrEmpty(tabloAdi) &&
                !string.IsNullOrEmpty(ent.En)&&
                !string.IsNullOrEmpty(ent.Tr)&&
                !string.IsNullOrEmpty(ent.Kategori.ToString()))
            {
                return DALWord.KelimeEkle(tabloAdi,ent);
            }
            else
            {
                return -1;
            }
        }
    }
}
