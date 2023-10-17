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
        public static List<EntityWord> KelimeGetir()
        {
            Random rnd=new Random();
            int sayi = rnd.Next(1, 2490);
           
            List<EntityWord> Kelimeler = new List<EntityWord>();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM sozluk WHERE id=@p1",Baglanti.conn);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1",sayi);
            OleDbDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                EntityWord ent=new EntityWord();
                ent.En = dr["ingilizce"].ToString().ToLower();
                ent.Tr = dr["turkce"].ToString().ToLower();
                Kelimeler.Add(ent);
            }
            dr.Close();
            return Kelimeler;
        }

    }
}
