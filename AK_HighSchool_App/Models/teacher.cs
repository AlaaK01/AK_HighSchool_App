using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_HighSchool_App.Models
{
    class teacher
    {
        [Key]
        public int teacherID { get; set; }
        [Required, StringLength(50)]
        public string teacherFirstName { get; set; }
        [Required, StringLength(50)]
        public string teacherLastName { get; set; }
        public int? teacherAge { get; set; }
        public gender? Gender { get; set; }
        public ICollection<Relation> teacherStudent { get; set; }

    }
}
