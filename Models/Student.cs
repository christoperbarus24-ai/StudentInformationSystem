// Name: Christoper Hiero Barus
// NIM: 2481036
// Course: Framework .NET Programming
using System.ComponentModel.DataAnnotations;
namespace StudentInformationSystem.Models
{
    public class Student
    {
        //declaring every Getter and Setter
        //structure of Student
        /*
         * Id (database primary key)
         * NIM
         * Name
         * Major
         * Semester
         * GPA
         */
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string NIM { get; set; } = "";

        [Required, StringLength(120)]
        public string Name { get; set; } = "";

        [Required, StringLength(100)]
        public string Major { get; set; } = "";

        [Range(1, 14)]
        public int Semester { get; set; }

        [Range(0, 4)]
        public double GPA { get; set; }
    }
}