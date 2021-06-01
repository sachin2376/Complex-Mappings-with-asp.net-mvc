﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplexExample.Models
{
    public class OfficeAssignment
    {

        [Key]
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }

        [StringLength(50,MinimumLength =1),Display(Name ="Office Location")]
        public string Location { get; set; }


        public virtual Instructor Instructor { get; set; }
    }
}
