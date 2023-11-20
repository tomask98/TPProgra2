using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Servicios.Interfaz
{
    public interface IServicio
    {
        List<Peliculas> traerPeliculas();
        int ProximaFuncion();

        List<Horarios> traerHorarios();
        List<Sucursales> traerSucursales();
        List<TipoSalas> traerSalas(int idSucursal);
    }
}
