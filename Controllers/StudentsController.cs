using CRUDwithAngular.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDwithAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentDbContext _context;
        public StudentsController(StudentDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetStudent")]
        public async Task <IEnumerable<Student>>GetStudents()
        {
            return await _context.Students.ToListAsync();
        }
        [HttpPost]
        [Route("AddStudent")]
        public async Task<Student> AddStudents( Student model)
        {
           _context.Students.Add(model);
           await _context.SaveChangesAsync();
           return model;
        }
        [HttpPatch]
        [Route("UpdateStudent/{id}")]
        public async Task<Student> UpdateStudents(Student model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return model;
        }
        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public bool DeleteStudents(int id)
        {
            bool a = false;
            var student = _context.Students.Find(id);
            if (student != null)
            {
               a = true;
                _context.Entry(student).State=EntityState.Deleted;
                _context.SaveChanges();
            }
            else
            {
                a = false;

            }
            return a;
        }

    }
}
