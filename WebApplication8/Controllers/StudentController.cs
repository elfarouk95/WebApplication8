using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication8.Model;

namespace WebApplication8.Controllers
{
    [ApiController]
    [Route("Student")]
    public class StudentController : ControllerBase
    {
        private readonly SchoolDb db;

        //        SchoolDb db = new SchoolDb();

        public StudentController(SchoolDb db)
        {
            this.db = db;
        }


        [HttpPost("AddStudent")]
        public ActionResult AddStudent(Student s)
        {
            bool t = db.Students.Any(sm => sm.Id == s.Id);

            if (t == true)
            {
                return BadRequest("There is Student with Same Id");
            }
            else
            {
                db.Students.Add(s);
                db.SaveChanges();
                return Ok("done");
            }
        }

        [HttpGet("GetAll")]
        public ActionResult getAllStudent()
        {
            return Ok(db.Students.ToList()) ;
        }
    }
}
