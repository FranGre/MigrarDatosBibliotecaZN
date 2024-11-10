using MigrarDatosBibliotecaZN.Contexto;
using System.Linq;

namespace MigrarDatosBibliotecaZN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new AppDbContexto();

            db.Usuarios.ToList();
        }
    }
}
