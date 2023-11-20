using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Horarios
    {
        public int Id_horario { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }


        

        
        public Horarios(int id_horario, DateTime inicio,DateTime final)
        {
            Id_horario = id_horario;
            Inicio = inicio;
            Final = final;
        }

        public Horarios()
        {
            Id_horario = 0;
        }

        public string HorarioCompleto
        {
            get { return $"{Inicio.ToString("hh:mm tt")} - {Final.ToString("hh:mm tt")}"; }
        }


        public override string ToString()
        {
            return HorarioCompleto;
        }
    }
}
