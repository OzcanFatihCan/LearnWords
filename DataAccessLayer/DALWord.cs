using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALWord
    {       
        public static List<EntityWord> IsKelimeGetir(int kategori)
        {   
            try
            {
                int boyut = 0;
                List<EntityWord> boyutKontrol = TabloKelimeGetir("JOBWORD");
                foreach (var item in boyutKontrol)
                {
                    boyut++;
                }
                Random rnd = new Random();
                int sayi = rnd.Next(1, boyut + 1);

                List<EntityWord> Kelimeler = new List<EntityWord>();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM JOBWORD WHERE ID=@P1 and KATEGORI=@P2", Baglanti.conn);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@P1", sayi);
                komut.Parameters.AddWithValue("@P2", kategori);
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityWord ent = new EntityWord();
                    ent.En = dr["EN"].ToString().ToLower();
                    ent.Tr = dr["TR"].ToString().ToLower();
                    Kelimeler.Add(ent);
                }
                dr.Close();
                return Kelimeler;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<EntityWord> DuyguHisKelimeGetir(int kategori)
        {
            try
            {
                int boyut = 0;
                List<EntityWord> boyutKontrol = TabloKelimeGetir("EMOTEFEELWORD");
                foreach (var item in boyutKontrol)
                {
                    boyut++;
                }
                Random rnd = new Random();
                int sayi = rnd.Next(1, boyut + 1);

                List<EntityWord> Kelimeler = new List<EntityWord>();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM EMOTEFEELWORD WHERE ID=@P1 and KATEGORI=@P2", Baglanti.conn);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@P1", sayi);
                komut.Parameters.AddWithValue("@P2", kategori);
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityWord ent = new EntityWord();
                    ent.En = dr["EN"].ToString().ToLower();
                    ent.Tr = dr["TR"].ToString().ToLower();
                    Kelimeler.Add(ent);
                }
                dr.Close();
                return Kelimeler;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntityWord> SeyahatGeziKelimeGetir(int kategori)
        {
            try
            {
                int boyut = 0;
                List<EntityWord> boyutKontrol = TabloKelimeGetir("TRAVELWORD");
                foreach (var item in boyutKontrol)
                {
                    boyut++;
                }
                Random rnd = new Random();
                int sayi = rnd.Next(1, boyut + 1);

                List<EntityWord> Kelimeler = new List<EntityWord>();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM TRAVELWORD WHERE ID=@P1 and KATEGORI=@P2", Baglanti.conn);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@P1", sayi);
                komut.Parameters.AddWithValue("@P2", kategori);
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityWord ent = new EntityWord();
                    ent.En = dr["EN"].ToString().ToLower();
                    ent.Tr = dr["TR"].ToString().ToLower();
                    Kelimeler.Add(ent);
                }
                dr.Close();
                return Kelimeler;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<EntityWord> FiilKelimeGetir(int kategori)
        {
            try
            {
                int boyut = 0;
                List<EntityWord> boyutKontrol = TabloKelimeGetir("VERBWORD");
                foreach (var item in boyutKontrol)
                {
                    boyut++;
                }
                Random rnd = new Random();
                int sayi = rnd.Next(1, boyut + 1);

                List<EntityWord> Kelimeler = new List<EntityWord>();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM VERBWORD WHERE ID=@P1 and KATEGORI=@P2", Baglanti.conn);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@P1", sayi);
                komut.Parameters.AddWithValue("@P2", kategori);
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityWord ent = new EntityWord();
                    ent.En = dr["EN"].ToString().ToLower();
                    ent.Tr = dr["TR"].ToString().ToLower();
                    Kelimeler.Add(ent);
                }
                dr.Close();
                return Kelimeler;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<EntityWord> SıfatKelimeGetir(int kategori)
        {
            try
            {
                int boyut = 0;
                List<EntityWord> boyutKontrol = TabloKelimeGetir("ADJECTIVEWORD");
                foreach (var item in boyutKontrol)
                {
                    boyut++;
                }
                Random rnd = new Random();
                int sayi = rnd.Next(1, boyut + 1);

                List<EntityWord> Kelimeler = new List<EntityWord>();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM ADJECTIVEWORD WHERE ID=@P1 and KATEGORI=@P2", Baglanti.conn);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@P1", sayi);
                komut.Parameters.AddWithValue("@P2", kategori);
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityWord ent = new EntityWord();
                    ent.En = dr["EN"].ToString().ToLower();
                    ent.Tr = dr["TR"].ToString().ToLower();
                    Kelimeler.Add(ent);
                }
                dr.Close();
                return Kelimeler;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntityWord> CihazKelimeGetir(int kategori)
        {
            try
            {
                int boyut = 0;
                List<EntityWord> boyutKontrol = TabloKelimeGetir("HOMEDEVICESWORD");
                foreach (var item in boyutKontrol)
                {
                    boyut++;
                }
                Random rnd = new Random();
                int sayi = rnd.Next(1, boyut + 1);

                List<EntityWord> Kelimeler = new List<EntityWord>();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM HOMEDEVICESWORD WHERE ID=@P1 and KATEGORI=@P2", Baglanti.conn);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@P1", sayi);
                komut.Parameters.AddWithValue("@P2", kategori);
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityWord ent = new EntityWord();
                    ent.En = dr["EN"].ToString().ToLower();
                    ent.Tr = dr["TR"].ToString().ToLower();
                    Kelimeler.Add(ent);
                }
                dr.Close();
                return Kelimeler;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<EntityWord> SohbetKafeKelimeGetir(int kategori)
        {
            try
            {
                int boyut = 0;
                List<EntityWord> boyutKontrol = TabloKelimeGetir("CHATCAFEWORD");
                foreach (var item in boyutKontrol)
                {
                    boyut++;
                }
                Random rnd = new Random();
                int sayi = rnd.Next(1, boyut + 1);

                List<EntityWord> Kelimeler = new List<EntityWord>();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM CHATCAFEWORD WHERE ID=@P1 and KATEGORI=@P2", Baglanti.conn);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@P1", sayi);
                komut.Parameters.AddWithValue("@P2", kategori);
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityWord ent = new EntityWord();
                    ent.En = dr["EN"].ToString().ToLower();
                    ent.Tr = dr["TR"].ToString().ToLower();
                    Kelimeler.Add(ent);
                }
                dr.Close();
                return Kelimeler;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<EntityWord> TabloKelimeGetir(string tabloAdi)
        {          
            try
            {
                List<EntityWord> KelimeTabloları = new List<EntityWord>();
                string query = "SELECT EN,TR,KATEGORI FROM " + tabloAdi;
                OleDbCommand komut = new OleDbCommand(query, Baglanti.conn);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityWord ent = new EntityWord();
                    ent.En = dr["EN"].ToString().ToLower();
                    ent.Tr = dr["TR"].ToString().ToLower();
                    ent.Kategori =int.Parse(dr["KATEGORI"].ToString());
                 
                    KelimeTabloları.Add(ent);
                }
                dr.Close();
                return KelimeTabloları;
            }
            catch (Exception)
            {
                throw;
            }
        }
       public static List<EntityWord> KelimeAra(string tabloAdi,string arananKelime)
        {
            try
            {
                List<EntityWord> KelimeLog = new List<EntityWord>();
                string query = "SELECT EN,TR,KATEGORI FROM " + tabloAdi + " WHERE "+tabloAdi+ ".EN LIKE '%" + arananKelime + "%' OR "+tabloAdi + ".TR LIKE '%" + arananKelime + "%'";
                OleDbCommand komut = new OleDbCommand(query, Baglanti.conn);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityWord ent = new EntityWord();
                    ent.En = dr["EN"].ToString().ToLower();
                    ent.Tr = dr["TR"].ToString().ToLower();
                    ent.Kategori = int.Parse(dr["KATEGORI"].ToString());

                    KelimeLog.Add(ent);
                }
                return KelimeLog;
            }
            catch (Exception)
            {

                throw;
            }
        }

      
        public static List<EntityWord> AlisverisKelimeGetir(int kategori)
        {
            try
            {
                int boyut=0;
                List<EntityWord> boyutKontrol= TabloKelimeGetir("SHOPPINGWORD");
                foreach (var item in boyutKontrol)
                {                   
                    boyut++;
                }
                Random rnd = new Random();
                int sayi = rnd.Next(1, boyut+1);

                List<EntityWord> Kelimeler = new List<EntityWord>();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM SHOPPINGWORD WHERE ID=@P1 and KATEGORI=@P2", Baglanti.conn);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@P1", sayi);
                komut.Parameters.AddWithValue("@P2", kategori);
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityWord ent = new EntityWord();
                    ent.En = dr["EN"].ToString().ToLower();
                    ent.Tr = dr["TR"].ToString().ToLower();
                    Kelimeler.Add(ent);
                }
                dr.Close();
                return Kelimeler;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int KelimeEkle(string tabloAdi,EntityWord ent)
        {
            try
            {
                string query = "INSERT INTO " + tabloAdi + " (EN,TR,KATEGORI) VALUES (@P1,@P2,@P3)";
                OleDbCommand komut = new OleDbCommand(query, Baglanti.conn);

                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@P1", ent.En);
                komut.Parameters.AddWithValue("@P2", ent.Tr);
                komut.Parameters.AddWithValue("@P3", ent.Kategori);

                return komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntityWord> A1KelimeGetir(int kategori)
        {
            try
            {
                
                List<EntityWord> boyutKontrol = TabloKelimeGetir("A1WORD");
                int boyut = boyutKontrol.Count();
                Random rnd = new Random();
                int sayi = rnd.Next(1, boyut + 1);

                List<EntityWord> Kelimeler = new List<EntityWord>();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM A1WORD WHERE ID=@P1 and KATEGORI=@P2", Baglanti.conn);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@P1", sayi);
                komut.Parameters.AddWithValue("@P2", kategori);
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityWord ent = new EntityWord();
                    ent.En = dr["EN"].ToString().ToLower();
                    ent.Tr = dr["TR"].ToString().ToLower();
                    Kelimeler.Add(ent);
                }
                dr.Close();
                return Kelimeler;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
