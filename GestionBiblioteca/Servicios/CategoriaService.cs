using GestionBiblioteca.Estructuras.Categorias;
using GestionBiblioteca.Models;
using System.IO;
using System;

namespace GestionBiblioteca.Servicios
{
    public class CategoriaService
    {
        private ListaCategorias listaCategorias;

        public CategoriaService()
        {
            listaCategorias = new ListaCategorias();
            CargarCategoriasDesdeArchivo();
        }

        public Categoria BuscarCategoriaPorId(int id)
        {
            // Buscar en la lista enlazada en memoria
            NodoCategoria actual = listaCategorias.cabeza;
            while (actual != null)
            {
                if (actual.Categoria.Id == id)
                {
                    return actual.Categoria;
                }
                actual = actual.Siguiente;
            }

            // Buscar en el archivo si no está en memoria
            string archivoRuta = @"Data\Categoria.txt";
            if (File.Exists(archivoRuta))
            {
                string[] lineas = File.ReadAllLines(archivoRuta);
                foreach (var linea in lineas)
                {
                    var campos = linea.Split(',');
                    if (campos.Length == 3 && int.Parse(campos[0]) == id)
                    {
                        return new Categoria
                        {
                            Id = int.Parse(campos[0]),
                            Nombre = campos[1],
                            Descripcion = campos[2]
                        };
                    }
                }
            }

            return null; // Categoría no encontrada
        }

        public void AgregarCategoria(Categoria categoria)
        {
            if (CategoriaExiste(categoria.Nombre))
            {
                throw new InvalidOperationException("Ya existe una categoría con ese nombre.");
            }

            listaCategorias.AgregarCategoria(categoria); // Agregar a la lista enlazada
            GuardarCategoriaEnArchivo(categoria); // Guardar en archivo
        }

        public bool CategoriaExiste(string nombre)
        {
            NodoCategoria actual = listaCategorias.cabeza;

            // Buscar en la lista enlazada
            while (actual != null)
            {
                if (actual.Categoria.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                actual = actual.Siguiente;
            }

            return CategoriaExisteEnArchivo(nombre);
        }

        private bool CategoriaExisteEnArchivo(string nombre)
        {
            string archivoRuta = @"Data\Categoria.txt";
            if (!File.Exists(archivoRuta)) return false;

            string[] lineas = File.ReadAllLines(archivoRuta);
            foreach (var linea in lineas)
            {
                var campos = linea.Split(',');
                if (campos.Length >= 2 && campos[1].Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private void GuardarCategoriaEnArchivo(Categoria categoria)
        {
            string archivoRuta = @"Data\Categoria.txt";
            string linea = $"{categoria.Id},{categoria.Nombre},{categoria.Descripcion}";
            Directory.CreateDirectory(Path.GetDirectoryName(archivoRuta));
            File.AppendAllText(archivoRuta, linea + Environment.NewLine);
        }

        public int ObtenerNuevoId()
        {
            int maxId = 0;

            // Obtener el ID más alto de la lista enlazada
            NodoCategoria actual = listaCategorias.cabeza;
            while (actual != null)
            {
                if (actual.Categoria.Id > maxId)
                {
                    maxId = actual.Categoria.Id;
                }
                actual = actual.Siguiente;
            }

            // Verificar el archivo
            string archivoRuta = @"Data\Categoria.txt";
            if (File.Exists(archivoRuta))
            {
                string[] lineas = File.ReadAllLines(archivoRuta);
                foreach (string linea in lineas)
                {
                    var campos = linea.Split(',');
                    if (campos.Length > 0)
                    {
                        int id = int.Parse(campos[0]);
                        if (id > maxId)
                        {
                            maxId = id;
                        }
                    }
                }
            }

            return maxId + 1;
        }

        private void CargarCategoriasDesdeArchivo()
        {
            string archivoRuta = @"Data\Categoria.txt";
            if (!File.Exists(archivoRuta)) return;

            string[] lineas = File.ReadAllLines(archivoRuta);
            foreach (var linea in lineas)
            {
                var campos = linea.Split(',');
                if (campos.Length == 3)
                {
                    Categoria categoria = new Categoria
                    {
                        Id = int.Parse(campos[0]),
                        Nombre = campos[1],
                        Descripcion = campos[2]
                    };
                    listaCategorias.AgregarCategoria(categoria);
                }
            }
        }

        public Categoria[] BuscarCategoriasPorNombre(string nombre)
        {
            Categoria[] categoriasEncontradas = new Categoria[100];
            int index = 0;

            // Buscar en la lista enlazada
            NodoCategoria actual = listaCategorias.cabeza;
            while (actual != null)
            {
                if (actual.Categoria.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    categoriasEncontradas[index++] = actual.Categoria;
                }
                actual = actual.Siguiente;
            }

            // Buscar en el archivo si no hay resultados
            if (index == 0)
            {
                string archivoRuta = @"Data\Categoria.txt";
                if (File.Exists(archivoRuta))
                {
                    string[] lineas = File.ReadAllLines(archivoRuta);
                    foreach (string linea in lineas)
                    {
                        var campos = linea.Split(',');
                        string nombreCategoria = campos[1];

                        if (nombreCategoria.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Categoria categoria = new Categoria
                            {
                                Id = int.Parse(campos[0]),
                                Nombre = campos[1],
                                Descripcion = campos[2]
                            };
                            categoriasEncontradas[index++] = categoria;
                        }
                    }
                }
            }

            Categoria[] categoriasFinales = new Categoria[index];
            Array.Copy(categoriasEncontradas, categoriasFinales, index);
            return categoriasFinales;
        }
    }
}

