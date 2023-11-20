using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Clientes
    {
        public int ClienteId { get; set; }
        public int NroDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public Barrios Barrio { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public TipoDoc TipoDocId { get; set; }

        public Clientes(int clienteid,int nrodoc,string nombre, string apelido,DateTime fechaNac,int telefono,string email,Barrios barrio,string Calle,int altura,int nroDoc,TipoDoc tipoDoc)
        {
                this.ClienteId = clienteid; 
                this.NroDoc = nrodoc;
            this.Nombre = nombre;
            this.Apellido = apelido;
            this.FechaNac = fechaNac;
            this.Telefono= telefono;
            this.Email = email;
            this.Barrio = barrio;
            this.Calle = Calle;
            this.TipoDocId = tipoDoc;

        }
        public Clientes()
        {
            ClienteId = 0;
            NroDoc = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            FechaNac = DateTime.Now;
            Telefono = 0;
            Email = string.Empty;
             Barrio= null;
            Altura = 0;
            TipoDocId = null;

        }
    }
}
