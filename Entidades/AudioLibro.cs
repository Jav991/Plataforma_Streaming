using System;
using System.Collections.Generic;
using System.Text;
using Plataforma_Streaming.Interfaces;

namespace Plataforma_Streaming.Entidades
{
    internal class Audiolibro : Contenido, IDescargable
    {
       
       public Audiolibro(string titulo, int duracion,
       int reproducciones, string autor, string narrador) : base(titulo, duracion, reproducciones)
        {
            this.autor = autor;
            this.narrador = narrador;
        }
        public string autor { get; set; }
        public string narrador { get; set; }

        private bool estadoDescarga = false;

        public void mostrarAudoLibro()
        {
            Console.WriteLine(
               $"Reproduciendo Audiolibro: {this.titulo}\n" +
               $"Autor/a: {this.autor}\n" +
               $"Narrador: {this.narrador}\n" +
               $"Reproduciones: {this.reproducciones} \n"
            );
        }

        public void descargar()
        {
            if (estadoDescarga == false)
            {
                estadoDescarga = true;
                Console.WriteLine($"El audiolibro: {this.titulo} se ha descargado con exito, estado: {estadoDescarga}");
            }
            return;
        }
        public void eliminarDescarga()
        {
            if (estadoDescarga)
            {
                estadoDescarga = false;
                Console.WriteLine($"El estado de la descarga del audilibro: {this.titulo} ha sido eliminado y deja de estar descargado., estado: {estadoDescarga} ");
            }
            return;
        }



        public override void Reproducir()
        {
            this.reproducciones++;
            this.mostrarAudoLibro();
        }
    }
}