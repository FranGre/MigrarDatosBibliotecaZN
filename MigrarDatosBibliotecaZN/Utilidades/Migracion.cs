using MigrarDatosBibliotecaZN.Contexto;
using MigrarDatosBibliotecaZN.Modelos;
using System;

namespace MigrarDatosBibliotecaZN.Utilidades
{
    internal class Migracion
    {
        private AppDbContexto db;

        public Migracion(AppDbContexto db)
        {
            this.db = db;
        }

    }
}