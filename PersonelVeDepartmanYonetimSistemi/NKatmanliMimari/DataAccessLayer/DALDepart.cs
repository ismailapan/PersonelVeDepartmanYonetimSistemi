using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALDepart
    {
        public static List<EntityDepartment> DepartmentList()
        {
            List<EntityDepartment> departman = new List<EntityDepartment>();
            SqlCommand komut = new SqlCommand("Select * From TBLDEPARTMENT", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDepartment ent = new EntityDepartment();
                ent.Department_id = int.Parse(dr["department_id"].ToString());
                ent.Department_name = dr["department_ad"].ToString();
                ent.Department_task = dr["department_gorev"].ToString();

                departman.Add(ent);
            }
            dr.Close();
            return departman;
        }
        public static int DepartEkle(EntityDepartment d)
        {
            SqlCommand komut = new SqlCommand("Insert Into TBLDEPARTMENT(department_ad,department_gorev) Values (@p1,@p2)",Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1",d.Department_name);
            komut.Parameters.AddWithValue("@p2",d.Department_task);
            return komut.ExecuteNonQuery();
        }
        public static bool DepartSil(int dep)
        {
            SqlCommand komut = new SqlCommand("Delete From TBLDEPARTMENT Where department_id=@p1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", dep);
            return komut.ExecuteNonQuery()>0;
        }
        public static bool DepartGuncel(EntityDepartment dep)
        {
            SqlCommand komut = new SqlCommand("Update TBLDEPARTMENT Set department_ad=@p1,department_gorev=@p2 Where department_id=@p3", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", dep.Department_name);
            komut.Parameters.AddWithValue("@p2", dep.Department_task);
            komut.Parameters.AddWithValue("@p3", dep.Department_id);
            return komut.ExecuteNonQuery()>0;
        }

    }
}
