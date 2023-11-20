using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Funciones
    {
        public int FuncionId { get; set; }
        public Horarios HorarioID { get; set; }
        public DateTime Fecha { get; set; }
        public bool Subtitulo { get; set; }
        public Peliculas PeliculaId { get; set; }
        public Salas SalasId { get; set; }

        public Funciones(int funcionesId,Horarios horarioid,DateTime fecha,bool subtitulo,Peliculas peliculaid,Salas salaid)
        {
            FuncionId = funcionesId;
            HorarioID = horarioid;
            Fecha = fecha;
            Subtitulo = subtitulo;
            PeliculaId = peliculaid;
            SalasId = salaid;

        }
        public Funciones()
        {
            FuncionId = 0;
            HorarioID = new Horarios();
            Fecha = DateTime.Now;
            Subtitulo = false;
            PeliculaId = new Peliculas();
            SalasId= new Salas();
        }
    }
}
