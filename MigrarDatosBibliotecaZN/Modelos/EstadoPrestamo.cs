using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrarDatosBibliotecaZN.Modelos
{
    [Table("EstadosPrestamo")]
    internal class EstadoPrestamo
    {
        public Guid Id { get; set; }
        [Required, StringLength(30)]
        public string Nombre { get; set; }
        [Required, StringLength(200)]
        public string Descripcion { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual ICollection<Prestamo> Prestamos { get; set; }
    }
}
