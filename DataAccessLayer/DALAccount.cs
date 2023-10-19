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
            OleDbCommand komut = new OleDbCommand("INSERT INTO STATISTICS (AD) VALUES (@P1)",Baglanti.conn);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1",ent.Ad);
            return komut.ExecuteNonQuery();
        }
    }
}
