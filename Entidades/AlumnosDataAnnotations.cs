using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{

    [MetadataType(typeof(AlumnosDataAnnotations))]

    public partial class Alumnos
    {

    }
    public class AlumnosDataAnnotations
    {

        public int id { get; set; }
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression("[A-Z a-z]+", ErrorMessage =" El {0} no tiene que tener numeros")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DataType(DataType.Text)]
        public string primerApellido { get; set; }
        [DataType(DataType.Text)]
        public string segundoApellido { get; set; }
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string correo { get; set; }
        public string telefono { get; set; }
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public System.DateTime fechaNacimiento { get; set; }
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression("[A-Z]{4}[0-9]{2}[0-9]{2}[0-9]{2}[HM]{1}(AS|BS|CL|CS|DF|GT|HG|MC|MS|NL|PL|QR|SL|TC|TL|YN|NE|BC|CC|CM|CH|DG|GR|JC|MN|NT|OC|QT|SP|SR|TS|VZ|ZS){1}[^AEIOU\\d\\W]{3}[0-9]{2}", ErrorMessage ="No tiene el formato correcto")]
        public string curp { get; set; }
        [Range(10000, 40000, ErrorMessage = "El valor debe estar entre el {1} y el {2}")]
        public Nullable<decimal> sueldo { get; set; }
        public int idEstadoOrigen { get; set; }
        public short idEstatus { get; set; }

        public virtual Estados Estados { get; set; }
        public virtual EstatusAlumnos EstatusAlumnos { get; set; }
    }
}
