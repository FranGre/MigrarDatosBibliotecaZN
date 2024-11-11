using Aspose.Cells;
using MigrarDatosBibliotecaZN.Contexto;
using MigrarDatosBibliotecaZN.Modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
                Consola.EscribirError(MensajeFicheroNoEncontrado(rutaCsvAutores));
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

        public void MigrarUsuarios()
        {
            var rutaCsvUsuarios = $"{directorioRaizProyecto}/Usuarios.csv";

            if (!File.Exists(rutaCsvUsuarios))
            {
                Consola.EscribirError(MensajeFicheroNoEncontrado(rutaCsvUsuarios));
                return;
            }
            Consola.Escribir("Iniciando Migracion Usuarios...", ConsoleColor.Blue);
            Workbook workbook = new Workbook(rutaCsvUsuarios);
            Worksheet worksheet = workbook.Worksheets.First();

            for (int i = 1; i < worksheet.Cells.MaxDataRow; i++)
            {
                var idUsuario = worksheet.Cells[i, 0].StringValue;
                var nombre = worksheet.Cells[i, 1].StringValue == "NULL" ? null : worksheet.Cells[i, 1].StringValue;
                var email = worksheet.Cells[i, 2].StringValue;
                var fechaRegistro = worksheet.Cells[i, 3].StringValue;
                var fechaNacimiento = worksheet.Cells[i, 4].StringValue;

                if (string.IsNullOrEmpty(nombre))
                {
                    Consola.EscribirWarning($"{MensajeInfoUsuario(idUsuario, nombre, email)} NO GUARDADO NOMBRE VACIO");
                    continue;
                }
                nombre = nombre.Trim();

                var nombres = nombre.Split(' ');

                if (nombres[0].Count() > 30)
                {
                    nombres[0] = nombres[0].Substring(0, 30);
                }

                if (nombres[1].Count() > 50)
                {
                    nombres[1] = nombres[1].Substring(0, 50);
                }

                if (!string.IsNullOrEmpty(email))
                {
                    email = email.Trim();

                    if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                    {
                        Consola.EscribirWarning($"{MensajeInfoUsuario(idUsuario, nombre, email)} NO GUARDADO FORMATO EMAIL INVALIDO ");
                        continue;
                    }

                    if (db.Usuarios.Where(usuario => usuario.Email == email).FirstOrDefault() != null)
                    {
                        Consola.EscribirWarning($"{MensajeInfoUsuario(idUsuario, nombre, email)} NO GUARDADO EMAIL REGISTRADO");
                        continue;
                    }
                }

                fechaRegistro = fechaRegistro.Trim();
                if (string.IsNullOrEmpty(fechaRegistro))
                {
                    fechaRegistro = DateTime.Now.ToString();
                }

                if (Convert.ToDateTime(fechaRegistro) < new DateTime(2005, 01, 01))
                {
                    fechaRegistro = DateTime.Now.ToString();
                }

                if (Convert.ToDateTime(fechaRegistro) > DateTime.Now)
                {
                    fechaRegistro = DateTime.Now.ToString();
                }

                // agregar FechaNacimiento en el modelo Usuario, ten en cuentsa las nuevas ids para las Nacionalidades

                db.Usuarios.Add(new Usuario
                {
                    Id = Guid.NewGuid(),
                    IdImportado = Convert.ToInt32(idUsuario),
                    PrimerNombre = nombres[0],
                    Apellidos = nombres[1],
                    Email = email,
                    FechaCreacion = Convert.ToDateTime(fechaRegistro)
                });
                db.SaveChanges();
            }
            Consola.Escribir("Migracion Usuarios finalizada :)", ConsoleColor.Blue);
        }

        private string MensajeInfoUsuario(string id, string nombre, string email)
        {
            return $"USUARIO {id} {nombre} {email} -";
        }

        private string MensajeFicheroNoEncontrado(string fichero)
        {
            return $"Fichero no encontrado {fichero}";
        }
    }
}