using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrarDatosBibliotecaZN.Modelos
{
    [Table("Libros")]
    internal class Libro
    {
        public Guid Id { get; set; }
        public int? IdImportado { get; set; }
        [ForeignKey("Autor")]
        public Guid AutorId { get; set; }
        [ForeignKey("Genero")]
        public Guid GeneroId { get; set; }
        [ForeignKey("EstadoLibro")]
        public Guid EstadoLibroId { get; set; }
        [Required, StringLength(50)]
        public string Titulo { get; set; }
        [Required, StringLength(450)]
        public string Sinopsis { get; set; }
        [Required]
        public DateTime FechaPublicacion { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Autor Autor { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual EstadoLibro EstadoLibro { get; set; }
        public virtual ICollection<Prestamo> Prestamos { get; set; }
    }
}
