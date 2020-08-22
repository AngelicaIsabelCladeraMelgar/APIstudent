using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIstudent.Models
{
    public class Student
    {
        [Key]
        [Required]
        [Range(1,9999)]
        public int StudentID{ get; set; }


        [StringLength(30)]
        [Required(ErrorMessage ="You must enter the field {0}")]//usted debe ingresar el campo requerido
        public string LastName  { get; set; }


        [StringLength(30,ErrorMessage ="The field {0} must contain betwen {2} and {1} characters  ",MinimumLength =2)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string FirstName { get; set; }
        //{0} se refiere a FirstName
        //{1} se refiere al dato registrado a la derecha (30)
        //{2} se refiere al dato registrado a la izquierda (2)


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
        public DateTime EnrollmentDate { get; set; }

    }
}