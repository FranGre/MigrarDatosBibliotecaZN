using Aspose.Cells;
using MigrarDatosBibliotecaZN.Contexto;
using MigrarDatosBibliotecaZN.Modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace MigrarDatosBibliotecaZN.Utilidades
{
    internal class Migracion
    {
        private AppDbContexto db;
        private string directorioRaizProyecto = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));

        public Migracion(AppDbContexto db)
        {
            this.db = db;
        }

        public void MigrarAutores()
        {
            var rutaCsvAutores = $"{directorioRaizProyecto}/Autores.csv";

            if (!File.Exists(rutaCsvAutores))
            {
                Consola.EscribirError($"Fichero no encontrado {rutaCsvAutores}");
                return;
            }

            Consola.EscribirExito("Iniciando Migracion de Autores...");

            Workbook workbook = new Workbook(rutaCsvAutores);
            Worksheet worksheet = workbook.Worksheets.First();

            for (int i = 1; i < worksheet.Cells.MaxDataRow; i++)
            {
                var idAutor = worksheet.Cells[i, 0].StringValue;
                var nombre = worksheet.Cells[i, 1].StringValue;
                var nombreNacionalidad = worksheet.Cells[i, 2].StringValue == "NULL" ? null : worksheet.Cells[i, 2].StringValue;

                if (string.IsNullOrEmpty(nombre))
                {
                    Consola.EscribirWarning($"{MensajeInfoAutor(idAutor, nombre)} NO GUARDADO NOMBRE VACIO");
                    continue;
                }

                nombre = nombre.Trim();
                if (string.IsNullOrEmpty(nombreNacionalidad))
                {
                    Consola.EscribirWarning($"{MensajeInfoAutor(idAutor, nombre)} NO GUARDADO NACIONALIDAD VACIA");
                    continue;
                }

                nombreNacionalidad = nombreNacionalidad.Trim();
                if (nombreNacionalidad.Count() > 40)
                {
                    nombreNacionalidad = nombreNacionalidad.Substring(0, 40);
                }

                var nacionalidad = db.Nacionalidades.Where(n => nombreNacionalidad.Contains(n.Nombre)).FirstOrDefault();
                var diccionarioNacionalidades = GenerarDiccionarioNacionalidades();

                if (nacionalidad == null && !diccionarioNacionalidades.ContainsKey(nombreNacionalidad))
                {
                    Consola.EscribirWarning($"NACIONALIDAD {nombreNacionalidad} NO GUARDADA NO HAY COINCIDENCIAS");
                    Consola.EscribirWarning($"AUTOR {idAutor} {nombre} NO GUARDAD NO TIENE NACIONALIDAD");
                    continue;
                }

                if (nacionalidad == null)
                {
                    nacionalidad = new Nacionalidad { Id = diccionarioNacionalidades[nombreNacionalidad] };
                }

                db.Autores.Add(new Autor
                {
                    Id = Guid.NewGuid(),
                    IdImportado = Convert.ToInt32(idAutor),
                    NacionalidadId = nacionalidad.Id,
                    NombreCompleto = nombre,
                    FechaNacimiento = DateTime.Now,
                    FechaCreacion = DateTime.Now
                });
                db.SaveChanges();
            }

            Consola.EscribirExito("Migracion de Autores finalizada :)");
        }

        private string MensajeInfoAutor(string id, string nombre)
        {
            return $"AUTOR {id} {nombre} -";
        }

        private string EliminarAcentos(string texto)
        {
            string textoDescompuesto = texto.Normalize(NormalizationForm.FormD);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var caracter in textoDescompuesto)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(caracter) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(caracter);
                }
            }

            return stringBuilder.ToString();
        }

        private Dictionary<string, Guid> GenerarDiccionarioNacionalidades()
        {
            Dictionary<string, Guid> diccionarioNacionalidades = new Dictionary<string, Guid>
            {
                { "Peruana", Guid.Parse("3FB43CAE-FB3E-470F-AC88-EAA1E8236EF6") },
                { "Japonesa", Guid.Parse("7A138340-EAFB-436E-87A0-71E683774968") },
                { "Española", Guid.Parse("793CF326-87E7-431C-9280-15E664C34D50") },
                { "Alemana", Guid.Parse("FBACA30F-5E9B-4F88-A4D6-6FDDD0A724C0") },
                { "Alemán", Guid.Parse("FBACA30F-5E9B-4F88-A4D6-6FDDD0A724C0") },
                { "Francesa", Guid.Parse("E7EFE151-3F4C-467F-8618-B3E7FF15E7A6") },
                { "Francés", Guid.Parse("E7EFE151-3F4C-467F-8618-B3E7FF15E7A6") },
                { "Rusa", Guid.Parse("495BA65B-BA6A-4A42-8B94-AEE3B73C792C") },
                { "Mexicana", Guid.Parse("D59C9906-963D-4134-8571-A86E3A245830") },
                { "Estadounidense", Guid.Parse("4FEDA19C-6427-4F42-B193-A68FC28B4673") },
                { "Canadiense", Guid.Parse("24A717E8-DE8A-4ED1-8043-73CF263AE523") },
                { "Británica", Guid.Parse("DBE50CBE-62A1-4B4F-9E37-6F77F63C33C5") },
            };
            return diccionarioNacionalidades;
        }
    }
}