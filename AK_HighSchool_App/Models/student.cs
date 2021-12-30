using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_HighSchool_App.Models
{
    public enum gender { male, female, unknown }
    class student
    {
        [Key]
        public int studentID { get; set; }
        [Required, StringLength(50)]
        public string studentFirstName { get; set; }
        [Required, StringLength(50)]
        public string studentLastName { get; set; }
        [Required, StringLength(50)]
        public string userName { get; set; }
        [Required, StringLength(50)]
        public string? password { get; set; }
        public string? email { get; set; }
        public int? studentAge { get; set; }
        public gender? Gender { get; set; }
        public ICollection<Relation> studentTeachers { get; set; }

    }
}
