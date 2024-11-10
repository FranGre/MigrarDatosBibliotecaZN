using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrarDatosBibliotecaZN.Modelos
{
    [Table("Usuarios")]
    internal class Usuario
    {
        public Guid Id { get; set; }
        public int? IdImportado { get; set; }
        [Required, StringLength(30)]
        public string PrimerNombre { get; set; }
        [StringLength(30)]
        public string SegundoNombre { get; set; }
        [Required, StringLength(50)]
        public string Apellidos { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual ICollection<Prestamo> Prestamos { get; set; }
    }
}
