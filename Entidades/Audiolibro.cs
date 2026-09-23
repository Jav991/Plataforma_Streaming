using System;
using System.Collections.Generic;
using System.Text;

namespace Plataforma_Streaming.Entidades
{
    internal class Audiolibro : Contenido
    {
       
       public Audiolibro(string titulo, int duracion,
       int reproducciones, string autor, string narrador) : base(titulo, duracion, reproducciones)
        {
            this.autor = autor;
            this.narrador = narrador;
        }
        public string autor { get; set; }
        public string narrador { get; set; }

        
        public void mostrarAudoLibro()
        {
            Console.WriteLine(
               $"Reproduciendo Audiolibro: {this.titulo}\n" +
               $"Autor/a: {this.autor}\n" +
               $"Narrador: {this.narrador}\n" +
               $"Reproduciones: {this.reproducciones} \n"
            );
        }

        public override void Reproducir()
        {
            this.reproducciones++;
            this.mostrarAudoLibro();
        }
    }
}
