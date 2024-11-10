using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrarDatosBibliotecaZN.Modelos
{
    [Table("Generos")]
    internal class Genero
    {
        public Guid Id { get; set; }
        [Required, StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
