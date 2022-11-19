using System.ComponentModel.DataAnnotations;

namespace EFCUTY_ASP_2022231.Models
{
    public class Subject
    {
        [Key]
        public string SubjectCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0,30)]
        public int CreditValue { get; set; }

        [Required]
        public bool ExamSubject { get; set; }

        [Required]
        [Range(0,7)]
        public int Semester { get; set; }
    }
}
