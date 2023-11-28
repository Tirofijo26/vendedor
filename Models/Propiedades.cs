namespace Vendedor.Models
{
    public class Propiedades
    {

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Tarea { get; set; }
        public int Dormitorios { get; set; }
        public int Baños { get; set; }
        public int Garajes { get; set; }
        public string Imagen {get; set;}

        public Propiedades(int Id, string Tipo, string Tarea, int Dormitorios, int Baños, int Garajes, string Imagen)
        {
            this.Id = Id;
            this.Tipo = Tipo;
            this.Tarea = Tarea;
            this.Dormitorios = Dormitorios;
            this.Baños = Baños;
            this.Garajes = Garajes;
            this.Imagen = Imagen;
        }

        public Propiedades() { }
    }
}