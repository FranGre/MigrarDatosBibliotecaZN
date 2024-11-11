using MigrarDatosBibliotecaZN.Contexto;
using MigrarDatosBibliotecaZN.Modelos;
using System;

namespace MigrarDatosBibliotecaZN.Utilidades
{
    internal class Seeder
    {
        private AppDbContexto db;

        public Seeder(AppDbContexto db) { this.db = db; }

        public void InsertarNacionalidades()
        {
            var nacionalidades = new[]
            {
                new Nacionalidad { Id = Guid.NewGuid(), Nombre = "Argentina", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(), Nombre = "Brasil", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(), Nombre = "Chile", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(),Nombre = "México", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(),Nombre = "Colombia", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(),Nombre = "Perú", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(), Nombre = "Venezuela", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(),Nombre = "Ecuador", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(),  Nombre = "Uruguay", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(),  Nombre = "Paraguay", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(),  Nombre = "Bolivia", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(),   Nombre = "Guatemala", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(),  Nombre = "Honduras", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(),  Nombre = "El Salvador", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(),  Nombre = "Nicaragua", FechaCreacion = DateTime.Now },
                new Nacionalidad { Id = Guid.NewGuid(),  Nombre = "Costa Rica", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Panamá", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "República Dominicana", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Cuba", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Puerto Rico", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "España", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Francia", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Italia", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Alemania", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Reino Unido", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Estados Unidos", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Canadá", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Australia", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Japón", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "China", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "India", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Pakistán", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Bangladesh", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Rusia", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Turquía", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Irán", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Egipto", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Sudáfrica", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Nigeria", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Etiopía", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Kenya", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Israel", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Arabia Saudita", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Emiratos Árabes Unidos", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Corea del Sur", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Tailandia", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Indonesia", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Malasia", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Filipinas", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Singapur", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Vietnam", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Nepal", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Sri Lanka", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Afganistán", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Irak", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Siria", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Líbano", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Kenia", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Zambia", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Ghana", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Uganda", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Rwanda", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Mozambique", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Camerún", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Costa de Marfil", FechaCreacion = DateTime.Now },
                new Nacionalidad {Id = Guid.NewGuid(),  Nombre = "Senegal", FechaCreacion = DateTime.Now }
            };

            db.Nacionalidades.AddRange(nacionalidades);
            db.SaveChanges();

            Consola.EscribirExito("Nacionalidades Guardadas :)");
        }

        public void InsertarEstadosPrestamo()
        {
            var estadosPrestamos = new[]
             {
                new EstadoPrestamo {
                    Id = Guid.NewGuid(),
                    Nombre = "En Préstamo",
                    Descripcion = "El libro ha sido devuelto por el usuario dentro del plazo estipulado, y el préstamo ha finalizado correctamente.",
                    FechaCreacion = DateTime.Now
                },
                new EstadoPrestamo {
                    Id = Guid.NewGuid(),
                    Nombre = "Devuelto",
                    Descripcion = "El libro ha sido devuelto por el usuario dentro del plazo estipulado, y el préstamo ha finalizado correctamente.",
                    FechaCreacion = DateTime.Now
                },
                new EstadoPrestamo {
                    Id = Guid.NewGuid(),
                    Nombre = "Perdido",
                    Descripcion = "El libro ha sido reportado como perdido por el usuario o por el sistema, y no será devuelto a la biblioteca. El usuario puede ser responsable de pagar por el libro.",
                    FechaCreacion = DateTime.Now
                },
                new EstadoPrestamo {
                    Id = Guid.NewGuid(),
                    Nombre = "Vencido",
                    Descripcion = "El libro está fuera del plazo de devolución establecido. El usuario debe devolverlo lo antes posible para evitar multas o sanciones.",
                    FechaCreacion = DateTime.Now
                },
                new EstadoPrestamo {
                    Id = Guid.NewGuid(),
                    Nombre = "Por Recoger",
                    Descripcion = "El libro ha sido reservado por un usuario, pero aún no ha sido recogido. El usuario debe retirarlo de la biblioteca dentro de un plazo determinado.",
                    FechaCreacion = DateTime.Now
                },
                new EstadoPrestamo {
                    Id = Guid.NewGuid(),
                    Nombre = "Cancelado",
                    Descripcion = "El préstamo o la reserva ha sido cancelada antes de que el libro fuera entregado al usuario, por solicitud del usuario o por error administrativo.",
                    FechaCreacion = DateTime.Now
                }
            };

            db.EstadoPrestamos.AddRange(estadosPrestamos);
            db.SaveChanges();
            Consola.EscribirExito("EstadosPrestamos Guardados :)");
        }

        public void InsertarGeneros()
        {
            var generos = new[]
             {
                new Genero { Id = Guid.NewGuid(), Nombre = "Ficción", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "No Ficción", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Ciencia Ficción", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Fantasía", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Romántico", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Suspenso", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Thriller", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Misterio", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Aventura", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Biografía", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Autobiografía", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Historia", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Crónica", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Fábulas", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Cuento", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Poesía", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Drama", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Ensayo", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Psicología", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Filosofía", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Religión", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Educación", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Arte", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Música", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Cultura", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Cocina", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Deportes", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Viajes", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Tecnología", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Economía", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Política", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Sociología", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Ciencia", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Medicina", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Crimen", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Horror", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Magia", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Realismo Mágico", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Steampunk", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Cyberpunk", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Postapocalíptico", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Utopía", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Distopía", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Novela Gráfica", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Manga", FechaCreacion = DateTime.Now },
                new Genero { Id = Guid.NewGuid(), Nombre = "Graphic Novel", FechaCreacion = DateTime.Now }
            };

            db.Generos.AddRange(generos);
            db.SaveChanges();
        }

        public void InsertarEstadoslibro()
        {
            var estadosLibro = new[]
            {
                new EstadoLibro { Id = Guid.NewGuid(), Nombre = "Disponible", Descripcion = "El libro está en la biblioteca, listo para ser prestado a los usuarios.", FechaCreacion = DateTime.Now },
                new EstadoLibro { Id = Guid.NewGuid(), Nombre = "En Prestamo", Descripcion = "El libro ha sido prestado a un usuario y está fuera de la biblioteca.", FechaCreacion = DateTime.Now },
                new EstadoLibro { Id = Guid.NewGuid(), Nombre = "En Reparacion", Descripcion = "El libro ha sufrido daños y está siendo reparado antes de poder ser prestado nuevamente.", FechaCreacion = DateTime.Now },
                new EstadoLibro { Id = Guid.NewGuid(), Nombre = "Retirado", Descripcion = "El libro ha sido retirado del catálogo por razones como obsolescencia, daño irreparable o caducidad en su relevancia.", FechaCreacion = DateTime.Now },
                new EstadoLibro { Id = Guid.NewGuid(), Nombre = "Por Catalogar", Descripcion = "El libro ha llegado a la biblioteca, pero aún no se ha procesado ni registrado en el sistema para ser prestado.", FechaCreacion = DateTime.Now },
                new EstadoLibro { Id = Guid.NewGuid(), Nombre = "Archivado", Descripcion = "El libro ha sido archivado y ya no está disponible para préstamo, puede estar en una sección de almacenamiento especial.", FechaCreacion = DateTime.Now },
                new EstadoLibro { Id = Guid.NewGuid(), Nombre = "Por Colocar", Descripcion = "El libro ha sido catalogado y está esperando ser colocado en las estanterías de la biblioteca.", FechaCreacion = DateTime.Now }
            };

            db.EstadoLibros.AddRange(estadosLibro);
            db.SaveChanges();

            Consola.EscribirExito("EstadosLibro Guardados :)");
        }
    }
}
