using System;

namespace GestionBiblioteca.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } 
        public string ISBN { get; set; } 
        public string Editorial { get; set; } 
        public string Edicion { get; set; } 
        public DateTime FechaPublicacion { get; set; } 
        public string NumeroCopias { get; set; } 
        public string UbicacionFisica { get; set; }
        public bool Disponible { get; set; } 
        public Autor Autor { get; set; }
        public Categoria Categoria { get; set; } 
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public string NombreAutor => Autor?.Nombre; 
        public string NombreCategoria => Categoria?.Nombre;
       // public DateTime? FechaDisponibilidad { get; set; }

        public Libro() { 
        }

    }

}
