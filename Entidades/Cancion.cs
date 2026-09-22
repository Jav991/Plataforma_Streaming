using System;
using System.Collections.Generic;
using System.Text;

/*
 * 
PARTE 2 — CANCIONES
Crea una clase:
Cancion
que herede de Contenido.
Una canción tendrá además:
• Artista
• Genero
Cuando se reproduzca una canción:
• Las reproducciones aumentarán en 1.
• Se mostrará un mensaje indicando que la canción está sonando.
Ejemplo:
Reproduciendo: Blinding Lights
Artista: The Weeknd
Reproducciones: 16

 */

namespace Plataforma_Streaming.Entidades
{
    public class Cancion : Contenido
    {
        public Cancion(string titulo, int duracion, 
            int reproducciones, string artista, string genero) : base(titulo, duracion, reproducciones)
        {
            Artista = artista;
            Genero = genero;
            this.reproducciones = reproducciones;
        }
        public String Artista { get; set; }
        public String Genero { get; set; }

        public void AumentarReproducciones()
        {
            this.reproducciones +=1;
        }
        public void MostrarCancion()
        {
           AumentarReproducciones();
           Console.WriteLine(
               $"Reproduciendo: {this.titulo}\n" +
               $"Artista: {this.Artista}\n" +
               $"Reproducciones: {this.reproducciones}");
        }
        public override void Reproducir()
        {
            throw new NotImplementedException();
        }
    }
}