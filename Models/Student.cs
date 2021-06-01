using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplexExample.Models
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage =" Length cannot exceed more than 50 characters")]
        [Column("LastName")]
        [Required(ErrorMessage = "LastName is mandatory")]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessage = " Length cannot exceed more than 50 characters")]
        [Column("FirstName")]
        [Required(ErrorMessage ="First Name is mandatory")]
        public string FirstMidName { get; set; }

        [DataType(DataType.DateTime)]
        [Column("Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollements { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstMidName + " " + LastName;
            }
        }

    }
}
