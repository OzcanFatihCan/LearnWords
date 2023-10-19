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
    public class DALAccount
    {
        public static int StatEkle(EntityAccount ent)
        {
            OleDbCommand komut = new OleDbCommand("INSERT INTO STATISTICS (AD,DOGRU,KATEGORI) VALUES (@P1,@P2,@P3)",Baglanti.conn);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1",ent.Ad);
            komut.Parameters.AddWithValue("@P2", ent.Dogru);
            komut.Parameters.AddWithValue("@P3", ent.Kategori);
            
            return komut.ExecuteNonQuery();
        }
        
    }
}
