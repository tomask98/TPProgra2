﻿using CordobaCineBack.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Peliculas
    {
        
        public int Id_pelicula { get; set; }
        public string Nombre_pelicula { get; set; }
        public Generos Genero { get; set; }


        public Peliculas()
        {
            Id_pelicula = 0;
            Nombre_pelicula = string.Empty;
           
            Genero = new Generos();
            
        }

        public Peliculas(int peliculaid, string nombrepelicula, Generos genero)
        {
            Id_pelicula = peliculaid;
            Nombre_pelicula = nombrepelicula;
            Genero = genero;
          
        }
       
        public Peliculas(int peliculaid, string nombrepelicula)
        {
            Id_pelicula = peliculaid;
            Nombre_pelicula = nombrepelicula;
        }


        public override string ToString()
        {
            return Nombre_pelicula;
        }
    }
}
