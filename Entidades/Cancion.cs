using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    public class Cancion : Contenido, IDescargable
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

        private bool estadoDescarga = false;

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
               $"Reproducciones: {this.reproducciones} \n");
        }

        public void descargar()
        {
            if (estadoDescarga == false)
            {
                estadoDescarga = true;
                Console.WriteLine($"La Canción {this.titulo} se ha descargado con exito, estado: {estadoDescarga}");
            }
            return;
        }
        public void eliminarDescarga()
        {
            if (estadoDescarga)
            {
                estadoDescarga = false;
                Console.WriteLine($"El estado de la descarga de la {this.titulo} ha sido eliminado y deja de estar descargado, estado: {estadoDescarga} ");
            }
            return;
        }



        public override void Reproducir()
        {
            throw new NotImplementedException();
        }
    }
}