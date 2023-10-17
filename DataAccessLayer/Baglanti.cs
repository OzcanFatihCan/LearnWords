using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static OleDbConnection conn=new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Projeler\\C#Projeler\\GitProje\\KelimeOgren\\dbSozluk.accdb");
    }
}
