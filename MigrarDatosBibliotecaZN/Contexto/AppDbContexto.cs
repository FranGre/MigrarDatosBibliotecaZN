using MigrarDatosBibliotecaZN.Modelos;
using System;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;

namespace MigrarDatosBibliotecaZN.Contexto
{
    internal class AppDbContexto : DbContext
    {
        public DbSet<Nacionalidad> Nacionalidades { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<EstadoLibro> EstadoLibros { get; set; }
        public DbSet<EstadoPrestamo> EstadoPrestamos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        public AppDbContexto() : base(CrearConexion(), true) { }

        public static DbConnection CrearConexion()
        {
            var conexion = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateConnection();
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AppConexion"].ConnectionString;
            return conexion;

        }
    }
}
