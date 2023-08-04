﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APILab2.Models;

[Table("Student")]
public partial class Student
{
    [Key]
    public int St_Id { get; set; }

    [StringLength(50)]
    public string St_Fname { get; set; }

    [StringLength(10)]
    public string St_Lname { get; set; }

    [StringLength(100)]
    public string St_Address { get; set; }

    public int? St_Age { get; set; }

    public int? Dept_Id { get; set; }

    public int? St_super { get; set; }

    [ForeignKey("Dept_Id")]
    [InverseProperty("Students")]
    public virtual Department Dept { get; set; }

    [InverseProperty("St_superNavigation")]
    public virtual ICollection<Student> InverseSt_superNavigation { get; set; } = new List<Student>();

    [ForeignKey("St_super")]
    [InverseProperty("InverseSt_superNavigation")]
    public virtual Student St_superNavigation { get; set; }

}