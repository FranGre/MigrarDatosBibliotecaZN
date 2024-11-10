using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrarDatosBibliotecaZN.Modelos
{
    [Table("Prestamos")]
    internal class Prestamo
    {
        public Guid Id { get; set; }
        public int? IdImportado { get; set; }
        [ForeignKey("Usuario")]
        public Guid UsuarioId { get; set; }
        [ForeignKey("Libro")]
        public Guid LibroId { get; set; }
        [ForeignKey("EstadoPrestamo")]
        public Guid EstadoPrestamoId { get; set; }
        [Required]
        public DateTime FechaDevolucion { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Libro Libro { get; set; }
        public virtual EstadoPrestamo EstadoPrestamo { get; set; }
    }
}
