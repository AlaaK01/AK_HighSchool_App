using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_HighSchool_App.Models
{
    public enum category { graphicDesign, webDevelopment, programming, dataBase }
    public enum graphicD { adobeIllustrator, adobePhotoshp, corelDrow }
    public enum webD { Html, Css, javaScript }
    public enum programming { Csharp, Java, python }
    public enum dataB { sqlServer, oracle, mySql }
    class subject
    {
        [Key]
        public int subjectID { get; set; }
        [Required]
        public category Category { get; set; }
        public graphicD? GraphicDesign { get; set; }
        public webD? WebbDevelopment { get; set; }
        public programming? Programming { get; set; }
        public dataB? DataBase { get; set; }

        public ICollection<Relation> teacherStudent { get; set; }
    }
}
