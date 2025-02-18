using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDepartment
    {
        private int department_id;
        private string department_name;
        private string department_task;

        public int Department_id { get => department_id; set => department_id = value; }
        public string Department_name { get => department_name; set => department_name = value; }
        public string Department_task { get => department_task; set => department_task = value; }
    }
}
