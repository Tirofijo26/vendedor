using Vendedor.Models;
namespace Vendedor.Services
{
    public static class PropiedadesService
    {
        static List<Propiedades> Propiedades { get; }
        static int nextId = 9;

        static PropiedadesService()
        {
            Propiedades = new List<Propiedades>
            {
                new() { Id = 0, Tipo = "no existe", Tarea = "",Dormitorios = 0, Baños = 0, Garajes = 0, Imagen = "no existe"},
                new() { Id = 1, Tipo = "Departamento", Tarea = "Alquilar",Dormitorios = 0, Baños = 0, Garajes = 0, Imagen = "https://photoshop-kopona.com/uploads/posts/2019-04/1555669048_country-houses_2.jpg"},
                new() { Id = 2, Tipo = "Casa", Tarea = "Comprar",Dormitorios = 0, Baños = 0, Garajes = 0, Imagen = "~/img/propiedades.png"},
                new() { Id = 3, Tipo = "Oficina", Tarea = "Alquilar",Dormitorios = 0, Baños = 0, Garajes = 0, Imagen = "~/img/propiedades.png"},
                new() { Id = 4, Tipo = "Comercios", Tarea = "Comprar",Dormitorios = 0, Baños = 0, Garajes = 0, Imagen = "~/img/propiedades.png"},
                new() { Id = 5, Tipo = "Countries", Tarea = "Alquilar",Dormitorios = 0, Baños = 0, Garajes = 0, Imagen = "~/img/propiedades.png"},
                new() { Id = 6, Tipo = "Hoteles", Tarea = "Comprar",Dormitorios = 0, Baños = 0, Garajes = 0, Imagen = "~/img/propiedades.png"},
                new() { Id = 7, Tipo = "Almacenes", Tarea = "Alquilar",Dormitorios = 0, Baños = 0, Garajes = 0, Imagen = "~/img/propiedades.png"},
                new() { Id = 8, Tipo = "Barrios", Tarea = "Comprar",Dormitorios = 0, Baños = 0, Garajes = 0, Imagen = "~/img/propiedades.png"},
            };
        }

        public static List<Propiedades> GetAll() => Propiedades;

        public static Propiedades? Get(int id) => Propiedades.FirstOrDefault(Propiedad => Propiedad.Id == id);

        public static void Add(Propiedades propiedad)
        {
            propiedad.Id = nextId++;
            Propiedades.Add(propiedad);
        }

        public static void Delete(int id)
        {
            var prop = Get(id);
            if (prop != null)
            {
                Propiedades.Remove(prop);
            }
        }
    }
}
