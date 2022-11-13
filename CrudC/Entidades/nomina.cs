using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CrudC.Entidades
{
    class nomina
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey("IdEmpleado")]
        public int IdEmpleado { get; set; }
        public int Sueldo { get; set; }
        public int Dias { get; set; }
        public int Total_Basico { get; set; }
        public int Comisiones { get; set; }
        public int Devengado { get; set; }



    }
}
