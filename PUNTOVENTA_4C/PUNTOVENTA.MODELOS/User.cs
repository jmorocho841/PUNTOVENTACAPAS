using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PUNTOVENTA.MODELOS
{
    public class User : IdentityUser
    {
            //[Required]
            [Display(Name = "Numero de C.I./DNI")]
            public string Documento { get; set; }

            //[Required]
            public string Nombres { get; set; }

            //[Required]
            public string Apellidos { get; set; }

            //[Required]
            [Display(Name = "Pais")]
            public string Pais { get; set; }

            //[Required]
            [Display(Name = "Provincia")]
            public string Provincia { get; set; }

            //[Required]
            [Display(Name = "Ciudad de residencia")]
            public string Ciudad { get; set; }

            [Display(Name = "Direccion")]
            public string Direccion { get; set; }

            [Display(Name = "Numero de Celular")]
            public string NumeroCel { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            public DateTime FechaNacimiento { get; set; }

            [Display(Name = "Fecha Creacion")]
            [Required(ErrorMessage = "El Campo {0} es Requerido.")]
            [DataType(DataType.DateTime)]
            [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
            public DateTime Date { get; set; }

            [Display(Name = "Fecha Creacion")]
            [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
            public DateTime DateLocal => Date.ToLocalTime();

            //Fecha Modificacion
            [Display(Name = "Fecha Modificacion")]
            [Required(ErrorMessage = "El Campo {0} es Requerido.")]
            [DataType(DataType.DateTime)]
            [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
            public DateTime DateModifica { get; set; }

            [Display(Name = "Fecha Modificacion")]
            [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
            public DateTime DateLocalModif => DateModifica.ToLocalTime();
    }
}
