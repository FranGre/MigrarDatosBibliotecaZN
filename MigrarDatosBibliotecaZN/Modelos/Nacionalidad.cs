using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrarDatosBibliotecaZN.Modelos
{
    [Table("Nacioinalidades")]
    internal class Nacionalidad
    {
        public Guid Id { get; set; }
        [Required, StringLength(40)]
        public string Nombre { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual ICollection<Autor> Autores { get; set; }
    }
}
