using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APILab2.Models;

[Table("Department")]
[Index("Manager_hiredate", Name = "I_Dept_Hd")]
public partial class Department
{
    [Key]
    public int Dept_Id { get; set; }

    public string Dept_Name { get; set; }

    public string Dept_Desc { get; set; }

    public string Dept_Location { get; set; }

    public int? Dept_Manager { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Manager_hiredate { get; set; }

    [InverseProperty("Dept")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    [NotMapped]
    public object Dept_ManagerNavigation { get; internal set; }
}