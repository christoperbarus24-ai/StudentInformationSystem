// Name: Christoper Hiero Barus
// NIM: 2481036
// Course: Framework .NET Programming
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Models;
namespace StudentInformationSystem.Data
{
    public static class StudentSeeder
    {
        //inserts records only when the Students table is empty
        //the GPA values are sample values, not actual GPA
        public static async Task SeedAsync(ApplicationDbContext db)
        {
            if (await db.Students.AnyAsync()) return;

            db.Students.AddRange(
                //my own data (this is the first record, shown on the Profile page)
                new Student
                {
                    NIM = "2481036",
                    Name = "Christoper Hiero Barus",
                    Major = "Informatics Engineering",
                    Semester = 5,
                    GPA = 3.61
                },
                new Student
                {
                    NIM = "2481029",
                    Name = "Aril Sagala",
                    Major = "Informatics Engineering",
                    Semester = 5,
                    GPA = 3.46 //sample GPA value, not actual GPA
                },
                new Student
                {
                    NIM = "2481048",
                    Name = "Haykel Winner Sinaga",
                    Major = "Informatics Engineering",
                    Semester = 5,
                    GPA = 3.65 //sample GPA value, not actual GPA
                }
            );
            await db.SaveChangesAsync();
        }
    }
}