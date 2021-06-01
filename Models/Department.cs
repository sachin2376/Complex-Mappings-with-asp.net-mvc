using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplexExample.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [StringLength(50,MinimumLength =3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName="money")]
        public Decimal Budjet { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyyMM-dd}",ApplyFormatInEditMode =true),Display(Name="Start date")]
        public DateTime StartDate { get; set; }

        // ?=> Means property is nullable
        public int? InstructorId { get; set; }
        public virtual Instructor Administrator{ get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}
