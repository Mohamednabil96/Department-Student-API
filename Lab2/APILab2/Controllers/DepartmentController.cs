using APILab2.DTO;
using APILab2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILab2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        ITIContext db;
        public DepartmentController(ITIContext _context)
        {
            db = _context;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var depts = db.Departments.Select(
                d => new DepartmentDTO
                {
                    Dept_Id = d.Dept_Id,
                    Dept_Name = d.Dept_Name,
                    Dept_Desc = d.Dept_Desc,
                    Dept_Location = d.Dept_Location,
                    Dept_Manager = d.Dept_Manager,
                }).ToList();
            if (!depts.Any())
                return NoContent();
            return Ok(depts);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int? id)
        {
            if (id == null)
                return BadRequest();
            var d = db.Departments.Find(id);
            if (d == null)
                return NotFound();
            var dept = new DepartmentDTO
            {
                Dept_Id = d.Dept_Id,
                Dept_Name = d.Dept_Name,
                Dept_Desc = d.Dept_Desc,
                Dept_Location = d.Dept_Location,
                Dept_Manager = d.Dept_Manager,
                StudentsNames = db.Students.Select(s => s.St_Fname).ToList()
            };
            return Ok(dept);

        }
    }
}
