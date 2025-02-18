using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("Select * From TBLPERSONEL",Baglanti.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["SICILNO"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();  
                ent.Sehir = dr["SEHIR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas =decimal.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut1 = new SqlCommand("Insert Into TBLPERSONEL(AD,SOYAD,SEHIR,GOREV,MAAS) Values (@p1,@p2,@p3,@p4,@p5)",Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", p.Ad);
            komut1.Parameters.AddWithValue("@p2", p.Soyad);
            komut1.Parameters.AddWithValue("@p3", p.Sehir);
            komut1.Parameters.AddWithValue("@p4", p.Gorev);
            komut1.Parameters.AddWithValue("@p5", p.Maas);
             return komut1.ExecuteNonQuery();
        }
        public static bool PersonelSil(int p)
        {
            SqlCommand komut2 = new SqlCommand("Delete From TBLPERSONEL Where SICILNO=@p1",Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p);
            return komut2.ExecuteNonQuery()>0;
        }
        public static bool PersonelGuncel(EntityPersonel gun)
        {
            SqlCommand komut3 = new SqlCommand("Update TBLPERSONEL Set AD=@p1,SOYAD=@p2,SEHIR=@p3,GOREV=@p4,MAAS=@p5 where SICILNO=@p6",Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", gun.Ad);
            komut3.Parameters.AddWithValue("@p2", gun.Soyad);
            komut3.Parameters.AddWithValue("@p3", gun.Sehir);
            komut3.Parameters.AddWithValue("@p4", gun.Gorev);
            komut3.Parameters.AddWithValue("@p5", gun.Maas);
            komut3.Parameters.AddWithValue("@p6", gun.Id);
            return komut3.ExecuteNonQuery()>0;

        }
    }
}
