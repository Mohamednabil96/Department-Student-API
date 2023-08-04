﻿namespace APILab2.DTO
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
