// Name: Christoper Hiero Barus
// NIM: 2481036
// Course: Framework .NET Programming
using StudentInformationSystem.Models;
namespace StudentInformationSystem.Data
{
    //provides student information
    //both MVC and API controllers use this data
    public static class StudentData
    {
        //in-memory collection of students
        //the GPA values are sample values, not actual GPA
        public static readonly List<Student> Students = new()
        {
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
                GPA = 3.50 //sample value
            },
            new Student
            {
                NIM = "2481048",
                Name = "Haykel Winner Sinaga",
                Major = "Informatics Engineering",
                Semester = 5,
                GPA = 3.75 //sample value
            }
        };
    }
}