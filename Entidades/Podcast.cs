
using System;
using System.Collections.Generic;
using System.Text;
/* 
Crea una clase:
Podcast
que herede de Contenido.
Tendrá además:
• Presentador
• NumeroEpisodio
Cuando se reproduzca:
• Las reproducciones aumentarán en 1.
• Se mostrará la información del episodio.
Ejemplo:
Reproduciendo podcast: La tecnología de mañana
Presentador: Laura Gómez
Episodio: 12
Reproducciones: 8
*/

namespace Plataforma_Streaming.Entidades
{
    public class Podcast : Contenido
    {
        public Podcast(string titulo, int duracion, 
        int reproducciones, string genero, string presentador, int numeroEpisodio ) : base(titulo, duracion, reproducciones)
        {
            Presentador = presentador;
            this.numeroEpisodio = numeroEpisodio;
            this.reproducciones = reproducciones;
        }
        public String Presentador {get; set;}
        public int numeroEpisodio {get; set;}

        public int aumentarPodcast(int numeroEpisodio)
        {
            if(numeroEpisodio <= 0)
            {
                Console.WriteLine("Hola :)");
                return 0;
            }

            else
            {
                this.reproducciones ++;
            }
            
            return this.reproducciones;
        }
        public void mostrarPodcast()
        {
            aumentarPodcast(12);
            Console.WriteLine(
               $"Reproduciendo Podcast: {this.titulo}\n" +
               $"Presentador/a: {this.Presentador}\n" +
               $"Episodio: {this.numeroEpisodio}\n" +
               $"Reproduciones: {this.reproducciones} \n"
            );
        }
        public override void Reproducir()
        {
            throw new NotImplementedException();
        }
    }
}