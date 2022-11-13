using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text;

namespace CrudC.Entidades
{
   public class Areas
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]

        public string Nombre { get; set; }
      
    }
}
