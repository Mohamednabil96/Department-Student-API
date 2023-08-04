using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APILab2.DTO;
using APILab2.Models;
using Microsoft.EntityFrameworkCore;

namespace APILab2.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        ITIContext db;
        public StudentController(ITIContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<StudentDTO> GetAll()
        {
            var students = db.Students.Select(
                s => new StudentDTO
                {
                    St_Id = s.St_Id,
                    St_Fname = s.St_Fname,
                    St_Lname = s.St_Lname,
                    St_Address = s.St_Address,
                    St_Age = s.St_Age,
                    Dept_Name = s.Dept.Dept_Name,
                    St_super_Name = s.St_superNavigation != null ? s.St_superNavigation.St_Fname : null,
                }).ToList();

            if (!students.Any())
                return NoContent();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int? id)
        {
            if (id == null)
                return BadRequest();

            var s = db.Students.Include(s => s.St_superNavigation).Include(d => d.Dept).FirstOrDefault(s => s.St_Id == id);
            if (s == null)
                return NotFound();

            StudentDTO stu_dto = new StudentDTO()
            {
                St_Id = s.St_Id,
                St_Fname = s.St_Fname,
                St_Lname = s.St_Lname,
                St_Address = s.St_Address,
                St_Age = s.St_Age,
                Dept_Name = s.Dept.Dept_Name ?? " ",
                St_super_Name = s.St_superNavigation != null ? s.St_superNavigation.St_Fname + " " + s.St_superNavigation.St_Lname : null,
            };

            return Ok(stu_dto);
        }
        [HttpPost]
        public ActionResult Post(StudentDTO s)
        {
            if (s == null)
                return BadRequest();
            var student = new Student()
            {
                St_Fname = s.St_Fname,
                St_Lname = s.St_Lname,
                St_Address = s.St_Address,
                St_Age = s.St_Age,
                Dept_Id = s.Dept_Id,
                St_super = s.St_super,
            };

            db.Students.Add(student);
            db.SaveChanges();

            return Ok(student);
        }

        [HttpPut("{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Put(Student student, int? id)
        {
            if (student == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(student);

            db.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return Ok(student);
        }

    }


}
