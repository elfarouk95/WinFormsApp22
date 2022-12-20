
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp22.db
{
    public class Student
    {
        [Key]
        public string Email { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public float Gpa { get; set; }


    }
}
