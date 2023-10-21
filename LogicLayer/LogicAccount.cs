using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LogicAccount
    {
        public static int LLStatEkle(EntityAccount ent)
        {
            if (ent.Ad!="")
            {
               return DALAccount.StatEkle(ent);
            }
            else
            {
               return -1;
            }
        }

        public static List<EntityAccount> llStatGetir(EntityAccount ent)
        {
            return DALAccount.StatGetir();
        }
    }
}
