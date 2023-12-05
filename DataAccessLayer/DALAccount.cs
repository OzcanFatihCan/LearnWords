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
            int result= komut.ExecuteNonQuery();
            komut.Connection.Close();
            return result;
        }
        
        public static List<EntityAccount> StatGetir()
        {
            List<EntityAccount> Stat= new List<EntityAccount>();
            OleDbCommand komut2 = new OleDbCommand("SELECT * FROM STATISTICS",Baglanti.conn);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            OleDbDataReader dr = komut2.ExecuteReader();         
            while (dr.Read())
            {
                EntityAccount ent = new EntityAccount();
                ent.Ad = dr["AD"].ToString();
                ent.Dogru = int.Parse(dr["DOGRU"].ToString());
                ent.Kategori = int.Parse(dr["KATEGORI"].ToString());
                Stat.Add(ent);
            }
            dr.Close();
            komut2.Connection.Close();
            return Stat;
        }
    }
}
