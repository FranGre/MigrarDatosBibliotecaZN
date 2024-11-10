using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrarDatosBibliotecaZN.Modelos
{
    [Table("Autores")]
    internal class Autor
    {
        public Guid Id { get; set; }
        public int? IdImportado { get; set; }
        [ForeignKey("Nacionalidad")]
        public Guid NacionalidadId { get; set; }
        [Required]
        public string NombreCompleto { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Nacionalidad Nacionalidad { get; set; }
    }
}
