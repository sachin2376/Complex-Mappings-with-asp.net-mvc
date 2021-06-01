using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ComplexExample.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Number")]
        public int CourseId { get; set; }

        [StringLength(50,MinimumLength =3)]
        public string Title { get; set; }

        [Range(0,5)]
        public int Credits { get; set; }

        // That is why it is not required to mention Foreign key here!
        public int DepartmentId { get; set; }
        // This is Navigation property given for department
        public virtual Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }

    }
}
