using MigrarDatosBibliotecaZN.Contexto;
using MigrarDatosBibliotecaZN.Utilidades;

namespace MigrarDatosBibliotecaZN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new AppDbContexto();

            var seeder = new Seeder(db);
            seeder.InsertarNacionalidades();
            seeder.InsertarEstadosPrestamo();
            seeder.InsertarGeneros();
            seeder.InsertarEstadoslibro();
        }
    }
}
