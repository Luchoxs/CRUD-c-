using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text;

namespace CrudC.Entidades
{
   public class Empleado
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_Ingreso  { get; set; }

        [ForeignKey("IdArea")]
        public int IdArea { get; set; }

    }
}
