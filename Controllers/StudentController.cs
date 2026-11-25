// Name: Christoper Hiero Barus
// NIM: 2481036
// Course: Framework .NET Programming
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
namespace StudentInformationSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db) => _db = db;

        //student profile page, reads from MySQL
        //returns NotFound if the record was deleted
        public async Task<IActionResult> Profile(string? nim)
        {
            nim ??= "2481036"; // an existing sample NIM
            var student = await _db.Students.AsNoTracking()
                .FirstOrDefaultAsync(s => s.NIM == nim);
            if (student is null) return NotFound();
            return View(student);
        }
    }
}