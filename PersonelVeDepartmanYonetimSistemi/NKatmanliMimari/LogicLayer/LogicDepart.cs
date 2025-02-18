using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Data;

namespace LogicLayer
{
    public class LogicDepart
    {
        public static List<EntityDepartment> LLDepartmentList()
        {
            return DALDepart.DepartmentList();
        }
        public static int LLDepartmentEkle(EntityDepartment d)
        {
            if(d.Department_name != "" && d.Department_task != "")
            {
                return DALDepart.DepartEkle(d);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLDepartmentSil(int department)
        {
            if(department>=0)
            {
                return DALDepart.DepartSil(department);
            }
            else { return false; }
        }
        public static bool LLDepartmentGuncel(EntityDepartment department)
        {
            if(department.Department_name!= null && department.Department_task!= null)
            {
                return DALDepart.DepartGuncel(department);
            }
            else
            {
                return false;
            }
        }
    }
}
