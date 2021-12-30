using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_HighSchool_App.Models
{
    public enum level { primary, secondary, high }
    public enum studyType { distance, onSite, both }
    public enum gpa { A, B, C, D, E, F }
    class Relation
    {
        [Key]
        public int ID { get; set; }
        public int studentIDFK { get; set; }
        public int teacherIDFK { get; set; }
        public int subjectIDFK { get; set; }

        public level Level { get; set; }
        public studyType StudyType { get; set; }
        public gpa GPA { get; set; }

        [ForeignKey(nameof(studentIDFK))]
        public student Student { get; set; }
        [ForeignKey(nameof(teacherIDFK))]
        public teacher Teacher { get; set; }
        [ForeignKey(nameof(subjectIDFK))]
        public subject Subject { get; set; }
    }
}
