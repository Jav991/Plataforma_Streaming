namespace  Plataforma_Streaming.Entidades{
    public abstract class Contenido
    {
        public string titulo { get; set; }
        public int duracion { get; set; }
        public int reproducciones { get; set; }
        protected Contenido(string titulo, int duracion, int reproducciones)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.reproducciones = reproducciones;
        }
        public abstract void Reproducir();

        public virtual void mostrarInformacion()
        {
           Console.WriteLine($"Título: {titulo}");
           Console.WriteLine($"Duración: {duracion}");
           Console.WriteLine($"Reproducciones: {reproducciones}");
        }
    }
}