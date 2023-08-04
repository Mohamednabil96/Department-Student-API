using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILab2WF.DTO
{
    public class DepartmentDTO
    {
        public int Dept_Id { get; set; }
        public string Dept_Name { get; set; }
        public string Dept_Desc { get; set; }
        public string Dept_Location { get; set; }
        public int? Dept_Manager { get; set; }
        public virtual ICollection<string> StudentsNames { get; set; } = new List<string>();
    }
}
