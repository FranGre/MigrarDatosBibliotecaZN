using MigrarDatosBibliotecaZN.Contexto;
using MigrarDatosBibliotecaZN.Utilidades;
using System;

namespace MigrarDatosBibliotecaZN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new AppDbContexto();

            /**
            var seeder = new Seeder(db);
            seeder.InsertarNacionalidades();
            seeder.InsertarEstadosPrestamo();
            seeder.InsertarGeneros();
            seeder.InsertarEstadoslibro();
            **/

            var migracion = new Migracion(db);

            // migracion.MigrarAutores();
            migracion.MigrarUsuarios();
            Console.ReadKey();
        }
    }
}
