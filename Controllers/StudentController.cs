using DatabaseDrivenAPI.Data;
using Microsoft.AspNetCore.Mvc;
using DatabaseDrivenAPI.Model;
using Microsoft.EntityFrameworkCore;


namespace DatabaseDrivenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("List")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> AddStudent(Student student)
        {
            if (student == null)
                return BadRequest("Student object is null.");

            if (student.Id > 0)
            {
                var existingStudent = await _context.Students.FindAsync(student.Id);
                if (existingStudent == null)
                    return NotFound($"Student with Id {student.Id} not found.");

                // Update fields
                existingStudent.Name = student.Name;
                existingStudent.Department = student.Department;

                // No need to call _context.Update(existingStudent), EF tracks it
            }
            else
            {
                _context.Students.Add(student); // New record
            }

            await _context.SaveChangesAsync();
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound($"Student with Id {id} not found.");
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return Ok($"Student with Id {id} has been deleted.");
        }

    }
}
