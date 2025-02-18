using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using EntityLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int LLPersonelEkle(EntityPersonel p) 
        {
            if(p.Ad !="" && p.Soyad !="" && p.Maas>=22700 && p.Ad.Length >= 2)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLPersonelSil(int per)
        {
            if(per >= 0)
            {
                return DALPersonel.PersonelSil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LLPersonelGuncel(EntityPersonel p)
        {
            if (p.Ad != null && p.Soyad != null && p.Maas >= 22700 && p.Ad.Length >= 2)
            {
                return DALPersonel.PersonelGuncel(p);
            }
            else 
            {
                return false;   
            }
        }
    }
}
