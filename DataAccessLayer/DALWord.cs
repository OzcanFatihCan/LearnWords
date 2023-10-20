using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALWord
    {       
        public static List<EntityWord> IsKelimeGetir(int kategori)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 92);

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

        public static List<EntityWord> DuyguHisKelimeGetir(int kategori)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 40);

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

        public static List<EntityWord> SeyahatGeziKelimeGetir(int kategori)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 43);

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
    }
}
